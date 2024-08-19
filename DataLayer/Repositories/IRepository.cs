using System;
using System.Collections.Generic;

namespace DataLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        int Insert(T entity, int codUsuario);
        bool Update(T entity, int codUsuario);
        bool Delete(int id, int codUsuario);
        List<T> GetAll();
        T GetById(int id);
        IEnumerable<T> FindBy(string pattern);
        bool Exists(IComparable searchValue);
    }
}