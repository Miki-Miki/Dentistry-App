using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class SesijaVM
    {
        public int SesijaId { get; set; }

        public int DijagnozaId { get; set; }
        public List<SelectListItem> Dijagnoze { get; set; }
    }
}
