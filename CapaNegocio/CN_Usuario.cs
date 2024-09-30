using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        //Instancia de la clase CD_Usuario de la CapaDatos
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento.Length < 8)
            {
                Mensaje += "El número de documento debe estar completo.\n";
            }
            if (obj.NombreUsuario.Length < 5)
            {
                Mensaje += "El usuario debe poseer al menos 5 caracteres.\n";
            }
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre.\n";
            }
            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el apellido.\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesaria la contraseña.\n";
            }

            if (obj.ConfirmarClave == "")
            {
                Mensaje += "Es necesaria la confirmación de la contraseña.\n";
            }

            if (obj.Clave != "" && obj.ConfirmarClave != "")
            {
                if (obj.Clave != obj.ConfirmarClave)
                {
                    Mensaje += "El campo Contraseña y Confirmar contraseña deben ser iguales.\n";
                }
            }

            if (Mensaje != string.Empty)
            {
                return 0;                
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento.Length < 8)
            {
                Mensaje += "El número de documento debe estar completo.\n";
            }
            if (obj.NombreUsuario.Length < 5)
            {
                Mensaje += "El usuario debe poseer al menos 5 caracteres.\n";
            }
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre.\n";
            }
            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el apellido.\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesaria la contraseña.\n";
            }

            if (obj.ConfirmarClave == "")
            {
                Mensaje += "Es necesaria la confirmación de la contraseña.\n";
            }

            if (obj.Clave != "" && obj.ConfirmarClave != "")
            {
                if (obj.Clave != obj.ConfirmarClave)
                {
                    Mensaje += "El campo Contraseña y Confirmar contraseña deben ser iguales.\n";
                }
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }

        }

        public void RegistraLogin(string usuarioLogeado)
        {
            objcd_usuario.RegistraLogin(usuarioLogeado);
        }


    }
}
