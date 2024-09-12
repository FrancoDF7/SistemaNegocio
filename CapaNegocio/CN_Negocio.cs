using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre de el negocio\n";
            }
            if (obj.CUIT.Length != 13)
            {
                Mensaje += "Es necesario el número de CUIT completo\n";
            }
            if (obj.Calle == "")
            {
                Mensaje += "Es necesaria la calle\n";
            }
            if (obj.Localidad == "")
            {
                Mensaje += "Es necesaria la localidad\n";
            }
            if (obj.Partido == "")
            {
                Mensaje += "Es necesario el partido\n";
            }
            if (obj.Provincia == "")
            {
                Mensaje += "Es necesaria la provincia\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_negocio.GuardarDatos(obj, out Mensaje);
            }

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objcd_negocio.ActualizarLogo(imagen, out mensaje);
        }


    }
}
