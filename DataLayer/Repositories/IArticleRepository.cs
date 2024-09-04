using System;
using System.Collections.Generic;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IArticleRepository
    {
        int Insert(Article article, int userId);
        bool Update(Article article, int userId);
        bool Delete(int id, int userId);
        List<Article> GetAll(int LawCode, int pagesize, int pageNumber);
        Article GetById(int id);
        IEnumerable<Article> FindBy(int lawCode, string pattern);
        bool Exists(int lawCode, int articleNumber);
    }
}