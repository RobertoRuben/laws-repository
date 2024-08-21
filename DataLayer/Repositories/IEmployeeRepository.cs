using System;
using System.Collections.Generic;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IEmployeeRepository
    {
        int Insert(Trabajador trabajador, int codUsuario);
        bool Update(Trabajador trabajador, int codUsuario);
        bool Delete(int id, int codUsuario);
        List<Trabajador> GetAll(int pageSize, int pageNumber);
        IEnumerable<Trabajador> FindBy(string pattern);
        bool Exists(IComparable searchValue);
        List<EmployeeDTO> GetNames();
    }
}