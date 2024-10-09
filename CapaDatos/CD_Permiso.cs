using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT r.IdRol ,p.NombreSeccion FROM Rol r");
                    query.AppendLine("INNER JOIN Permiso p ON r.IdRol = p.IdRol");
                    query.AppendLine("INNER JOIN Usuario u ON u.IdRol = r.IdRol");
                    query.AppendLine("WHERE u.IdUsuario = @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreSeccion = dr["NombreSeccion"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Permiso>();
            }

            return lista;
        }



    }
}
