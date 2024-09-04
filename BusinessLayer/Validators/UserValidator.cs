using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class UserValidator
    {
        public static void Validate(User user)
        {
            if (user.CodEmployee == 0)
            {
                throw new ValidationException(
                    "El nombre del trabajador al cual se le creara el usuario no puede quedar en blanco");
            }

            if (user.CodRol == 0)
            {
                throw new ValidationException("Se debe asignar un rol a un usuario");
            }

            if (String.IsNullOrWhiteSpace(user.UserName))
            {
                throw new ValidationException("El nombre de usuario no debe ser nulo");
            }

            if (String.IsNullOrWhiteSpace(user.Password))
            {
                throw new ValidationException("Se debe asginar una contraseña");
            }else if (user.Password.Equals(""))
            {
                throw new ValidationException("La contraseña no puede quedar en blanco");
            }else if (user.Password.Length < 8)
            {
                throw new ValidationException("La contraseña debe tener al menos 8 caracteres");
            }

            if (String.IsNullOrWhiteSpace(user.State))
            {
                throw new ValidationException("Se deber asignar un estado al usuario");
            }
            else if(user.State.Equals("Inactivo"))
            {
                throw new ValidationException("No se puede crear un usuario con estado inactivo");
            }
        }
    }
}