using System;
using System.Collections.Generic;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IEmployeeRepository
    {
        int Insert(Employee employee, int codUsuario);
        bool Update(Employee employee, int codUsuario);
        bool Delete(int id, int codUsuario);
        List<Employee> GetAll(int pageSize, int pageNumber);
        IEnumerable<Employee> FindBy(string pattern);
        bool Exists(IComparable searchValue);
        List<EmployeeDTO> GetNames();
    }
}