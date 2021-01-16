using B.U.Z.Data;
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
        public IActionResult Sesija()
        {
            return View();
        }
      
        public IActionResult NovaDijagnoza()
        {
            ApplicationDbContext db = new ApplicationDbContext();


            SesijaVM sesijaVM = new SesijaVM
            {
                Dijagnoze = db.Dijagnoze.OrderBy(a => a.Id).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList()
            };

            return View("DijagnozaOdabir", sesijaVM); 
        }
        public IActionResult NovaTerapija()
        {
            return View("TerapijaOdabir");
        }
        public IActionResult NoviLijek()
        {
            return View("LijekOdabir");
        }
        public IActionResult NoviCTSnimak()
        {
            return View("CTSnimakOdabir");
        }
    }
}
