using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class UserValidator
    {
        public static void Validate(Usuario usuario)
        {
            if (usuario.CodTrabajador == 0)
            {
                throw new ValidationException(
                    "El nombre del trabajador al cual se le creara el usuario no puede quedar en blanco");
            }

            if (usuario.CodRol == 0)
            {
                throw new ValidationException("Se debe asignar un rol a un usuario");
            }

            if (String.IsNullOrWhiteSpace(usuario.NombreUsuario))
            {
                throw new ValidationException("El nombre de usuario no debe ser nulo");
            }

            if (String.IsNullOrWhiteSpace(usuario.Contraseña))
            {
                throw new ValidationException("Se debe asginar una contraseña");
            }else if (usuario.Contraseña.Equals(""))
            {
                throw new ValidationException("La contraseña no puede quedar en blanco");
            }else if (usuario.Contraseña.Length < 8)
            {
                throw new ValidationException("La contraseña debe tener al menos 8 caracteres");
            }

            if (String.IsNullOrWhiteSpace(usuario.Estado))
            {
                throw new ValidationException("Se deber asignar un estado al usuario");
            }
            else if(usuario.Estado.Equals("Inactivo"))
            {
                throw new ValidationException("No se puede crear un usuario con estado inactivo");
            }
        }
    }
}