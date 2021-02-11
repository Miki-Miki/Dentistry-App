using B.U.Z.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class ObavijestiVM
    {
        public List<Obavijesti> Procitane { get; set; }
        public List<Obavijesti> NeProcitane { get; set; }
    }
}
