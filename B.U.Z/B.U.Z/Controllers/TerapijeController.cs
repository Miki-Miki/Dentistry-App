using B.U.Z.Data;
using B.U.Z.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Controllers
{
    public class TerapijeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string getOpis(int terapijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Terapije terapija = db.Terapije.Find(terapijaId);
            return terapija.Opis;
        }
    }
}
