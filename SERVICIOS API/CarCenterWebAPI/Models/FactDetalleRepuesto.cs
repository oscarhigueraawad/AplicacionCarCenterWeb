using System;
using System.Collections.Generic;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class FactDetalleRepuesto
    {
        public string Sucursal { get; set; }
        public string FacturaNo { get; set; }
        public long IdRepuesto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
