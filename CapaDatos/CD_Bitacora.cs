using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Bitacora
    {

        public List<Bitacora> Listar()
        {
            List<Bitacora> lista = new List<Bitacora>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdEvento, FechaHora, UsuarioLogeado, Accion, Tabla, RegistroAnterior, RegistroNuevo");
                    query.AppendLine("FROM Bitacora;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Bitacora()
                            {
                                IdEvento = Convert.ToInt32(dr["IdEvento"]),
                                FechaHora = dr["FechaHora"].ToString(),
                                UsuarioLogeado = dr["UsuarioLogeado"].ToString(),
                                Accion = dr["Accion"].ToString(),
                                Tabla = dr["Tabla"].ToString(),
                                RegistroAnterior = dr["RegistroAnterior"].ToString(),
                                RegistroNuevo = dr["RegistroNuevo"].ToString()
                            });                             
                        }
                    }

                }
                catch (Exception)
                {                    
                    lista = new List<Bitacora>();
                }

                return lista;
            }

        }


        public List<Bitacora> AccionesBitacora(string fechainicio, string fechafin)
        {
            List<Bitacora> lista = new List<Bitacora>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                StringBuilder query = new StringBuilder();
                SqlCommand cmd = new SqlCommand("PA_AccionesBitacora", conexion);
                cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                cmd.Parameters.AddWithValue("fechafin", fechafin);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Bitacora()
                        {
                            IdEvento = Convert.ToInt32(dr["IdEvento"].ToString()),
                            FechaHora = dr["FechaHora"].ToString(),
                            UsuarioLogeado = dr["UsuarioLogeado"].ToString(),
                            Accion = dr["Accion"].ToString(),
                            Tabla = dr["Tabla"].ToString(),
                            RegistroAnterior = dr["RegistroAnterior"].ToString(),
                            RegistroNuevo = dr["RegistroNuevo"].ToString()
                        });
                    }
                }

            }

            return lista;
        }



    }
}
