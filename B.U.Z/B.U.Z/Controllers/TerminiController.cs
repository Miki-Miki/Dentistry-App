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
using Microsoft.EntityFrameworkCore;

namespace B.U.Z.Controllers
{
    [Route("Termini")]
    public class TerminiController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;        

        public TerminiController(UserManager<ApplicationUser> userManager,)
        {
            _userManager = userManager;            
        }

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


        public IActionResult NoviTermin()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Pacijent> pacijenti = db.Pacijenti.ToList();

            return View(pacijenti);
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
            //OVJDE SI STAOOOOO
            //!!!!
            //!!!!
            //!!!!

            return View("PacijentKalendar");
        }

        [Route("SFindAll")]
        public IActionResult SFindAllTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();

            foreach(var t in terminiDB)
            {
                Pacijent _pacijent = db.Pacijenti.Find(t.PacijentId);
                ZakazanaUsluga zakazanaUsluga = db.ZakazanaUsluga.Single(x => x.TerminId == t.Id);
                Usluga _usluga = db.Usluga.Single(x => x.Id == zakazanaUsluga.UslugaId);
                termini.Add(new TerminiVM()
                {
                    basePrice = t.basePrice,
                    TerminStart = t.TerminStart,
                    TerminEnd = t.TerminEnd,
                    pacijent = _pacijent,
                    usluga = _usluga
                });
            }

            var terminiJSON = termini.Select(t => new
            {
                //id = t.Id,
                title = t.pacijent.FirstName + " " + t.pacijent.LastName,
                description = t.usluga.Naziv,
                start = t.TerminStart,
                end = t.TerminEnd
            });

            return new JsonResult(terminiJSON);
        }

        [Route("PFindAll")]
        public IActionResult PFindAllTermini()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<Termini> terminiDB = db.Termini.ToList();
            List<TerminiVM> termini = new List<TerminiVM>();

            foreach (var t in terminiDB)
            {
                Pacijent _pacijent = db.Pacijenti.Find(t.PacijentId);
                ZakazanaUsluga zakazanaUsluga = db.ZakazanaUsluga.Single(x => x.TerminId == t.Id);
                Usluga _usluga = db.Usluga.Single(x => x.Id == zakazanaUsluga.UslugaId);
                termini.Add(new TerminiVM()
                {
                    basePrice = t.basePrice,
                    TerminStart = t.TerminStart,
                    TerminEnd = t.TerminEnd,
                    pacijent = _pacijent,
                    usluga = _usluga
                });
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

    }
}
