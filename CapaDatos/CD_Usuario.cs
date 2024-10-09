using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Usuario
    {
        //Este metodo devuelve una lista de usuarios.
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            //Le pasa por parametros la cadena de conexion de la clase Conexion
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.IdUsuario, u.Documento, u.NombreUsuario, u.Nombre, u.Apellido, u.Clave, u.Correo, u.Estado, r.IdRol, r.Descripcion, u.IdImagen, u.FechaRegistro");
                    query.AppendLine("FROM Usuario u INNER JOIN Rol r ON r.IdRol = u.IdRol;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();


                    //SqlDataReader se encarga de leer el resultado del SqlCommand
                    //La variable de dr almacena el resultado del metodo ExecuteReader
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //El bucle while(dr.Read()) se ejecuta mientras hay más filas de resultados para leer
                        while (dr.Read())
                        {
                            //Se crea una nueva instancia de la clase Usuario.
                            //Se asignan valores a las propiedades de Usuario utilizando los datos leídos de la fila actual
                            //Después de asignar los valores a las propiedades de Usuario, se agrega la instancia de Usuario a una lista llamada lista
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreUsuario = dr["NombreUsuario"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() },
                                IdImagen = Convert.ToByte(dr["IdImagen"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Si hay un error deja la lista vacia
                    lista = new List<Usuario>();
                }
            }

            return lista;
        }

        public int Registrar(Usuario obj, out string mensaje)
        {
            int idgenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("PA_RegistrarUsuario", conexion);
                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("UsuarioLogeado", Usuario.UsuarioLogeado.NombreUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreUsuario", obj.NombreUsuario);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("IdImagen", obj.IdImagen);
                    //Parametro de Salida
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; //Se debe pasar por parametros el tamaño del tipo de dato de sql, en este caso varchar(500)

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                    idgenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
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


        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;            

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("PA_EditarUsuario", conexion);
                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("UsuarioLogeado", Usuario.UsuarioLogeado.NombreUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreUsuario", obj.NombreUsuario);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("IdImagen", obj.IdImagen);
                    //Parametro de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; //Se debe pasar por parametros el tamaño del tipo de dato de sql, en este caso varchar(500)

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }

            return resultado;
        }


        public void RegistraLogin(string usuarioLogeado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("PA_RegistraLogin", conexion);
                    cmd.Parameters.AddWithValue("UsuarioLogeado", usuarioLogeado);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

            }
        }


    }
}
