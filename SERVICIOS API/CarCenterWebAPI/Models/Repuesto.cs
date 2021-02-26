using System;
using System.Collections.Generic;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class Repuesto
    {
        public long IdRepuesto { get; set; }
        public string DescripcionRepuesto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
