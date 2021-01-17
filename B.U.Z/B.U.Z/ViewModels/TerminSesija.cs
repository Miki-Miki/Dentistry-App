using B.U.Z.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class TerminSesija
    {
        public int terminId { get; set; }
        public double basePrice { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public Pacijent pacijent { get; set; }
        public Usluga usluga { get; set; }
    }
}
