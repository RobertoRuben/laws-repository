using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Config;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public class RolRepository : IRepository<Rol> 
    {
        public int Insert(Rol entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Rol_Registrar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@NombreRol", entity.RolName);
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

        public bool Update(Rol entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Rol_Modificar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodRol", entity.CodRol);
                cmd.Parameters.AddWithValue("@NombreRol", entity.RolName);
                cmd.Parameters.AddWithValue("@CodUsuario", codUsuario);

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
        
        public bool Delete(int id, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Rol_Eliminar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@CodRol", id);
                cmd.Parameters.AddWithValue("@CodUsuario", codUsuario);

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

        public List<Rol> GetAll()
        {
            var roles = new List<Rol>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Rol_Listar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rol = new Rol
                            {
                                CodRol = reader.GetInt32(reader.GetOrdinal("CodRol")),
                                RolName = reader.GetString(reader.GetOrdinal("NombreRol"))
                            };

                            roles.Add(rol);
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
            return roles;
        }

        public IEnumerable<Rol> FindBy(string pattern)
        {
            var roles = new List<Rol>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Rol_Buscar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Palabra", pattern ?? (object)DBNull.Value);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rol = new Rol
                            {
                                CodRol = reader.GetInt32(reader.GetOrdinal("CodRol")),
                                RolName = reader.GetString(reader.GetOrdinal("Nombre del Rol"))
                            };

                            roles.Add(rol);
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

            return roles;
        }

        public bool Exists(IComparable searchValue)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Rol_Existe", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Valor", searchValue.ToString());

                SqlParameter rptaParam = new SqlParameter("@Rpta", SqlDbType.Bit);
                rptaParam.Direction = ParameterDirection.Output;
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
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        
        public Rol GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
