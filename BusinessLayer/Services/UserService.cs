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
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public int Insert(User user, int codUsuario)
        {
            try
            {
                UserValidator.Validate(user);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }
            
            if (_userRepository.Exists(user.UserName))
            {
                throw new BusinessException("El nombre de user ya existe");
            }

            user.Password = PasswordEncryptor.Encryptor(user.Password);

            int userId = _userRepository.Insert(user, codUsuario);

            return userId;
        }

        public bool Update(User user, int codUsuario)
        {
            try
            {
                UpdatePasswordValidator.Validate(user);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }
            user.Password = PasswordEncryptor.Encryptor(user.Password);
            
            return _userRepository.Update(user, codUsuario);
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