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

        public static AutoCompleteStringCollection Autocompletar_Textbox(ComboBox cbo)
        {
            var opcionesColumnas = new Dictionary<string, string>
            {
                { "Nro Documento", "Documento" },
                { "Nombre de Usuario", "NombreUsuario" },
                { "Nombre", "Nombre" },
                { "Apellido", "Apellido" },
                { "Correo", "Correo" },
                { "Rol", "Descripcion" },
                { "Estado", "Estado" }
            };

            string opcionSeleccionada = cbo.Text;

            // Obtener el nombre de la columna correspondiente
            if (!opcionesColumnas.TryGetValue(opcionSeleccionada, out string nombreColumna))
            {
                throw new ArgumentException("Opción no válida seleccionada en el ComboBox");
            }           

            DataTable dt = new DataTable();

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT u.Documento, u.NombreUsuario, u.Nombre, u.Apellido," +
                " u.Correo, u.Estado, r.Descripcion " +
                "FROM Usuario u INNER JOIN Rol r ON r.IdRol = u.IdRol", Conexion.cadena);

            //Almacena resultado de la consulta en el DataTable
            adaptador.Fill(dt);

            
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
                lista.Add("No activo");
            }


            return lista;
        }

    }
}
