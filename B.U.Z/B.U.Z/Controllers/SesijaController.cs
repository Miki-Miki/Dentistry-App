using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Controllers
{
    public class SesijaController : Controller
    {
        public IActionResult Sesija() //treba se poslati termin za koji se radi sesija
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = new Sesija();
            db.Sesija.Add(sesija);
            db.SaveChanges();

            return View(sesija);
        }
      
        public IActionResult NovaDijagnoza(int sesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(sesijaId);
            List<SelectListItem> dijagnoze = new List<SelectListItem>();

            SesijaVM sesijaVM = new SesijaVM
            {
                SesijaId = sesija.Id,
                Dijagnoze = db.Dijagnoze.OrderBy(a => a.Id).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList()
            };

            return View("DijagnozaOdabir", sesijaVM); 
        }

      

        public IActionResult NovaTerapija(int sesijaId)
        {
            return View("TerapijaOdabir");
        }
        public IActionResult NoviLijek(int sesijaId)
        {
            return View("LijekOdabir");
        }
        public IActionResult NoviCTSnimak(int sesijaId)
        {
            return View("CTSnimakOdabir");
        }
    }
}
