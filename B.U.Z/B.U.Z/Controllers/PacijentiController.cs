using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace B.U.Z.Controllers
{
    public class PacijentiController : Controller
    {
        public IActionResult Pacijenti(string filter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Pacijent> m = db.Pacijenti.Where(s => filter == null || s.FirstName.ToLower().StartsWith(filter)).ToList();
            return View(m);
        }
        public IActionResult NoviPacijent()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int UkupnoPacijenata = db.Pacijenti.Count() + 1;
            PacijentiDodajVM model = new PacijentiDodajVM
            {
                Gradovi = db.Grad.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
                Spolovi=db.Spol.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
                UkupnoPacijenata=UkupnoPacijenata
            };
            return View(model);
        }
        public IActionResult SpasiNovogPacijenta(PacijentiDodajVM l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent novi = new Pacijent
            {
               FirstName=l.Ime,
               LastName=l.Prezime,
               GodinaRodjenja=l.DatumRodjenja,
               PhoneNumber=l.BrojTelefona,
               SpolId=l.SpolId,
               GradId=l.GradId
            };
            db.Pacijenti.Add(novi);
            db.SaveChanges();
            return Redirect("Pacijenti");
        }
        public IActionResult ObrisiPacijenta(string PacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent l = db.Pacijenti.Find(PacijentId);
            db.Pacijenti.Remove(l);
            db.SaveChanges();
            return Redirect("Pacijenti");
        }
        public IActionResult UrediPacijenta(string PacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent l = db.Pacijenti.Find(PacijentId);
            int redniBroj = db.Pacijenti.Count() + 1;
            var m = new PacijentiUrediVM
            {
                pacijent_id = l.Id,
                Ime = l.FirstName,
                Prezime = l.LastName,
                DatumRodjenja = l.GodinaRodjenja,
                RedniBroj = redniBroj,
                BrojTelefona=l.PhoneNumber
            };
            return View(m);
        }
        public IActionResult SpasiNovogStarogPacijenta(Pacijent l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent novi = db.Pacijenti.Find(l.Id);
            novi.FirstName = l.FirstName;
            novi.LastName = l.LastName;
            novi.GodinaRodjenja = l.GodinaRodjenja;
            novi.PhoneNumber = l.PhoneNumber;
            db.SaveChanges();
            return Redirect("Pacijenti");
        }

        public IActionResult SelectPacijent(string PacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent l = db.Pacijenti.Find(PacijentId);
            return View("PacijentiOdabir", l);
        }
    }
}
