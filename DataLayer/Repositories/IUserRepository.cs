using System;
using System.Collections.Generic;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IUserRepository
    {
        UserDTO Login(string nombre, string contraseña);
        bool UpdateCredentials(int id, User user);
        int Insert(User user, int codUsuario);
        bool Update(User user, int codUsuario);
        bool Disable(int id, int codUsuario);
        List<UserDTO> GetAll();
        IEnumerable<UserDTO> FindBy(string pattern);
        bool Exists(IComparable searchValue);
    }
}