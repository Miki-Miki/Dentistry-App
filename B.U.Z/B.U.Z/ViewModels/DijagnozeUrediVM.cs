using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class DijagnozeUrediVM
    {
        public int Dijagnoza_Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Preporuka { get; set; }
        public int RedniBroj { get; set; }
    }
}
