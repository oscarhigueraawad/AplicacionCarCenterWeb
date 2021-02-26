using System;
using System.Collections.Generic;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class FactDetalleServicio
    {
        public string Sucursal { get; set; }
        public string FacturaNo { get; set; }
        public long IdServicio { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
