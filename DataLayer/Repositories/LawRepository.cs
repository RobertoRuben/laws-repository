using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;
using DataLayer.Config;

namespace DataLayer.Repositories
{
    public class LawRepository : ILawRepository
    {
        public int Insert(Law law, int codUser)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_Registrar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CodUsuario", codUser);
                cmd.Parameters.AddWithValue("@CodTipoNorma", law.CodCategory);
                cmd.Parameters.AddWithValue("@NumeroNorma", law.LawNumber);
                cmd.Parameters.AddWithValue("@NombreNorma", law.LawName);
                cmd.Parameters.AddWithValue("@Resumen", law.LawSummary);
                cmd.Parameters.AddWithValue("@FechaPublicacion", law.PublicationDate);
                cmd.Parameters.AddWithValue("@CantidadDePaginas", law.PageNumber);
                cmd.Parameters.AddWithValue("@MedioPublicacion", law.PublicationMedium);
                cmd.Parameters.AddWithValue("@LinkDocumentos", law.PublicationLink);
                cmd.Parameters.AddWithValue("@PathArchivo", law.PathArchive);
                cmd.Parameters.AddWithValue("@Estado", law.State);

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

        public bool Update(Law law, int codUser)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CodNormatividad", law.CodLaw);
                cmd.Parameters.AddWithValue("@CodTipoNorma", law.CodCategory);
                cmd.Parameters.AddWithValue("@NumeroNorma", law.LawNumber);
                cmd.Parameters.AddWithValue("@NombreNorma", law.LawName);
                cmd.Parameters.AddWithValue("@Resumen", law.LawSummary);
                cmd.Parameters.AddWithValue("@FechaPublicacion", law.PublicationDate);
                cmd.Parameters.AddWithValue("@CantidadPaginas", law.PageNumber);
                cmd.Parameters.AddWithValue("@MedioPublicacion", law.PublicationMedium);
                cmd.Parameters.AddWithValue("@LinkDocumento", law.PublicationLink);
                cmd.Parameters.AddWithValue("@Estado", law.State);
                cmd.Parameters.AddWithValue("@PathArchivo", law.PathArchive);
                cmd.Parameters.AddWithValue("@CodUsuario", codUser);

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
                    throw new Exception("Error al actualizar la norma: " + ex.Message, ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        public bool Delete(int id, int codUser)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_Eliminar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CodNormatividad", id);
                cmd.Parameters.AddWithValue("@CodUsuario", codUser);

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

        public Law GetById(int id)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_ObtenerPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodNormatividad", id);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var law = new Law
                            {
                                CodLaw = reader.GetInt32(reader.GetOrdinal("CodNormatividad")),
                                CodUser = reader.GetInt32(reader.GetOrdinal("CodUsuario")),
                                CodCategory = reader.GetInt32(reader.GetOrdinal("CodTipoNorma")),
                                LawNumber = reader.GetString(reader.GetOrdinal("NumeroNorma")),
                                LawName = reader.GetString(reader.GetOrdinal("NombreNorma")),
                                LawSummary = reader.GetString(reader.GetOrdinal("Resumen")),
                                PublicationDate = reader.GetDateTime(reader.GetOrdinal("FechaPublicacion"))
                                    .ToString("dd/MM/yyyy"),
                                PageNumber = reader.GetInt32(reader.GetOrdinal("CantidadPaginas")),
                                PublicationMedium = reader.GetString(reader.GetOrdinal("MedioPublicacion")),
                                PublicationLink = reader.GetString(reader.GetOrdinal("LinkDocumento")),
                                State = reader.GetInt32(reader.GetOrdinal("Estado")) == 1 ? "Vigente" : "Derogada",
                                PathArchive = reader.IsDBNull(reader.GetOrdinal("PathArchivo"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("PathArchivo"))
                            };
                            return law;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return null; // Retorna null si no se encuentra la ley
        }


        public List<LawDTO> GetAll(int pageSize, int pageNumber)
        {
            var laws = new List<LawDTO>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_Listar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PageSize", pageSize);
                cmd.Parameters.AddWithValue("@PageNumber", pageNumber);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var lawDto = new LawDTO
                            {
                                CodLaw = reader.GetInt32(reader.GetOrdinal("Cod Norma")),
                                LawNumber = reader.GetString(reader.GetOrdinal("N° Norma")),
                                LawName = reader.GetString(reader.GetOrdinal("Nombre")),
                                LawCategory = reader.GetString(reader.GetOrdinal("Tipo")),
                                LawSummary = reader.GetString(reader.GetOrdinal("Resumen")),
                                PublicationDate = reader.GetDateTime(reader.GetOrdinal("F. Publicacion")),
                                PageNumber = reader.GetInt32(reader.GetOrdinal("N° Paginas")),
                                PublicationMedium = reader.GetString(reader.GetOrdinal("Medio Publicacion")),
                                PublicationLink = reader.IsDBNull(reader.GetOrdinal("Link"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Link")),
                                LawState = reader.GetString(reader.GetOrdinal("Estado")),
                                PathDocument = reader.IsDBNull(reader.GetOrdinal("Path"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Path"))
                            };
                            laws.Add(lawDto);
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

            return laws;
        }

        public IEnumerable<LawDTO> FindBy(string pattern)
        {
            var laws = new List<LawDTO>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_Buscar", conn)
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
                            var lawDto = new LawDTO
                            {
                                CodLaw = reader.GetInt32(reader.GetOrdinal("Cod Norma")),
                                LawNumber = reader.GetString(reader.GetOrdinal("N° Norma")),
                                LawName = reader.GetString(reader.GetOrdinal("Nombre")),
                                LawCategory = reader.GetString(reader.GetOrdinal("Tipo")),
                                LawSummary = reader.GetString(reader.GetOrdinal("Resumen")),
                                PublicationDate = reader.GetDateTime(reader.GetOrdinal("F. Publicacion")),
                                PageNumber = reader.GetInt32(reader.GetOrdinal("N° Paginas")),
                                PublicationMedium = reader.GetString(reader.GetOrdinal("Medio Publicacion")),
                                PublicationLink = reader.GetString(reader.GetOrdinal("Link")),
                                LawState = reader.GetString(reader.GetOrdinal("Estado")),
                                PathDocument = reader.GetString(reader.GetOrdinal("Path"))
                            };
                            laws.Add(lawDto);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving law data by pattern: " + ex.Message, ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }

            return laws;
        }

        public bool Exists(IComparable searchValue)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Normas_Existe", conn)
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