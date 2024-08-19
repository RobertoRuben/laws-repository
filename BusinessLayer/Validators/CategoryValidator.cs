using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class CategoryValidator
    {
        public static void Validate(CategoriaDeNorma categoriaDeNorma)
        {
            if (String.IsNullOrWhiteSpace(categoriaDeNorma.TipoDeNorma))
            {
                throw new ValidationException("El nombre de la categoria de norma no puede ser nulo");
            }
        }
    }
}