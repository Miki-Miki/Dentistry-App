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
        
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public DateTime TerminStart { get; set; }
        public DateTime TerminEnd { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string BrojProtokola { get; set; }
    }
}
