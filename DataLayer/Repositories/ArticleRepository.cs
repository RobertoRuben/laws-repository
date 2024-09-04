using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Config;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public int Insert(Article article, int userId)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Registrar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodNormatividad", article.CodLaw);
                cmd.Parameters.AddWithValue("@NumArticulo", article.ArticleNumber);
                cmd.Parameters.AddWithValue("@Denominacion", article.Denomination);
                cmd.Parameters.AddWithValue("@Descripcion", article.Description);
                cmd.Parameters.AddWithValue("@Pagina", article.PageNumber);
                cmd.Parameters.AddWithValue("@Estado", article.State);
                cmd.Parameters.AddWithValue("@CodUsuario", userId);

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

        public bool Update(Article article, int userCod)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Actualizar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodArticulo", article.CodArticle);
                cmd.Parameters.AddWithValue("@CodNormatividad", article.CodLaw);
                cmd.Parameters.AddWithValue("@NumArticulo", article.ArticleNumber);
                cmd.Parameters.AddWithValue("@Denominacion", article.Denomination);
                cmd.Parameters.AddWithValue("@Descripcion", article.Description);
                cmd.Parameters.AddWithValue("@Pagina", article.PageNumber);
                cmd.Parameters.AddWithValue("@Estado", article.State);
                cmd.Parameters.AddWithValue("@CodUsuario", userCod);

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
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public bool Delete(int id, int userId)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Eliminar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodArticulo", id);
                cmd.Parameters.AddWithValue("@CodUsuario", userId);

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
                    throw new Exception("Error al eliminar el artículo: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public List<Article> GetAll(int LawCode, int pageSize, int pageNumber)
        {
            List<Article> articles = new List<Article>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Listar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodNorma", LawCode);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);
                cmd.Parameters.AddWithValue("@PageNumber", pageNumber);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var article = new Article
                            {
                                CodArticle = reader.GetInt32(reader.GetOrdinal("CodArticulo")),
                                CodLaw = reader.GetInt32(reader.GetOrdinal("CodNormatividad")),
                                ArticleNumber = reader.GetInt32(reader.GetOrdinal("N° Articulo")),
                                Denomination = reader.GetString(reader.GetOrdinal("Denominacion")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                PageNumber = reader.GetInt32(reader.GetOrdinal("Pagina")),
                                State = reader.GetString(reader.GetOrdinal("Estado"))
                            };
                            articles.Add(article);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al recuperar los artículos: " + ex.Message, ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            return articles;
        }

        public Article GetById(int id)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulos_ObtenerPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodArticulo", id);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Article
                            {
                                CodArticle = reader.GetInt32(reader.GetOrdinal("CodArticulo")),
                                CodLaw = reader.GetInt32(reader.GetOrdinal("CodNormatividad")),
                                ArticleNumber = reader.GetInt32(reader.GetOrdinal("N° Articulo")),
                                Denomination = reader.GetString(reader.GetOrdinal("Denominacion")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                PageNumber = reader.GetInt32(reader.GetOrdinal("Pagina")),
                                State = reader.GetString(reader.GetOrdinal("Estado"))
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el artículo por ID: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
        
        public IEnumerable<Article> FindBy(int lawCode, string pattern)
        {
            var articles = new List<Article>();

            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Buscar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodNormatividad", lawCode);
                cmd.Parameters.AddWithValue("@Palabra", pattern);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            articles.Add(new Article
                            {
                                CodLaw = reader.GetInt32(reader.GetOrdinal("CodNormatividad")),
                                CodArticle = reader.GetInt32(reader.GetOrdinal("CodArticulo")),
                                ArticleNumber = reader.GetInt32(reader.GetOrdinal("N° Articulo")),
                                Denomination = reader.GetString(reader.GetOrdinal("Denominacion")),
                                Description = reader.GetString(reader.GetOrdinal("Descripcion")),
                                PageNumber = reader.GetInt32(reader.GetOrdinal("Pagina")),
                                State = reader.GetString(reader.GetOrdinal("Estado"))
                            });
                        }
                    }
                    return articles;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar artículos: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
        
        public bool Exists(int lawCode, int articleNumber)
        {
            using (var conn = Conexion.getInstancia().CreateConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Articulo_ExisteEnNorma", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodNormatividad", lawCode);
                cmd.Parameters.AddWithValue("@NumArticulo", articleNumber);

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
                    throw new Exception("Error al verificar la existencia del artículo: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }


    }
}