using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Usluga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Opis { get; set; }
        public int Trajanje{ get; set; }
    }
}
