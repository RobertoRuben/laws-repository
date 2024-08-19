using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class EmployeeValidator
    {
        public static void Validate(Trabajador trabajador)
        {
            if (String.IsNullOrWhiteSpace(Convert.ToString(trabajador.Dni)) )
            {
                throw new ValidationException("El dni del trabajador no puede quedar vacio.");
            }
            else if (Convert.ToString(trabajador.Dni).Length != 8)
            {
                throw new ValidationException("El DNI del trabajador debe tener exactamente 8 dígitos.");
            }

            if (String.IsNullOrWhiteSpace(trabajador.Nombre))
            {
                throw new ValidationException("El nombre del trabajador no puede quedar vacio.");
            }

            if (String.IsNullOrWhiteSpace(trabajador.ApellidoPaterno))
            {
                throw new ValidationException("El apellido paterno del trabajador no puede quedar vacio.");
            }

            if (String.IsNullOrWhiteSpace(trabajador.ApellidoMaterno))
            {
                throw new ValidationException("El apellido materno del trabajador no puede quedar vacio.");
            }

            if (String.IsNullOrWhiteSpace(Convert.ToString(trabajador.Sexo)))
            {
                throw new ValidationException("El campo sexo del trabajador es obligatorio.");
            }
        }
    }
}