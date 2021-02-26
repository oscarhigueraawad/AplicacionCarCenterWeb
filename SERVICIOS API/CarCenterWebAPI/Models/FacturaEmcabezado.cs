using System;
using System.Collections.Generic;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class FacturaEmcabezado
    {
        public string Sucursal { get; set; }
        public string FacturaNo { get; set; }
        public string DocumentoCliente { get; set; }
        public string DocumentoMecanico { get; set; }
        public decimal PresupuestoCliente { get; set; }
        public decimal ValorSubTotal { get; set; }
        public decimal ValorTotalDescuento { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorTotalFactura { get; set; }
    }
}
