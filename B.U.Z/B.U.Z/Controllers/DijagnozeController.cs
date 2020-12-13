using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B.U.Z.Controllers
{
    public class DijagnozeController : Controller
    {
        public IActionResult Dijagnoze(string filter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Dijagnoze> m = db.Dijagnoze.Where(s => filter == null || s.Naziv.ToLower().StartsWith(filter)).ToList();
            return View(m);
        }
        public IActionResult NovaDijagnoza()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int redniBroj = db.Dijagnoze.Count() + 1;
            return View(redniBroj);
        }
        public IActionResult SpasiNovuDijagnozu(Dijagnoze l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Dijagnoze novi = new Dijagnoze
            {
                Naziv = l.Naziv,
                Opis = l.Opis,
                Preporuka = l.Preporuka
            };
            db.Dijagnoze.Add(novi);
            db.SaveChanges();
            return Redirect("Dijagnoze");
        }
        public IActionResult ObrisiDijagnozu(int DijagnozaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Dijagnoze l = db.Dijagnoze.Find(DijagnozaId);
            db.Dijagnoze.Remove(l);
            db.SaveChanges();
            return Redirect("Dijagnoze");
        }
        public IActionResult UrediDijagnozu(int DijagnozaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Dijagnoze l = db.Dijagnoze.Find(DijagnozaId);
            int redniBroj = db.Dijagnoze.Count() + 1;
            var m = new DijagnozeUrediVM
            {
                Dijagnoza_Id = l.Id,
                Naziv = l.Naziv,
                Opis = l.Opis,
                Preporuka = l.Preporuka,
                RedniBroj = redniBroj
            };
            return View(m);
        }
        public IActionResult SpasiNovuStaruDijagnozu(Dijagnoze l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Dijagnoze novi = db.Dijagnoze.Find(l.Id);
            novi.Naziv = l.Naziv;
            novi.Opis = l.Opis;
            novi.Preporuka = l.Preporuka;
            db.SaveChanges();
            return Redirect("Dijagnoze");
        }

        public IActionResult SelectDijagnozu(int DijagnozaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Dijagnoze l = db.Dijagnoze.Find(DijagnozaId);
            return View("DijagnozaOdabir", l);
        }
    }
}
