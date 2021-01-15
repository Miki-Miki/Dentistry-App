using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class PacijentiDodajVM
    {
        public string PacijentId{ get; set; }
        public string Ime{ get; set; }
        public string Prezime{ get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona{ get; set; }
        public int UkupnoPacijenata{ get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }
        public List<SelectListItem> Gradovi { get; set; }
        public List<SelectListItem> Spolovi { get; set; }
    }
}
