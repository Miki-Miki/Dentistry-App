using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Sesija
    {
        public int Id { get; set; }

        public int? CTNalazId { get; set; }
        public CTNalaz CTNalaz { get; set; }

        public int? TerminId { get; set; }
        public Termini Termin { get; set; }

        public string StomatologId { get; set; }
        public Stomatolog Stomatolog { get; set; }

    }
}
