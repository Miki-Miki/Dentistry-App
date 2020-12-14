using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class Pacijent : ApplicationUser
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int BrojKartona { get; set; }
    }
}
