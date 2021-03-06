using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace B.U.Z.Controllers
{
    public class LijekoviController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public async Task<IActionResult> Lijekovi(string filter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List <Lijekovi> m = db.Lijekovi.Where(s => filter == null || s.Naziv.ToLower().StartsWith(filter)).ToList();
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
                Opis = l.Opis,
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
        public IActionResult UrediLijek(int LijekId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Lijekovi l = db.Lijekovi.Find(LijekId);
            int redniBroj = db.Lijekovi.Count() + 1;
            var m = new LijekoviUrediVM
            {
                Lijek_Id = l.Id,
                Naziv = l.Naziv,
                Opis = l.Opis,
                RedniBroj = redniBroj
            };
            return View(m);
        }
        public IActionResult SpasiNoviStariLijek(Lijekovi l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Lijekovi novi = db.Lijekovi.Find(l.Id);
            novi.Naziv = l.Naziv;
            novi.Opis = l.Opis;
            db.SaveChanges();
            return Redirect("Lijekovi");
        }

        public IActionResult SelectLijek(int LijekId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Lijekovi l = db.Lijekovi.Find(LijekId);
            return View("LijekoviOdabir", l);
        }

        public String getOpis(int lijekId)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            Lijekovi lijek = dbContext.Lijekovi.Find(lijekId);
            return lijek.Opis;
        }
    }
}
