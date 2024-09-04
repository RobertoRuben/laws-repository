using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Config;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserDTO Login (string nombreUsuario, string contraseña)
        {
            UserDTO userDto = null;
            using (SqlConnection conn = Conexion.getInstancia().CreateConnection())
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
                                CodUser = reader.GetInt32(reader.GetOrdinal("CodUsuario")),
                                UserName = reader.GetString(reader.GetOrdinal("Usuario")),
                                State = reader.GetString(reader.GetOrdinal("Estado")),
                                RolName = reader.GetString(reader.GetOrdinal("Rol")),
                                EmployeeName = reader.GetString(reader.GetOrdinal("Nombre")),
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

        public bool UpdateCredentials(int id, User user)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_ActualizarCredenciales", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodUsuario", id);
                cmd.Parameters.AddWithValue("@Contraseña", user.Password);

                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Int);
                rptaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(rptaParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int rpta = (int)rptaParam.Value;
                    return rpta == 1;
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
        public int Insert(User user, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Registrar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodTrabajador", user.CodEmployee);
                cmd.Parameters.AddWithValue("@NombreUsuario", user.UserName);
                cmd.Parameters.AddWithValue("@Contraseña", user.Password);
                cmd.Parameters.AddWithValue("@Estado", user.State);
                cmd.Parameters.AddWithValue("@CodRol", user.CodRol);
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
        public bool Update(User user, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodUsuario", user.CodUser);
                cmd.Parameters.AddWithValue("@CodRol", user.CodRol);
                cmd.Parameters.AddWithValue("@NombreUsuario", user.UserName);
                cmd.Parameters.AddWithValue("@Contraseña", user.Password);
                cmd.Parameters.AddWithValue("@Estado", user.State);
                
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
            using (var conn = Conexion.getInstancia().CreateConnection())
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

            using (var conn = Conexion.getInstancia().CreateConnection())
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
                                CodUser = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                EmployeeName = reader.GetString(reader.GetOrdinal("Trabajador")),
                                UserName = reader.GetString(reader.GetOrdinal("Usuario")),
                                RolName = reader.GetString(reader.GetOrdinal("Rol")),
                                State = reader.GetString(reader.GetOrdinal("Estado"))
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

            using (var conn = Conexion.getInstancia().CreateConnection())
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
                                CodUser = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                EmployeeName = reader.GetString(reader.GetOrdinal("Trabajador")),
                                UserName = reader.GetString(reader.GetOrdinal("Usuario")),
                                RolName = reader.GetString(reader.GetOrdinal("Rol")),
                                State = reader.GetString(reader.GetOrdinal("Estado"))
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
            using (var conn = Conexion.getInstancia().CreateConnection())
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