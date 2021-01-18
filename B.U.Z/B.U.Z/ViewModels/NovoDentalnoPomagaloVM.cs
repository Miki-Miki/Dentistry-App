using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class NovoDentalnoPomagaloVM
    {
        public int DentalnoPomagaloId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int BrojDentalnihPomagala { get; set; }
        public string PacijentId { get; set; }
        public List<SelectListItem> pacijenti { get; set; }

    }
}
