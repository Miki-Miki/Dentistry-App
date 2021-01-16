using B.U.Z.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class TerminiVM
    {
        public double basePrice { get; set; }
        public DateTime TerminStart { get; set; }
        public DateTime TerminEnd { get; set; }

        public Pacijent pacijent { get; set; }
        public Usluga usluga { get; set; }

    }
}
