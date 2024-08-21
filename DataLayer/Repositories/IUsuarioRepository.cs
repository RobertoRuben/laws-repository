using System;
using System.Collections.Generic;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IUsuarioRepository
    {
        UserDTO Login(string nombre, string contraseña);
        bool UpdateCredentials(int id, Usuario usuario);
        int Insert(Usuario usuario, int codUsuario);
        bool Update(Usuario usuario, int codUsuario);
        bool Disable(int id, int codUsuario);
        List<UserDTO> GetAll();
        IEnumerable<UserDTO> FindBy(string pattern);
        bool Exists(IComparable searchValue);
    }
}