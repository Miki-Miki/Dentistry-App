using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.Models
{
    public class DentalnoPomagaloNaSesiji
    {
        public int Id { get; set; }

        public int SesijaId { get; set; }
        public Sesija Sesija { get; set; }

        public int DentalnoPomgaloId { get; set; }
        public DentalnaPomagala DentalnoPomgalo { get; set; }

        public DateTime DatumIzdavanja { get; set; }
    }
}
