using System;
using BusinessLayer.Exceptions;
using BusinessLayer.Utilities;
using DataLayer.Repositories;
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

        public Usuario Login(string nombreUsuario, string contraseña)
        {
            string hashedPassword = PasswordEncryptor.Encryptor(contraseña);
            Usuario usuario = _usuarioRepository.Login(nombreUsuario, hashedPassword);
            if (usuario == null)
            {
                throw new BusinessException("Nombre de usuario o contraseña incorrectos");
            }
            return usuario;
        }

        public bool UpdateCredentials(int id, string nombreUsuario, string contraseña)
        {
            string hashedPassword = PasswordEncryptor.Encryptor(contraseña);
            return _usuarioRepository.UpdateCredentials(id, nombreUsuario, hashedPassword);
        }
    }
}