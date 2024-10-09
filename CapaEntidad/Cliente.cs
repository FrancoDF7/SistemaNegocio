using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string CUIT { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public CondicionFiscal oCondicionFiscal { get; set; }
        public string FechaRegistro { get; set; }


        //Propiedades para las partes de la dirección
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string Partido { get; set; }
        public string Provincia { get; set; }

    }
}
