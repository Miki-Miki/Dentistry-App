using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Racun
    {
        public int Id { get; set; }
        public double UkupnaCijena { get; set; }
        public double OsnovnaCijena { get; set; }
        public double stopaPDV { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }

    }
}
