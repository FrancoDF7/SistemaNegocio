using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Bitacora
    {
        public int IdEvento { get; set; }
        public string FechaHora { get; set; }
        public string UsuarioLogeado { get; set; }
        public string Accion { get; set; }
        public string Tabla { get; set; }
        public string RegistroAnterior { get; set; }
        public string RegistroNuevo { get; set; }
    }
}
