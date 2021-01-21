using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class PacijentiKartonVM
    {
        public string Pacijent_Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Grad { get; set; }
        public int BrojKartona { get; set; }
        public List<SelectListItem> Sesije { get; set; }
        public string IzvrsenaUsluga { get; set; }
        public string Dijagnoza { get; set; }
        public string Terapija { get; set; }
        public string Lijek { get; set; }
    }
}
