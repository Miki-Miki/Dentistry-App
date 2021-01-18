using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class LijekNaSesiji
    {
        public int Id { get; set; }

        public int SesijaId { get; set; }
        public Sesija Sesija { get; set; }

        public int LijekId { get; set; }
        public Lijekovi Lijek { get; set; }
    }
}
