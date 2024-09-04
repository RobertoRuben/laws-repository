using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class RolValidator
    {
        public static void Validate(Rol rol)
        {
            if (String.IsNullOrWhiteSpace(rol.RolName))
            {
                throw new ValidationException("El nombre del rol no debe ser nulo");
            }
        }
    }
}