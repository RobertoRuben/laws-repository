using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class UpdatePasswordValidator
    {
        public static void Validate(User user)
        {
            if (!string.IsNullOrEmpty(user.Password))
            {
                if (user.Password.Length < 8)
                {
                    throw new ValidationException("La contraseña debe tener una longitud no menor a 8 caracteres.");
                }
            }
        }
    }
}