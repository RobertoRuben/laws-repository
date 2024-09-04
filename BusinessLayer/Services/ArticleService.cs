using System;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using BusinessLayer.Validators;
using BusinessLayer.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Services
{
    public class ArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public int Insert(Article article, int userId)
        {
            try
            {
                ArticleValidator.Validate(article);

                // Verificar si el artículo ya está registrado en la norma
                if (_articleRepository.Exists(article.CodLaw, article.ArticleNumber))
                {
                    throw new BusinessException("El artículo con el mismo número ya está registrado en esta norma.");
                }

                return _articleRepository.Insert(article, userId);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }
        }

        public bool Update(Article article, int userId)
        {
            try
            {
                ArticleValidator.Validate(article);

                return _articleRepository.Update(article, userId);
            }
            catch (ArgumentException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public bool Delete(int id, int userId)
        {
            return _articleRepository.Delete(id, userId);
        }

        public List<Article> GetAll(int lawCode, int pageSize, int pageNumber)
        {
            return _articleRepository.GetAll(lawCode, pageSize, pageNumber);
        }

        public Article GetById(int id)
        {
            var article = _articleRepository.GetById(id);
            if (article == null)
            {
                throw new BusinessException("No se encontró el artículo especificado.");
            }

            return article;
        }

        public IEnumerable<Article> FindBy(int lawCode, string pattern)
        {
            var articles = _articleRepository.FindBy(lawCode, pattern);
            if (articles == null || !articles.Any())
            {
                throw new BusinessException(
                    "No se encontraron resultados de búsqueda para los criterios especificados.");
            }

            return articles;
        }
    }
}