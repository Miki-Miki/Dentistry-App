using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class ApplicationUser : IdentityUser
    {   
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime GodinaRodjenja { get; set; }

        public int SpolId { get; set; }
        public Spol Spol { get; set; }

        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public bool ? isPacijent { get; set; }
        public bool ? isAsistent { get; set; }
        public bool ? isStomatolog { get; set; }

    }
}

