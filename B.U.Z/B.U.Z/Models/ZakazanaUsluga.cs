using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class ZakazanaUsluga
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int UslugaId { get; set; }
        public Usluga Usluga{ get; set; }
        public int TerminId { get; set; }
        public Termini Termin { get; set; }
    }
}
