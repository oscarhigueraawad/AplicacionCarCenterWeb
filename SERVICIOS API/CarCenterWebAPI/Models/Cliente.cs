using System;
using System.Collections.Generic;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class Cliente
    {
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NoCelular { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
