using System;
using BusinessLayer.Exceptions;
using EntitiesLayer.Entities;

namespace BusinessLayer.Validators
{
    public static class ArticleValidator
    {
        public static void Validate(Article article)
        {
            if (String.IsNullOrWhiteSpace(Convert.ToString(article.ArticleNumber)) )
            {
                throw new ValidationException("El numero del articulo no puede quedar en blanco.");
            }
            else if (Convert.ToString(article.ArticleNumber).Length <=0)
            {
                throw new ValidationException("El numero del articulo no puede ser cero");
            }

            // Validación de la denominación del artículo
            if (String.IsNullOrWhiteSpace(article.Denomination))
            {
                throw new ValidationException("La denominación del artículo no puede quedar en blanco.");
            }

            // Validación de la descripción del artículo
            if (String.IsNullOrWhiteSpace(article.Description))
            {
                throw new ValidationException("La descripción del artículo no puede quedar en blanco.");
            }

            // Validación del estado del artículo
            if (String.IsNullOrWhiteSpace(article.State))
            {
                throw new ValidationException("El estado del artículo no puede quedar en blanco.");
            }

            // Validación del número de páginas
            if (article.PageNumber <= 0)
            {
                throw new ValidationException("El número de páginas debe ser un número positivo.");
            }
        }
    }
}