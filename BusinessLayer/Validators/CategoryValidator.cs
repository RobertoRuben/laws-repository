using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class CategoryValidator
    {
        public static void Validate(CategoryLaw categoryLaw)
        {
            if (String.IsNullOrWhiteSpace(categoryLaw.CategoryName))
            {
                throw new ValidationException("El nombre de la categoria de norma no puede ser nulo");
            }
        }
    }
}