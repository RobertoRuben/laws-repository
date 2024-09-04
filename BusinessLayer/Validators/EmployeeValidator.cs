using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class EmployeeValidator
    {
        public static void Validate(Employee employee)
        {
            if (String.IsNullOrWhiteSpace(Convert.ToString(employee.Dni)) )
            {
                throw new ValidationException("El dni del trabajador no puede quedar vacio.");
            }
            else if (Convert.ToString(employee.Dni).Length != 8)
            {
                throw new ValidationException("El DNI del trabajador debe tener exactamente 8 dígitos.");
            }

            if (String.IsNullOrWhiteSpace(employee.EmployeeName))
            {
                throw new ValidationException("El nombre del trabajador no puede quedar vacio.");
            }

            if (String.IsNullOrWhiteSpace(employee.PaternalSurname))
            {
                throw new ValidationException("El apellido paterno del trabajador no puede quedar vacio.");
            }

            if (String.IsNullOrWhiteSpace(employee.MaternalSurname))
            {
                throw new ValidationException("El apellido materno del trabajador no puede quedar vacio.");
            }

            if (String.IsNullOrWhiteSpace(Convert.ToString(employee.Gender)))
            {
                throw new ValidationException("El campo sexo del trabajador es obligatorio.");
            }
        }
    }
}