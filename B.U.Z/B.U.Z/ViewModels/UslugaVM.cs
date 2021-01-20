using B.U.Z.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class UslugaVM
    {
        public int UslugaId { get; set; }
        public List<SelectListItem> Usluge { get; set; }

        public double OsnovnaCijena { get; set; }
    }
}
