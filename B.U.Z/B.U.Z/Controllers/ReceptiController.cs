﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace B.U.Z.Controllers
{
    public class ReceptiController : Controller
    {
        public IActionResult Recepti()
        {
            return View();
        }
    }
}
