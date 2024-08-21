using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class UpdatePasswordValidator
    {
        public static void Validate(Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Contraseña))
            {
                if (usuario.Contraseña.Length < 8)
                {
                    throw new ValidationException("La contraseña debe tener una longitud no menor a 8 caracteres.");
                }
            }
        }
    }
}