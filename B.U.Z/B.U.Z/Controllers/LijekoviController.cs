using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using Microsoft.AspNetCore.Mvc;

namespace B.U.Z.Controllers
{
    public class LijekoviController : Controller
    {
        public IActionResult Lijekovi()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Lijekovi> m = db.Lijekovi.ToList();
            return View(m);
        }
        public IActionResult NoviLijek()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int redniBroj = db.Lijekovi.Count() + 1;
            return View(redniBroj);
        }
        public IActionResult SpasiNoviLijek(Lijekovi l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Lijekovi novi = new Lijekovi
            {
                Naziv = l.Naziv,
                Opis = l.Opis
            };
            db.Lijekovi.Add(novi);
            db.SaveChanges();
            return Redirect("Lijekovi");
        }
        public IActionResult ObrisiLijek(int LijekId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Lijekovi l = db.Lijekovi.Find(LijekId);
            db.Lijekovi.Remove(l);
            db.SaveChanges();
            return Redirect("Lijekovi");
        }
    }
}
