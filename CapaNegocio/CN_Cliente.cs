using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSoporte;
using CapaSoporte.Validaciones;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        public CD_Cliente objcd_cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento.Length < 8)
            {
                Mensaje += "El número de documento debe estar completo.\n";
            }

            if (obj.CUIT.Length < 11)
            {
                Mensaje += "El número de CUIT debe estar completo.\n";
            }
            else
            {
                if (ValidacionCUIT.Validar(obj.CUIT) == false)
                {
                    Mensaje += "El CUIT ingresado no es valido.\n";
                }
            }


            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe ingresar el nombre completo o razón social del cliente.\n";
            }
            if (obj.Provincia == "")
            {
                Mensaje += "Debe ingresar la provincia.\n";
            }
            if (obj.Partido == "")
            {
                Mensaje += "Debe ingresar el partido.\n";
            }
            if (obj.Localidad == "")
            {
                Mensaje += "Debe ingresar la localidad.\n";
            }
            if (obj.Calle == "")
            {
                Mensaje += "Debe ingresar la calle\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Debe ingresar el teléfono.\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_cliente.Registrar(obj, out Mensaje);
            }            
        }


        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento.Length < 8)
            {
                Mensaje += "El número de documento debe estar completo.\n";
            }
            if (obj.CUIT.Length < 11)
            {
                Mensaje += "El número de CUIT debe estar completo.\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe ingresar el nombre completo o razón social del cliente.\n";
            }
            if (obj.Provincia == "")
            {
                Mensaje += "Debe ingresar la provincia.\n";
            }
            if (obj.Partido == "")
            {
                Mensaje += "Debe ingresar el partido.\n";
            }
            if (obj.Localidad == "")
            {
                Mensaje += "Debe ingresar la localidad.\n";
            }
            if (obj.Calle == "")
            {
                Mensaje += "Debe ingresar la calle\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Debe ingresar el teléfono.\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_cliente.Editar(obj, out Mensaje);
            }
        }



    }
}
