using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class DentalnaPomagala
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string ? PacijentId { get; set; }
        public Pacijent Pacijent { get; set; }
    }
}
