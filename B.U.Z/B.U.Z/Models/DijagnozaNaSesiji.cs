using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class DijagnozaNaSesiji
    {
        public int Id { get; set; }
        public int DijagnozaId { get; set; }
        public Dijagnoze Dijagnoza { get; set; }


        public int SesijaId { get; set; }
        public Sesija Sesija { get; set; }

        public string Opis { get; set; }
    }
}
