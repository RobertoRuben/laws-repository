using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntitiesLayer.Entities;
using DataLayer.Config;


namespace DataLayer.Repositories
{
    public class EmployeeRepository : IRepository<Trabajador>
    {
        public int Insert(Trabajador entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Registrar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", entity.Dni);
                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", entity.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", entity.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Sexo", entity.Sexo);

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

        public bool Update(Trabajador entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CodTrabajador", entity.CodTrabajador);
                cmd.Parameters.AddWithValue("@Dni", entity.Dni);
                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", entity.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", entity.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Sexo", entity.Sexo);

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
                    // Asegurar que la conexión se cierra siempre
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        public bool Delete(int id, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Eliminar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CodTrabajador", id);

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

        public List<Trabajador> GetAll()
        {
            var trabajadores = new List<Trabajador>();

            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Listar", conn)
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
                            var trabajador = new Trabajador
                            {
                                CodTrabajador = reader.GetInt32(reader.GetOrdinal("CodTrabajador")),
                                Dni = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("Dni"))),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                ApellidoPaterno = reader.GetString(reader.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = reader.GetString(reader.GetOrdinal("ApellidoMaterno")),
                                Sexo = reader.GetString(reader.GetOrdinal("Sexo"))[0] 
                            };
                            trabajadores.Add(trabajador);
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
            return trabajadores;
        }

        public Trabajador GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public IEnumerable<Trabajador> FindBy(string pattern)
        {
            var trabajadores = new List<Trabajador>();

            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Buscar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@Palabra", pattern); 

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var trabajador = new Trabajador
                            {
                                CodTrabajador = reader.GetInt32(reader.GetOrdinal("CodTrabajador")),
                                Dni = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("Dni"))),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                ApellidoPaterno = reader.GetString(reader.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = reader.GetString(reader.GetOrdinal("ApellidoMaterno")),
                                Sexo = reader.GetString(reader.GetOrdinal("Sexo"))[0] 
                            };
                            trabajadores.Add(trabajador);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar trabajadores: " + ex.Message, ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            
            return trabajadores;
            
        }
        
        public bool Exists(IComparable searchValue)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Existe", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Dni", searchValue); 

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
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
    }
}