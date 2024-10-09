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
    public class CD_Cliente
    {

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCliente, c.Documento, c.CUIT, c.NombreCompleto, c.Direccion, c.Telefono, c.Correo, cf.IdCondicionFiscal, cf.Descripcion, c.FechaRegistro");
                    query.AppendLine("FROM Cliente c INNER JOIN CondicionFiscal cf ON c.IdCondicionFiscal = cf.IdCondicionFiscal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Documento = dr["Documento"].ToString(),
                                CUIT = dr["CUIT"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                oCondicionFiscal = new CondicionFiscal() { IdCondicionFiscal = Convert.ToInt32(dr["IdCondicionFiscal"]), Descripcion = dr["Descripcion"].ToString() },
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    
                    lista = new List<Cliente>();
                }
            }

            
            return lista;
        }


        public int Registrar(Cliente obj, out string mensaje)
        {
            int idgenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("PA_RegistrarCliente", conexion);

                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("UsuarioLogeado", Usuario.UsuarioLogeado.NombreUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("CUIT", obj.CUIT);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Direccion", obj.Provincia + " - " + obj.Partido + " - " + obj.Localidad + " - " + obj.Calle);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("IdCondicionFiscal", obj.oCondicionFiscal.IdCondicionFiscal);
                    //Parametro de Salida
                    cmd.Parameters.Add("IdClienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                    idgenerado = Convert.ToInt32(cmd.Parameters["IdClienteResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idgenerado = 0;
                mensaje = ex.Message;
            }

            return idgenerado;
        }

        public bool Editar(Cliente obj, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("PA_EditarCliente", conexion);
                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("UsuarioLogeado", Usuario.UsuarioLogeado.NombreUsuario);
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("CUIT", obj.CUIT);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Direccion", obj.Provincia + " - " + obj.Partido + " - " + obj.Localidad + " - " + obj.Calle);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("IdCondicionFiscal", obj.oCondicionFiscal.IdCondicionFiscal);
                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }

            return resultado;
        }



    }
}
