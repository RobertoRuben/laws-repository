using System;
using BusinessLayer.Exceptions;
using BusinessLayer.Utilities;
using BusinessLayer.Validators;
using DataLayer.Repositories;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace BusinessLayer.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO Login(string nombreUsuario, string contraseña)
        {
            string hashedPassword = PasswordEncryptor.Encryptor(contraseña);
            UserDTO userDto = _userRepository.Login(nombreUsuario, hashedPassword);
            if (userDto == null)
            {
                throw new BusinessException("Nombre de usuario o contraseña incorrectos");
            }
            return userDto;
        }

        public bool UpdateCredentials(int id, User user)
        {
            try
            {
                UpdatePasswordValidator.Validate(user);

            }
            catch (ArgumentException ex)
            {
                throw new ValidationException("La contraseña debe tener una longitud no menor a 8 digitos");
            }
            
            user.Password = PasswordEncryptor.Encryptor(user.Password);
            
            return _userRepository.UpdateCredentials(id, user);
        }
    }
}