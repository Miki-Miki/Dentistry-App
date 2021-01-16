using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class AsistentRegistracijaVM
    {
        public int Asistent_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Titula { get; set; }

        [Required]
        [Display(Name = "Broj telefona")]
        public string BrojTelefona { get; set; }
        public int SpolId { get; set; }
        public int GradId { get; set; }
        public List<SelectListItem> spolovi { get; set; }
        public List<SelectListItem> gradovi { get; set; }

    }
    
}
