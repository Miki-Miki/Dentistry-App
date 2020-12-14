using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public abstract class Korisnik : IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime GodinaRodjenja { get; set; }

        public int SpolId { get; set; }
        public Spol Spol { get; set; }

        public int GradId { get; set; }
        public Grad Grad { get; set; }

    }
}
