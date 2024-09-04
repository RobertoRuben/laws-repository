using System;
using System.Collections.Generic;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface ILawRepository
    {
        int Insert(Law law, int codUsuario);
        bool Update(Law law, int codUsuario);
        bool Delete(int id, int codUsuario);
        Law GetById(int id);
        List<LawDTO> GetAll(int pageSize, int pageNumber);
        IEnumerable<LawDTO> FindBy(string pattern);
        bool Exists(IComparable searchValue);
    }
}