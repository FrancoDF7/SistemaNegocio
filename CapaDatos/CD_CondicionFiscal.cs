using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class CD_CondicionFiscal
    {

        public List<CondicionFiscal> Listar()
        {
            List<CondicionFiscal> lista = new List<CondicionFiscal>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCondicionFiscal, Descripcion FROM CondicionFiscal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CondicionFiscal()
                            {
                                IdCondicionFiscal = Convert.ToInt32(dr["IdCondicionFiscal"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }

                }
                catch (Exception)
                {
                    lista = new List<CondicionFiscal>();
                }
            }

            return lista;
        }

    }
}
