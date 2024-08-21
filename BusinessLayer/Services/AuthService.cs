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
        private readonly IUsuarioRepository _usuarioRepository;

        public AuthService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UserDTO Login(string nombreUsuario, string contraseña)
        {
            string hashedPassword = PasswordEncryptor.Encryptor(contraseña);
            UserDTO userDto = _usuarioRepository.Login(nombreUsuario, hashedPassword);
            if (userDto == null)
            {
                throw new BusinessException("Nombre de usuario o contraseña incorrectos");
            }
            return userDto;
        }

        public bool UpdateCredentials(int id, Usuario usuario)
        {
            try
            {
                UpdatePasswordValidator.Validate(usuario);

            }
            catch (ArgumentException ex)
            {
                throw new ValidationException("La contraseña debe tener una longitud no menor a 8 digitos");
            }
            
            usuario.Contraseña = PasswordEncryptor.Encryptor(usuario.Contraseña);
            
            return _usuarioRepository.UpdateCredentials(id, usuario);
        }
    }
}