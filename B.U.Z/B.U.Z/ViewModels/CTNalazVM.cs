using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.U.Z.ViewModels
{
    public class CTNalazVM
    {
        public string Nalaz { get; set; }
        public IFormFile CTNalazSlika { get; set; }
    }
}
