using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        //Almacena la propiedades del usuario que se logeo en la apliacion
        public static Usuario UsuarioLogeado { get; set; }

        //Propiedades de Usuario
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public byte IdImagen { get; set; }
        public string FechaRegistro { get; set; }


        //Propiedad adicional
        public string ConfirmarClave { get; set; }


    }
}
