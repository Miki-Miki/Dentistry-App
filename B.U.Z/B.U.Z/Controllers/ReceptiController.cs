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
    public class ReceptiController : Controller
    {
        public IActionResult Recepti(string filter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Recepti> m = db.Recepti.Where(s => filter == null || s.Naziv.ToLower().StartsWith(filter)).ToList();
            return View(m);
        }
        public IActionResult NoviRecept()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int redniBroj = db.Recepti.Count() + 1;
            return View(redniBroj);
        }
        public IActionResult SpasiNoviRecept(Recepti l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Recepti novi = new Recepti
            {
                Naziv = l.Naziv,
                Opis = l.Opis,
                Preporuka = l.Preporuka
            };
            db.Recepti.Add(novi);
            db.SaveChanges();
            return Redirect("Recepti");
        }
        public IActionResult ObrisiRecept(int ReceptId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Recepti l = db.Recepti.Find(ReceptId);
            db.Recepti.Remove(l);
            db.SaveChanges();
            return Redirect("Recepti");
        }
        public IActionResult UrediRecept(int ReceptId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Recepti l = db.Recepti.Find(ReceptId);
            int redniBroj = db.Recepti.Count() + 1;
            var m = new ReceptiUrediVM
            {
                Recept_Id = l.Id,
                Naziv = l.Naziv,
                Opis = l.Opis,
                Preporuka = l.Preporuka,
                RedniBroj = redniBroj
            };
            return View(m);
        }
        public IActionResult SpasiNoviStariRecept(Recepti l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Recepti novi = db.Recepti.Find(l.Id);
            novi.Naziv = l.Naziv;
            novi.Opis = l.Opis;
            novi.Preporuka = l.Preporuka;
            db.SaveChanges();
            return Redirect("Recepti");
        }

        public IActionResult SelectRecept(int ReceptId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Recepti l = db.Recepti.Find(ReceptId);
            return View("ReceptiOdabir", l);
        }
    }
}
