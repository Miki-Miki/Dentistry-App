using B.U.Z.Models;
using Microsoft.AspNetCore.Http;
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
        public int TerminId { get; set; }

        public int DijagnozaId { get; set; }
        public List<SelectListItem> Dijagnoze { get; set; }

        public int TerapijaId { get; set; }
        public List<SelectListItem> Terapije { get; set; }

        public int LijekId { get; set; }
        public List<SelectListItem> Lijekovi { get; set; }

        public int CTNalazId { get; set; }
        public CTNalaz CTNalaz { get; set; }

        public IFormFile CTNalazSlika { get; set; }
        public string CTNalazSlikaPutanja { get; set; }
    }
}
