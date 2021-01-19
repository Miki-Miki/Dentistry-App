using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Controllers
{
    public class SesijaController : Controller
    {

        private readonly IWebHostEnvironment webHostEnviroment;

       
        public SesijaController(IWebHostEnvironment _webHostEnvironment = null)
        {
            webHostEnviroment = _webHostEnvironment;
        }

        public IActionResult Sesija(Sesija sesija, int terminId) //treba se poslati termin za koji se radi sesija
        {
            ApplicationDbContext db = new ApplicationDbContext();

            Termini termin = db.Termini.Find(terminId);
            Pacijent pacijentNaTerminu = db.Pacijenti.Find(termin.PacijentId);
            ZakazanaUsluga ZakazanaUsluga = db.ZakazanaUsluga.Where(a => a.TerminId == terminId).FirstOrDefault();
             Usluga usluga = db.Usluga.Find(ZakazanaUsluga.UslugaId);

            if (sesija.Id == 0)
            {
                Sesija novaSesija = new Sesija();
                novaSesija.TerminId = terminId;
                novaSesija.Termin = termin;
                Stomatolog stomatolog = db.Stomatolozi.Find(User.Identity.GetUserId());

                if (stomatolog != null)
                {
                    novaSesija.Stomatolog = stomatolog;
                    novaSesija.StomatologId = stomatolog.Id;
                }
                db.Sesija.Add(novaSesija);
                db.SaveChanges();

                SesijaVM sesijavm2 = new SesijaVM
                {
                    SesijaId = novaSesija.Id,
                    TerminId = terminId,
                    Termin = termin,
                    PacijentId = termin.PacijentId,
                    Pacijent = pacijentNaTerminu,
                    ZakazanaUsluga = ZakazanaUsluga,
                    ZakazanaUslugaId = ZakazanaUsluga.Id,
                    Usluga = usluga,
                    loadajCTNalaz = false
                };

                return View(sesijavm2);
            }

            CTNalaz ctnalaz = db.CTNalaz.Find(sesija.CTNalazId);

            SesijaVM sesijavm = new SesijaVM
            {
                SesijaId = sesija.Id,
                TerminId = terminId,
                Termin = termin,
                CTNalazId = ctnalaz.Id,
                CTNalaz = ctnalaz,
                PacijentId = termin.PacijentId,
                Pacijent = pacijentNaTerminu,
                ZakazanaUsluga = ZakazanaUsluga,
                ZakazanaUslugaId = ZakazanaUsluga.Id,
                Usluga = usluga,
                loadajCTNalaz = true
            };

            return View(sesijavm);
        }

        public void Odustani(int SesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(SesijaId);

            DijagnozaNaSesiji dijagnoza = db.DijagnozaNaSesiji.Where(a => a.SesijaId == SesijaId).FirstOrDefault();
            LijekNaSesiji lijek = db.LijekNaSesiji.Where(a => a.SesijaId == SesijaId).FirstOrDefault();
            TerapijaNaSesiji terapija = db.TerapijaNaSesiji.Where(a => a.SesijaId == SesijaId).FirstOrDefault();

            if(dijagnoza != null)
                db.DijagnozaNaSesiji.Remove(dijagnoza);
            if (lijek != null)
                db.LijekNaSesiji.Remove(lijek);
            if (terapija != null)
                db.TerapijaNaSesiji.Remove(terapija);

            db.Sesija.Remove(sesija);

            db.SaveChanges();

        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public IActionResult NovaDijagnoza(int sesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(sesijaId);

            SesijaVM sesijaVM = new SesijaVM
            {
                SesijaId = sesija.Id,
                Dijagnoze = db.Dijagnoze.OrderBy(a => a.Id).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
            };

            return View("DijagnozaOdabir", sesijaVM); 
        }

        public void SaveDijagnoza(int SesijaId, int DijagnozaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija= db.Sesija.Find(SesijaId);
            Dijagnoze dijagnoza = db.Dijagnoze.Find(DijagnozaId);

            DijagnozaNaSesiji dijagnozaNaSesiji =  db.DijagnozaNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            if(dijagnozaNaSesiji != null)
            {
                dijagnozaNaSesiji.Dijagnoza = dijagnoza;
                dijagnozaNaSesiji.DijagnozaId = dijagnoza.Id;
                db.SaveChanges();
            }
            else
            {
                dijagnozaNaSesiji = new DijagnozaNaSesiji
                {
                    Sesija = sesija,
                    SesijaId = sesija.Id,
                    Dijagnoza = dijagnoza,
                    DijagnozaId = dijagnoza.Id,
                };
                db.DijagnozaNaSesiji.Add(dijagnozaNaSesiji);
                db.SaveChanges();
            }
        }

        public int GetDijagnoza(int SesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(SesijaId);

            DijagnozaNaSesiji dijagnozaNaSesiji = db.DijagnozaNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            if (dijagnozaNaSesiji != null)
                return (int)dijagnozaNaSesiji.DijagnozaId;
            else
                return 1;
        }
      
        /////////////////////////////////////////////////////////////////////////////////////////

        public IActionResult NovaTerapija(int sesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(sesijaId);

            SesijaVM sesijaVM = new SesijaVM
            {
                SesijaId = sesija.Id,
                Terapije = db.Terapije.OrderBy(a => a.Id).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
            };

            return View("TerapijaOdabir", sesijaVM);
        }
        public void SaveTerapija(int SesijaId, int TerapijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(SesijaId);
            Terapije terapije = db.Terapije.Find(TerapijaId);

            TerapijaNaSesiji terapijaNaSesiji = db.TerapijaNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            if (terapijaNaSesiji != null)
            {
                terapijaNaSesiji.Terapija = terapije;
                terapijaNaSesiji.TerapijaId = terapije.Id;
                db.SaveChanges();
            }
            else
            {
                terapijaNaSesiji = new TerapijaNaSesiji
                {
                    Sesija = sesija,
                    SesijaId = sesija.Id,
                    Terapija = terapije,
                    TerapijaId = terapije.Id,
                };
                db.TerapijaNaSesiji.Add(terapijaNaSesiji);
                db.SaveChanges();
            }
        }

        public int GetTerapija(int SesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(SesijaId);

            TerapijaNaSesiji terapijaNaSesiji = db.TerapijaNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            if (terapijaNaSesiji != null)
                return (int)terapijaNaSesiji.TerapijaId;
            else
                return 1;
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public IActionResult NoviLijek(int sesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(sesijaId);

            SesijaVM sesijaVM = new SesijaVM
            {
                SesijaId = sesija.Id,
                Lijekovi = db.Lijekovi.OrderBy(a => a.Id).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
            };

            return View("LijekOdabir", sesijaVM);


        }
        public void SaveLijek(int SesijaId, int LijekId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(SesijaId);
            Lijekovi lijek = db.Lijekovi.Find(LijekId);

            LijekNaSesiji lijekNaSesiji = db.LijekNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            if (lijekNaSesiji != null)
            {
                lijekNaSesiji.Lijek = lijek;
                lijekNaSesiji.LijekId = lijek.Id;
                db.SaveChanges();
            }
            else
            {
                lijekNaSesiji = new LijekNaSesiji
                {
                    Sesija = sesija,
                    SesijaId = sesija.Id,
                    Lijek = lijek,
                    LijekId = lijek.Id,
                };
                db.LijekNaSesiji.Add(lijekNaSesiji);
                db.SaveChanges();
            }
        }

        public int GetLijek(int SesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(SesijaId);

            LijekNaSesiji lijekNaSesiji = db.LijekNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            if (lijekNaSesiji != null)
                return (int)lijekNaSesiji.LijekId;
            else
                return 2;
        }

        ///////////////////////////////////////////////////////////////////////////////
        public IActionResult NoviCTNalaz(int sesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(sesijaId);

            SesijaVM sesijaVM = new SesijaVM();
            sesijaVM.SesijaId = sesija.Id;

            if (sesija.CTNalazId != null)
            {
                CTNalaz ctnalaz = db.CTNalaz.Find(sesija.CTNalazId);
                sesijaVM.CTNalazSlikaPutanja = ctnalaz.CTNalazSlika;
            }
        

            return View("CTSnimakOdabir", sesijaVM);
        }

        [HttpPost]
        public IActionResult NoviCTSnimak(SesijaVM vm)
        {
            string stringFileName = FileUpload(vm);
            ApplicationDbContext db = new ApplicationDbContext();

            var CTNalaz = new CTNalaz
            {
                CTNalazSlika = stringFileName
            };
           
            db.CTNalaz.Add(CTNalaz);

            Sesija sesija = db.Sesija.Find(vm.SesijaId);
            sesija.CTNalaz = CTNalaz;

            db.SaveChanges();

            //Sesija(sesija);
            return RedirectToAction("Sesija", sesija);

            //return View("Sesija", sesija);
        }

        private string FileUpload(SesijaVM vm)
        {

            string fileName = null;
            if (vm.CTNalazSlika != null)
            {
                string uploadDir = Path.Combine(webHostEnviroment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "_" +  vm.CTNalazSlika.FileName;
                string filePath = Path.Combine(uploadDir, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    vm.CTNalazSlika.CopyTo(fileStream);
                }
            }
            return fileName;
        }


    }
}