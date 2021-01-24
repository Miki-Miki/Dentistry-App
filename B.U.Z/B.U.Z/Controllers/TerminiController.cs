using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;

namespace B.U.Z.Controllers
{
    [Route("Termini")]
    public class TerminiController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;        

        public TerminiController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("Termini")]
        public IActionResult Termini()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Termini> termini = db.Termini.Include(s => s.Pacijent).ToList();
            return View(termini);
        }

        public IActionResult DodajTermin(Termini t)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent pacijent = db.Pacijenti.Find(t.PacijentId);

            Termini termin = new Termini
            {
                Pacijent = pacijent,
                PacijentId = pacijent.Id,
                TerminStart = t.TerminStart,
                TerminEnd = t.TerminEnd,
                basePrice = t.basePrice,
            };
            db.Termini.Add(termin);
            db.SaveChanges();

            List<Termini> termini = db.Termini.Include(s => s.Pacijent).ToList();
            return View("Termini", termini);
        }

        [Route("NoviTermin")]
        public IActionResult NoviTermin()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Pacijent> pacijenti = db.Pacijenti.ToList();

            return View(pacijenti);
        }

        [Route("MojiTermini")]
        public IActionResult MojiTermini()
        {
            return View("PacijentMojiTermini");
        }

        public IActionResult OdaberiPacijenta(string pacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent pacijent = db.Pacijenti.Find(pacijentId);
            return View( "PacijentOdabir", pacijent);
        }

        public IActionResult OdaberiTermin(int t)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Termini termin = db.Termini.Find(t);

            Pacijent pacijent = db.Pacijenti.Find(termin.PacijentId);

            TerminiVM terminVM = new TerminiVM
            {
                basePrice = termin.basePrice,
                TerminStart = termin.TerminStart,
                TerminEnd = termin.TerminEnd,
                pacijent = pacijent
            };
           
            return View("TerminOdabir", terminVM);
        }

        [Route("Kalendar")]
        public async Task<IActionResult> OtvoriKalendar()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            ApplicationDbContext db = new ApplicationDbContext();
            var aspUser = db.ApplicationUsers.Find(user.Id);

            UslugaVM usluge = new UslugaVM
            {
                Usluge = db.Usluga.OrderBy(a => a.Id).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList()                
            };

            if (aspUser is Pacijent)
            {
                return View("PacijentKalendar", usluge);
            }
            else
            {
                return View("Termini");
            }
        }

        [Route("PFindAll")]
        public IActionResult PFindAllTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();

            ZakazanaUsluga zakazanaUsluga = new ZakazanaUsluga();
            Usluga _usluga = new Usluga();
            Pacijent _pacijent = new Pacijent();

            foreach(var t in terminiDB)
            {
                _pacijent = db.Pacijenti.Find(t.PacijentId);

                if (t.isPrihvacen == true)
                {
                    zakazanaUsluga = db.ZakazanaUsluga.SingleOrDefault(x => x.TerminId == t.Id);
                    _usluga = db.Usluga.SingleOrDefault(x => x.Id == zakazanaUsluga.UslugaId);
                    
                    termini.Add(new TerminiVM()
                    {
                        basePrice = t.basePrice,
                        TerminStart = t.TerminStart,
                        TerminEnd = t.TerminEnd,
                        pacijent = _pacijent,
                        usluga = _usluga
                    });
                }
            }

            var terminiJSON = termini.Select(t => new
            {
                //id = t.Id,
                title = "Zauzeto",
                description = t.usluga.Naziv,
                start = t.TerminStart,
                end = t.TerminEnd
            });

            return new JsonResult(terminiJSON);
        }


        //Popravi
        [Route("SFindAllPrihvaceni")]
        public IActionResult SFindAllDaTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();
            Pacijent _pacijent = new Pacijent();            

            foreach (var t in terminiDB)
            {
                _pacijent = db.Pacijenti.Find(t.PacijentId);
                if(t.isPrihvacen == true)
                {
                    var _usluga = from zU in db.ZakazanaUsluga
                                      join U in db.Usluga
                                      on zU.UslugaId equals U.Id
                                      where zU.TerminId == t.Id
                                      select new Usluga
                                      {
                                          Id = U.Id,
                                          Cijena = U.Cijena,
                                          Naziv = U.Naziv,
                                          Opis = U.Opis
                                      };

                    termini.Add(new TerminiVM()
                    {
                        TerminId = t.Id,
                        basePrice = t.basePrice,
                        TerminStart = t.TerminStart,
                        TerminEnd = t.TerminEnd,
                        pacijent = _pacijent,
                        usluga = _usluga.FirstOrDefault(),
                        isPrihvacen = true
                    }) ;
                }
            }

            var terminiJSON = termini.Select(t => new
            {
                id = t.TerminId,
                title = t.pacijent.FirstName + " " + t.pacijent.LastName,
                description = t.usluga.Naziv,
                start = t.TerminStart,
                end = t.TerminEnd,
                basePrice = t.basePrice,
                pacijent = t.pacijent,
                usluga = t.usluga,
                isPrihvacen = true
            });

            return new JsonResult(terminiJSON);
        }

        [Route("SFindAllNePrihvaceni")]
        public IActionResult SFindAllNeTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();
            Pacijent _pacijent = new Pacijent();

            foreach (var t in terminiDB)
            {
                _pacijent = db.Pacijenti.Find(t.PacijentId);
                if (t.isPrihvacen == false)
                {
                    var _usluga = from zU in db.ZakazanaUsluga
                                  join U in db.Usluga
                                  on zU.UslugaId equals U.Id
                                  where zU.TerminId == t.Id
                                  select new Usluga
                                  {
                                      Id = U.Id,
                                      Cijena = U.Cijena,
                                      Naziv = U.Naziv,
                                      Opis = U.Opis
                                  };

                    termini.Add(new TerminiVM()
                    {
                        TerminId = t.Id,
                        basePrice = t.basePrice,
                        TerminStart = t.TerminStart,
                        TerminEnd = t.TerminEnd,
                        pacijent = _pacijent,
                        usluga = _usluga.FirstOrDefault(),
                        isPrihvacen = false
                    });
                }



            }

            var terminiJSON = termini.Select(t => new
            {
                id = t.TerminId,
                title = t.pacijent.FirstName + " " + t.pacijent.LastName,
                description = t.usluga.Naziv,
                start = t.TerminStart,
                end = t.TerminEnd,
                basePrice = t.basePrice,
                pacijent = t.pacijent,
                usluga = t.usluga,
                isPrihvacen = false
            });

            return new JsonResult(terminiJSON);
        }

        //Popravi
        [Route("FindAllMojiTermini")]
        public IActionResult FindAllMojiTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();
            Pacijent _pacijent = db.Pacijenti.Find(_userManager.FindByNameAsync(User.Identity.Name).Result.Id);

            foreach (var t in terminiDB)
            {
                if (_pacijent.Id == t.PacijentId && t.isPrihvacen == true)
                {
                    var _usluga = from zU in db.ZakazanaUsluga
                                  join U in db.Usluga
                                  on zU.UslugaId equals U.Id
                                  where zU.TerminId == t.Id
                                  select new Usluga
                                  {
                                      Id = U.Id,
                                      Cijena = U.Cijena,
                                      Naziv = U.Naziv,
                                      Opis = U.Opis
                                  };

                    termini.Add(new TerminiVM()
                    {
                        TerminId = t.Id,
                        basePrice = t.basePrice,
                        TerminStart = t.TerminStart,
                        TerminEnd = t.TerminEnd,
                        pacijent = _pacijent,
                        usluga = _usluga.FirstOrDefault()
                    });
                }

            }

            var terminiJSON = termini.Select(t => new
            {
                id = t.TerminId,
                title = t.usluga.Naziv,
                description = t.usluga.Naziv,
                start = t.TerminStart,
                end = t.TerminEnd,
                basePrice = t.basePrice,
                pacijent = t.pacijent,
                usluga = t.usluga
            });

            return new JsonResult(terminiJSON);
        }
      

        //[Route("ZapocniSesiju")]
        //[HttpPost]
        //public IActionResult ZapocniSesiju(int _terminId)
        //{
        //    var _sesijaController = new SesijaController();
        //    _sesijaController.ControllerContext = ControllerContext;

        //    return _sesijaController.Sesija(new Sesija(), _terminId);

        //    //return RedirectToAction("Sesija", "Sesija", new
        //    //{
        //    //    sesija = new Sesija(),
        //    //    terminId = _terminId
        //    //});
        //}

        [Route("FindCijena")]
        public double FindCijena(int uslugaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Usluga.Find(uslugaId).Cijena;
        }

        [HttpPost]
        [Route("SpremiTermin")]
        public IActionResult SpremiTermin(string terminStart, string selectedBasePrice, int _uslugaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //kad se ne selektuje vrijeme, nije dobar format
            DateTime tStart = DateTime.Parse(terminStart);
            DateTime tEnd = tStart.Add(new TimeSpan(1, 0, 0));

            Termini noviTermin = new Termini
            {
                PacijentId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id,
                TerminStart = tStart,
                TerminEnd = tEnd,
                basePrice = Convert.ToDouble(selectedBasePrice),
                isPrihvacen = false
            };

            db.Termini.Add(noviTermin);
            db.SaveChanges();

            ZakazanaUsluga novaZakazanaUsluga = new ZakazanaUsluga
            {
                UslugaId = _uslugaId,
                TerminId = noviTermin.Id
            };

            db.ZakazanaUsluga.Add(novaZakazanaUsluga);
            Obavijesti obavijest = new Obavijesti
            {
                Sadrzaj = "Pacijent" + " " + _userManager.FindByNameAsync(User.Identity.Name).Result.FirstName + " " + _userManager.FindByNameAsync(User.Identity.Name).Result.LastName
                + " " + "je zakazao/la termin na dan" + " " + noviTermin.TerminStart.Day+"."+noviTermin.TerminStart.Month+"."+noviTermin.TerminStart.Year +" "+ "u" + " " + noviTermin.TerminStart.TimeOfDay + " "+ "sati"
            };
            db.Obavijesti.Add(obavijest);
            db.SaveChanges();

            return View("PacijentMojiTermini");
        }

        [Route("MojiNePrihvaceniTermini")]
        public IActionResult FindAllMojiNePrihvaceniTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();
            Pacijent _pacijent = db.Pacijenti.Find(_userManager.FindByNameAsync(User.Identity.Name).Result.Id);

            foreach (var t in terminiDB)
            {
                if (_pacijent.Id == t.PacijentId && t.isPrihvacen == false)
                {
                    var _usluga = from zU in db.ZakazanaUsluga
                                  join U in db.Usluga
                                  on zU.UslugaId equals U.Id
                                  where zU.TerminId == t.Id
                                  select new Usluga
                                  {
                                      Id = U.Id,
                                      Cijena = U.Cijena,
                                      Naziv = U.Naziv,
                                      Opis = U.Opis,
                                      //Trajanje = U.Trajanje
                                  };

                    termini.Add(new TerminiVM()
                    {
                        TerminId = t.Id,
                        basePrice = t.basePrice,
                        TerminStart = t.TerminStart,
                        TerminEnd = t.TerminEnd,
                        pacijent = _pacijent,
                        usluga = _usluga.FirstOrDefault()
                    });
                }

            }

            var terminiJSON = termini.Select(t => new
            {
                id = t.TerminId,
                title = t.usluga.Naziv,
                description = t.usluga.Naziv,
                start = t.TerminStart,
                end = t.TerminEnd,
                basePrice = t.basePrice,
                pacijent = t.pacijent,
                usluga = t.usluga
            });

            return new JsonResult(terminiJSON);
        }

        [Route("OznaciTermin")]
        [HttpPost]
        public async Task<IActionResult> OznaciTermin(bool oznaka, int terminId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Termini selectedTermin = db.Termini.Find(terminId);
            ZakazanaUsluga zakazanaUsluga = db.ZakazanaUsluga.Find(terminId);

            Pacijent pacijent = db.Pacijenti.Find(selectedTermin.PacijentId);

            if(oznaka == true)
            {                
                var body = "<h3>Vaš termin na datum: "
                    + selectedTermin.TerminStart.ToString("dd/MM/yyyy HH:mm") +
                    " je prihvaćen.</h3>" +
                    "<br>Očekujemo vaš dolazak";

                var message = new MailMessage();
                var email = pacijent.Email;

                message.To.Add(new MailAddress(email.ToString()));
                message.From = new MailAddress("buz.stomatologija@gmail.com");
                message.Subject = "Vaš termin je prihvaćen!";
                message.Body = string.Format(body, "B.U.Z", "buz.stomatologija@gmail.com");
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "buz.stomatologija@gmail.com",
                        Password = "vmhXPuAg2hTEdw3"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                }

                selectedTermin.isPrihvacen = true;
                selectedTermin.AsistentId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;
                db.SaveChanges();

                return RedirectToAction("Termini", "Termini");
            }

            if(oznaka == false)
            {
                var body = "<h3>Vaš termin na datum: "
                    + selectedTermin.TerminStart.ToString("dd/MM/yyyy HH:mm") +
                    " je odbijen.</h3>" +
                    "<br>Molimo zakažite termin u neko drugo vrijeme.";

                var message = new MailMessage();
                var email = pacijent.Email;

                message.To.Add(new MailAddress(email.ToString()));
                message.From = new MailAddress("buz.stomatologija@gmail.com");
                message.Subject = "Vaš termin je odbijen.";
                message.Body = string.Format(body, "B.U.Z", "buz.stomatologija@gmail.com");
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "buz.stomatologija@gmail.com",
                        Password = "vmhXPuAg2hTEdw3"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                }

                db.ZakazanaUsluga.Remove(db.ZakazanaUsluga.SingleOrDefault(zU => zU.TerminId == terminId));
                db.Termini.Remove(db.Termini.SingleOrDefault(t => t.Id == terminId));
                db.SaveChanges();
                return RedirectToAction("Termini", "Termini");
            }

            //If you get to here you messed something up
            return View("Termini");
        }

    }
}
