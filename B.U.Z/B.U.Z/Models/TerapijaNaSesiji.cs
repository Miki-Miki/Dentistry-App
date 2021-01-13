using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class TerapijaNaSesiji
    {
        public int Id { get; set; }

        public int TerapijaId { get; set; }
        public Terapije Terapija { get; set; }

        public int SesijaId { get; set; }
        public Sesija Sesija { get; set; }

        public string Instrukcije { get; set; }
    }
}
