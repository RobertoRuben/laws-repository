using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntitiesLayer.Entities;
using DataLayer.Config;
using EntitiesLayer.DTOs;


namespace DataLayer.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public int Insert(Employee entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Registrar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", entity.Dni);
                cmd.Parameters.AddWithValue("@Nombre", entity.EmployeeName);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", entity.PaternalSurname);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", entity.MaternalSurname);
                cmd.Parameters.AddWithValue("@Sexo", entity.Gender);

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

        public bool Update(Employee entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CoddTrabajador", entity.CodEmployee);
                cmd.Parameters.AddWithValue("@Dni", entity.Dni);
                cmd.Parameters.AddWithValue("@Nombre", entity.EmployeeName);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", entity.PaternalSurname);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", entity.MaternalSurname);
                cmd.Parameters.AddWithValue("@Sexo", entity.Gender);

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

        public List<Employee> GetAll(int pageSize, int pageNumber)
        {
            var trabajadores = new List<Employee>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_Listar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.AddWithValue("@PageSize", pageSize);
                cmd.Parameters.AddWithValue("@PageNumber", pageNumber);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var trabajador = new Employee
                            {
                                CodEmployee = reader.GetInt32(reader.GetOrdinal("CodTrabajador")),
                                Dni = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("Dni"))),
                                EmployeeName = reader.GetString(reader.GetOrdinal("Nombre")),
                                PaternalSurname = reader.GetString(reader.GetOrdinal("ApellidoPaterno")),
                                MaternalSurname = reader.GetString(reader.GetOrdinal("ApellidoMaterno")),
                                Gender = reader.GetString(reader.GetOrdinal("Sexo"))[0] 
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

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public IEnumerable<Employee> FindBy(string pattern)
        {
            var trabajadores = new List<Employee>();

            using (var conn = Conexion.getInstancia().CreateConnection())
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
                            var trabajador = new Employee
                            {
                                CodEmployee = reader.GetInt32(reader.GetOrdinal("CodTrabajador")),
                                Dni = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("Dni"))),
                                EmployeeName = reader.GetString(reader.GetOrdinal("Nombre")),
                                PaternalSurname = reader.GetString(reader.GetOrdinal("ApellidoPaterno")),
                                MaternalSurname = reader.GetString(reader.GetOrdinal("ApellidoMaterno")),
                                Gender = reader.GetString(reader.GetOrdinal("Sexo"))[0] 
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
            using (var conn = Conexion.getInstancia().CreateConnection())
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

        public List<EmployeeDTO> GetNames()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_Trabajador_ObtenerNombreCompleto", conn)
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
                            employees.Add(new EmployeeDTO
                            {
                                CodEmployee = reader.GetInt32(reader.GetOrdinal("CodTrabajador")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName"))
                            });
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

            return employees;
        }
    }
}