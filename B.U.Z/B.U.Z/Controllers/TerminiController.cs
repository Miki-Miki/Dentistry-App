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
    public class TerminiController : Controller
    {
        public IActionResult Termini()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Termini> termini = db.Termini.ToList(); 
            return View(termini);
        }

        public IActionResult DodajTermin()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            

            return View();
        }
    }
}
