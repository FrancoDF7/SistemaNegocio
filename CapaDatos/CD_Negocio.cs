using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CD_Negocio
    {
        //Obtiene datos de el negocio
        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "SELECT IdNegocio, Nombre, CUIT, Direccion, Telefono, FechaInicioActividades FROM Negocio WHERE IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                CUIT = dr["CUIT"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                FechaInicioActividades = dr["FechaInicioActividades"].ToString(),
                            };

                            //Separar el CUIT
                            //StringSplitOptions.RemoveEmptyEntries: Remueve entradas vacias en el caso de que
                            //haya dos separadores - consecutivos, por ejemplo Brasil 2200 - - Avellaneda - Buenos Aires.
                            string[] partesCUIT = obj.CUIT.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                            if (partesCUIT.Length >= 3)
                            {
                                obj.CuitParte1 = partesCUIT[0];
                                obj.CuitParte2 = partesCUIT[1];
                                obj.CuitParte3 = partesCUIT[2];
                            }

                            //Separar la direccion
                            string[] partesDireccion = obj.Direccion.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                            if (partesDireccion.Length >= 4)
                            {
                                obj.Calle = partesDireccion[0].Trim();
                                obj.Localidad = partesDireccion[1].Trim();
                                obj.Partido = partesDireccion[2].Trim();
                                obj.Provincia = partesDireccion[3].Trim();
                            }

                        }
                    }

                }
            }
            catch
            {
                obj = new Negocio();
            }

            return obj;
        }


        //Guarda datos de el negocio
        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();                    

                    SqlCommand cmd = new SqlCommand("PA_GuardarDatosNegocio", conexion);
                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("UsuarioLogeado", Usuario.UsuarioLogeado.NombreUsuario);
                    cmd.Parameters.AddWithValue("Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("CUIT", objeto.CUIT);
                    cmd.Parameters.AddWithValue("Direccion", objeto.Calle + "-" + objeto.Localidad + "-" +
                        objeto.Partido + "-" + objeto.Provincia);
                    cmd.Parameters.AddWithValue("Telefono", objeto.Telefono);
                    cmd.Parameters.AddWithValue("FechaInicioActividades", objeto.FechaInicioActividades);
                    //Parametros de salida
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        //public bool GuardarDatos(Negocio objeto, out string mensaje)
        //{
        //    mensaje = string.Empty;
        //    bool respuesta = true;

        //    try
        //    {
        //        using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
        //        {
        //            conexion.Open();

        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("UPDATE Negocio SET Nombre = @nombre,");
        //            query.AppendLine("CUIT = @cuit,");
        //            query.AppendLine("Direccion = @direccion,");
        //            query.AppendLine("Telefono = @telefono,");
        //            query.AppendLine("FechaInicioActividades = @fechainicioactividades");
        //            query.AppendLine("WHERE IdNegocio = 1");

        //            SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
        //            cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
        //            cmd.Parameters.AddWithValue("@cuit", objeto.CUIT);
        //            cmd.Parameters.AddWithValue("@direccion", objeto.Calle + "-" + objeto.Localidad + "-" +
        //                objeto.Partido + "-" + objeto.Provincia);
        //            cmd.Parameters.AddWithValue("@telefono", objeto.Telefono);
        //            cmd.Parameters.AddWithValue("@fechainicioactividades", objeto.FechaInicioActividades);

        //            cmd.CommandType = CommandType.Text;

        //            if (cmd.ExecuteNonQuery() < 1)
        //            {
        //                mensaje = "No se pudo guardar los datos";
        //                respuesta = false;
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        mensaje = ex.Message;
        //        respuesta = false;
        //    }

        //    return respuesta;
        //}



        //Metodo que devuelve un Array de bytes
        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT Logo FROM Negocio WHERE IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                LogoBytes = new byte[0];
            }

            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("PA_ActualizarLogo", conexion);

                    cmd.Parameters.AddWithValue("UsuarioLogeado", Usuario.UsuarioLogeado.NombreUsuario);
                    cmd.Parameters.AddWithValue("imagen", image);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Si el numero de filas afectadas es menor a 1 significa que no actualizo los datos del negocio
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

    }

}
