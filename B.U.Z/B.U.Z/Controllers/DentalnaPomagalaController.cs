using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace B.U.Z.Controllers
{
    public class DentalnaPomagalaController : Controller
    {
        public IActionResult DentalnaPomagala(string filter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<DentalnaPomagala> m = db.DentalnaPomagala.Where(s => filter == null || s.Naziv.ToLower().StartsWith(filter)).Include("Pacijent").ToList();
            return View(m);
        }
        public IActionResult NovoDentalnoPomagalo()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int redniBroj = db.DentalnaPomagala.Count() + 1;
            NovoDentalnoPomagaloVM model = new NovoDentalnoPomagaloVM
            {
                BrojDentalnihPomagala=redniBroj,
                pacijenti = db.Pacijenti.OrderBy(a => a.FirstName).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.FirstName + " "+a.LastName }).ToList(),
            };
            return View(model);
        }
        public IActionResult SpasiNovoDentalnoPomagalo(DentalnaPomagala l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            DentalnaPomagala novi = new DentalnaPomagala
            {
                Naziv = l.Naziv,
                Opis = l.Opis,
                PacijentId=l.PacijentId
            };
            db.DentalnaPomagala.Add(novi);
            db.SaveChanges();
            return Redirect("DentalnaPomagala");
        }
        public IActionResult ObrisiDentalnoPomagalo(int DentalnoPomagaloId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            DentalnaPomagala l = db.DentalnaPomagala.Find(DentalnoPomagaloId);
            db.DentalnaPomagala.Remove(l);
            db.SaveChanges();
            return Redirect("DentalnaPomagala");
        }
        public IActionResult UrediDentalnoPomagalo(int DentalnoPomagaloId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            DentalnaPomagala l = db.DentalnaPomagala.Find(DentalnoPomagaloId);
            int redniBroj = db.Dijagnoze.Count() + 1;
            var m = new DentalnaPomagalaUrediVM
            {
                DentalnoPomagalo_Id = l.Id,
                Naziv = l.Naziv,
                Opis = l.Opis,
                RedniBroj = redniBroj,
                PacijentId=l.PacijentId,
                pacijenti= db.Pacijenti.OrderBy(a => a.FirstName).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.FirstName + " " + a.LastName }).ToList()
            };
            return View(m);
        }
        public IActionResult SpasiNovoStaroDentalnoPomagalo(NovoDentalnoPomagaloVM l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            DentalnaPomagala novi = db.DentalnaPomagala.Find(l.DentalnoPomagaloId);
            novi.Naziv = l.Naziv;
            novi.Opis = l.Opis;
            novi.PacijentId = l.PacijentId;
            db.SaveChanges();
            return Redirect("DentalnaPomagala");
        }

        public IActionResult SelectDentalnoPomagalo(int DentalnoPomagaloId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            DentalnaPomagala dp = db.DentalnaPomagala.Find(DentalnoPomagaloId);
            NovoDentalnoPomagaloVM l = new NovoDentalnoPomagaloVM
            {
                pacijenti = db.Pacijenti.OrderBy(a => a.FirstName).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.FirstName + " " + a.LastName }).ToList(),
                DentalnoPomagaloId = dp.Id,
                Naziv = dp.Naziv,
                Opis = dp.Opis,
                PacijentId = dp.PacijentId,
            };
            return View("DentalnaPomagalaOdabir", l);
        }

        public String getOpis(int DentalnoPomagaloId)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            DentalnaPomagala dentalnaPomagala = dbContext.DentalnaPomagala.Find(DentalnoPomagaloId);
            return dentalnaPomagala.Opis;
        }

        public String getNaziv(int DentalnoPomagaloId)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            DentalnaPomagala dentalnaPomagala = dbContext.DentalnaPomagala.Find(DentalnoPomagaloId);
            return dentalnaPomagala.Naziv;
        }
    }
}
