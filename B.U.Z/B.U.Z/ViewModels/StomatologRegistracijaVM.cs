using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class StomatologRegistracijaVM
    {
        public int Stomatolog_id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage ="The password must contain at least one character, one number and one special character.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }

        [Required]
        [Display(Name = "Titula")]
        public string Titula { get; set; }

        [Required]
        [Display(Name = "Broj telefona")]
        public string BrojTelefona { get; set; }

        [Required]
        [Display(Name = "Specijalizacija")]
        public string Specijalizacija { get; set; }


        public int SpolId { get; set; }
        public int GradId { get; set; }
        public List<SelectListItem> spolovi { get; set; }
        public List<SelectListItem> gradovi { get; set; }

        public ModelStateDictionary  modelState { get; set; }

    }
    
}
