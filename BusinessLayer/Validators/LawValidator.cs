using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class LawValidator
    {
        public static void Validate(Law law)
        {
            if (law.CodUser == 0)
            {
                throw new ValidationException("");
            }

            if (law.CodCategory == 0)
            {
                throw new ValidationException("");
            }

            if (String.IsNullOrWhiteSpace(law.LawNumber))
            {
                throw new ValidationException("El numero de la norma no puede quedar vacio");
            }

            if (String.IsNullOrWhiteSpace(law.LawName))
            {
                throw new ValidationException("El nombre de la norma no puede quedar en blanco");
            }

            if (String.IsNullOrWhiteSpace(law.LawSummary))
            {
                throw new ValidationException("El resumen de la norma no puede quedar en blanco");
            }

            if (String.IsNullOrWhiteSpace(law.PublicationDate))
            {
                throw new ValidationException("La fecha de publicacion no puede quedar en blanco");
            }

            if (String.IsNullOrWhiteSpace(Convert.ToString(law.PageNumber)))
            {
                throw new ValidationException("El numero de paginas no puede quedar en banco");
            }

            if (String.IsNullOrWhiteSpace(law.PublicationMedium))
            {
                throw new ValidationException("El medio de publicacion de la norma es obligatorio");
            }

            if (String.IsNullOrWhiteSpace(law.State))
            {
                throw new ValidationException("El estado de la norma es obligatorio");
            }
        }
    }
}