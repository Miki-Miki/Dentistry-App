using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class PacijentiDodajVM
    {
        internal ModelStateDictionary modelState;

        public string PacijentId{ get; set; }
        public string Ime{ get; set; }
        public string Prezime{ get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "The password must contain at least one character, one number and one special character.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona{ get; set; }
        public int UkupnoPacijenata{ get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }
        public List<SelectListItem> Gradovi { get; set; }
        public List<SelectListItem> Spolovi { get; set; }
    }
}
