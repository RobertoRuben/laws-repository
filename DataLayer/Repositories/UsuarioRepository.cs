using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Config;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UserDTO Login (string nombreUsuario, string contraseña)
        {
            UserDTO userDto = null;
            using (SqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Login", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userDto = new UserDTO
                            {
                                CodUsuario = reader.GetInt32(reader.GetOrdinal("CodUsuario")),
                                NombreUsuario = reader.GetString(reader.GetOrdinal("Usuario")),
                                NombreTrabajador = reader.GetString(reader.GetOrdinal("Nombre")),
                                NombreRol = reader.GetString(reader.GetOrdinal("Rol")),
                                Estado = reader.GetString(reader.GetOrdinal("Estado"))
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return userDto;
        }

        public bool UpdateCredentials(int id, Usuario usuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_ActualizarCredenciales", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodUsuario", id);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

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
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
        public int Insert(Usuario usuario, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Registrar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodTrabajador", usuario.CodTrabajador);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                cmd.Parameters.AddWithValue("@CodRol", usuario.CodRol);
                cmd.Parameters.AddWithValue("@CodUsuario", codUsuario);
                
                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Int);
                rptaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(rptaParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return (int)rptaParam.Value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
        public bool Update(Usuario usuario, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodUsuario", usuario.CodUsuario);
                cmd.Parameters.AddWithValue("@CodRol", usuario.CodRol);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                
                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Int);
                rptaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(rptaParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return (int)rptaParam.Value == 1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
        public bool Disable(int id, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Inhabilitar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodUsuario", id);
                cmd.Parameters.AddWithValue("@CodUsuarioSesion", codUsuario);
                
                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Int);
                rptaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(rptaParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return (int)rptaParam.Value == 1;
                }
                catch (SqlException ex)
                {
                    throw new Exception("SQL Error al intentar deshabilitar un usuario: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al intentar deshabilitar un usuario: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        public List<UserDTO> GetAll()
        {
            var users = new List<UserDTO>();

            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Listar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuarioDto = new UserDTO
                            {
                                CodUsuario = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                NombreTrabajador = reader.GetString(reader.GetOrdinal("Trabajador")),
                                NombreUsuario = reader.GetString(reader.GetOrdinal("Usuario")),
                                NombreRol = reader.GetString(reader.GetOrdinal("Rol")),
                                Estado = reader.GetString(reader.GetOrdinal("Estado"))
                            };
                            users.Add(usuarioDto);
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }

                return users;
            }
        }
        public IEnumerable<UserDTO> FindBy(string pattern)
        {
            var users = new List<UserDTO>();

            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Buscar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@palabra", pattern);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuarioDto = new UserDTO
                            {
                                CodUsuario = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                NombreTrabajador = reader.GetString(reader.GetOrdinal("Trabajador")),
                                NombreUsuario = reader.GetString(reader.GetOrdinal("Usuario")),
                                NombreRol = reader.GetString(reader.GetOrdinal("Rol")),
                                Estado = reader.GetString(reader.GetOrdinal("Estado"))
                            };
                            users.Add(usuarioDto);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }

            return users;
        }
        
        public bool Exists(IComparable searchValue)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Existe", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Valor", searchValue.ToString());

                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(rptaParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return (bool)rptaParam.Value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        

    }
}