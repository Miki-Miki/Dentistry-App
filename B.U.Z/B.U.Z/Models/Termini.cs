using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Termini
    {
        public int Id { get; set; }
        
        public string PacijentId { get; set; }
        public Pacijent Pacijent { get; set; }

        public string AsistentId { get; set; }
        public Asistent Asistent { get; set; }

        public DateTime TerminStart { get; set; }
        public DateTime TerminEnd { get; set; }

        public double basePrice { get; set; }
    }
}
