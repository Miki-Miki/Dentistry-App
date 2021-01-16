using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using Microsoft.AspNetCore.Mvc;

namespace B.U.Z.Controllers
{
    public class ObavijestiController : Controller
    {
        public IActionResult Obavijesti()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Obavijesti> o = db.Obavijesti.ToList();
            return View(o);
        }
    }
}
