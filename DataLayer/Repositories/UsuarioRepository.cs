using System;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Config;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Login(string nombreUsuario, string contraseña)
        {
            Usuario usuario = null;
            using (SqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Login", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    sqlCon.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                CodUsuario = reader.IsDBNull(reader.GetOrdinal("CodUsuario")) ? 0 : reader.GetInt32(reader.GetOrdinal("CodUsuario")),
                                NombreUsuario = reader.IsDBNull(reader.GetOrdinal("Usuario")) ? null : reader.GetString(reader.GetOrdinal("Usuario")),
                                Estado = reader.IsDBNull(reader.GetOrdinal("Estado")) ? 0 : reader.GetInt32(reader.GetOrdinal("Estado")),
                                Rol = new Rol
                                {
                                    NombreDeRol = reader.IsDBNull(reader.GetOrdinal("Rol")) ? null : reader.GetString(reader.GetOrdinal("Rol")),
                                },
                                Trabajador = new Trabajador
                                {
                                    Nombre = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? null : reader.GetString(reader.GetOrdinal("Nombre"))
                                }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
            return usuario;
        }

        public bool UpdateCredentials(int id, string nombreUsuario, string contraseña)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_ActualizarCredenciales", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodUsuario", id);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Int);
                rptaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(rptaParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int respuesta = (int)rptaParam.Value;
                    return respuesta == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar las credenciales: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}