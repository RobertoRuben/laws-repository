using System;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Config;
using EntitiesLayer.Entities;
using System.Collections.Generic;

namespace DataLayer.Repositories
{
    public class CategoriaRepository : IRepository<CategoriaDeNorma>
    {
        public int Insert(CategoriaDeNorma entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Registrar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoDeNorma", entity.TipoDeNorma);
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

        public bool Update(CategoriaDeNorma entity, int codUsuario)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Actualizar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCategoriaNorma", entity.CodTipoNorma);
                cmd.Parameters.AddWithValue("@TipoDeNorma", entity.TipoDeNorma);
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
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Eliminar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodTipoNorma", id);
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
        public List<CategoriaDeNorma> GetAll()
        {
            var categorias = new List<CategoriaDeNorma>(); 

            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Listar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var categoria = new CategoriaDeNorma
                            {
                                CodTipoNorma = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                TipoDeNorma = reader.GetString(reader.GetOrdinal("Categoria de Norma"))
                            };
                            categorias.Add(categoria);
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
            return categorias;
        }
        public CategoriaDeNorma GetById(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<CategoriaDeNorma> FindBy(string pattern)
        {
            var categorias = new List<CategoriaDeNorma>();

            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Buscar", conn)
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
                            var categoria = new CategoriaDeNorma
                            {
                                CodTipoNorma = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                TipoDeNorma = reader.GetString(reader.GetOrdinal("Categoria de Norma"))
                            };
                            categorias.Add(categoria);
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
            return categorias;
        }
        
        public bool Exists(IComparable searchValue)
        {
            using (var conn = Conexion.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Existe", conn)
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