using CapaDatos;
using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaSoporte.Utilidades
{
    public static class AutoCompletado
    {

        //Se encarga de retornar el diccionary y consulta segun el parametro nombreTabla
        //Este metodo es utilizado en el metodo Carga_Autocompletado
        private static Dictionary<string, string> ObtenerOpcionesYConsulta(string nombreTabla, out string consulta)
        {

            // { "Texto del CombobBox", "Nombre del Campo de Consulta"}

            if (nombreTabla == "Usuario")
            {
                var opcionesUsuario = new Dictionary<string, string>{
                { "Nro Documento", "Documento" },
                { "Nombre de Usuario", "NombreUsuario" },
                { "Nombre", "Nombre" },
                { "Apellido", "Apellido" },
                { "Correo", "Correo" },
                { "Rol", "Descripcion" },
                { "Estado", "Estado" }
            };

                consulta = "SELECT u.Documento, u.NombreUsuario, u.Nombre, u.Apellido, u.Correo, u.Estado, r.Descripcion FROM Usuario u INNER JOIN Rol r ON r.IdRol = u.IdRol";

                return opcionesUsuario;
            }

            if (nombreTabla == "Cliente")
            {
                var opcionCliente = new Dictionary<string, string>
            {
                { "Nro Documento", "Documento" },
                { "CUIT", "CUIT" },
                { "Nombre Completo / Razón Social", "NombreCompleto" },
                { "Dirección", "Direccion" },
                { "Teléfono", "Telefono" },
                { "Correo Electrónico", "Correo" },
                { "Condición Fiscal", "Descripcion" },
            };

                consulta = "SELECT c.Documento, c.CUIT, c.NombreCompleto, c.Direccion, c.Telefono,c.Correo, cf.Descripcion FROM Cliente c INNER JOIN CondicionFiscal cf ON c.IdCondicionFiscal = cf.IdCondicionFiscal";

                return opcionCliente;
            }

            // Retorna un diccionario y una consulta vacíos si no se cumple ninguna condición
            consulta = "";
            return new Dictionary<string, string>();
        }



        public static AutoCompleteStringCollection Carga_Autocompletado(ComboBox cbo, string nombreTabla)
        {
            var opciones = ObtenerOpcionesYConsulta(nombreTabla, out string consulta);

            string opcionSeleccionada = cbo.Text;

            // Obtener el nombre de la columna correspondiente
            if (!opciones.TryGetValue(opcionSeleccionada, out string nombreColumna))
            {
                throw new ArgumentException("Opción no válida seleccionada en el ComboBox");
            }

            DataTable dt = new DataTable();

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            //Se le pasa el parametro llamado "consulta" obtenido a travez del metodo OpcionesColumnas
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, Conexion.cadena);

            adapter.Fill(dt);

            if (nombreColumna != "Estado")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i][nombreColumna].ToString());
                }
            }
            else
            {
                //Le agregue directamente el valor al autocompletado 
                //por que la columna Estado es de tipo bit devuelve 1 y 0.
                lista.Add("Activo");
                lista.Add("No Activo");
            }

            return lista;
        }



    }
}
