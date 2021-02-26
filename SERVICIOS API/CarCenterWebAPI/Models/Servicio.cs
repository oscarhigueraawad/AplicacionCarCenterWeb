using System;
using System.Collections.Generic;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class Servicio
    {
        public long IdServicio { get; set; }
        public string DescripcionServicio { get; set; }
        public decimal ValorManoDeObra { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
    }
}
