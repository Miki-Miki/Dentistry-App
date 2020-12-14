using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Grad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public int KantonId { get; set; }
        public Kanton Kanton { get; set; }
    }
}
