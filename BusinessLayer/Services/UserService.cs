using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Exceptions;
using BusinessLayer.Utilities;
using BusinessLayer.Validators;
using DataLayer.Repositories;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace BusinessLayer.Services
{
    public class UserService
    {
        private readonly IUsuarioRepository _userRepository;

        public UserService(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public int Insert(Usuario usuario, int codUsuario)
        {
            try
            {
                UserValidator.Validate(usuario);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }
            
            if (_userRepository.Exists(usuario.NombreUsuario))
            {
                throw new BusinessException("El nombre de usuario ya existe");
            }

            usuario.Contraseña = PasswordEncryptor.Encryptor(usuario.Contraseña);

            int userId = _userRepository.Insert(usuario, codUsuario);

            return userId;
        }

        public bool Update(Usuario usuario, int codUsuario)
        {
            try
            {
                UpdatePasswordValidator.Validate(usuario);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }
            usuario.Contraseña = PasswordEncryptor.Encryptor(usuario.Contraseña);
            
            return _userRepository.Update(usuario, codUsuario);
        }

        public bool Disable(int id, int codUsuario)
        {
            return _userRepository.Disable(id, codUsuario);
        }

        public List<UserDTO> GetAll()
        {
            return _userRepository.GetAll();
        }

        public IEnumerable<UserDTO> FindBy(string pattern)
        {
            var users = _userRepository.FindBy(pattern);
            if (users == null || !users.Any())
            {
                throw new BusinessException("No se encontraron resultado de su busqueda");
            }

            return users;
        }
    }
}