using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Controllers
{
    public class NovaUslugaController : Controller
    {
        public IActionResult NovaUsluga()
        {
            return View();
        }
    }
}
