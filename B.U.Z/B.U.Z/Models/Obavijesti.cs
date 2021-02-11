using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Obavijesti
    {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public bool isProcitana { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        
    }
}
