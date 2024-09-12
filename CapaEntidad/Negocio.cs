using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Negocio
    {
        public int IdNegocio { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Direccion {  get; set; }
        public string Telefono {  get; set; }
        public string FechaInicioActividades { get; set; }

        //Propiedades para las parte del CUIT
        public string CuitParte1 { get; set; }
        public string CuitParte2 {  get; set; }
        public string CuitParte3 {  get; set; }


        //Propiedades para las partes de la dirección
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string Partido { get; set; }
        public string Provincia { get; set; }

    }
}
