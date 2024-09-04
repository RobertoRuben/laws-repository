using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using BusinessLayer.Exceptions;
using BusinessLayer.Validators;
using DataLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLayer.Services
{
    public class CategoryService
    {
        private readonly IRepository<CategoryLaw> _categoryRepository;

        public CategoryService(IRepository<CategoryLaw> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public int Insert(CategoryLaw categoryLaw, int codUsuario)
        {
            try
            {
                CategoryValidator.Validate(categoryLaw);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);

            }

            if (_categoryRepository.Exists(categoryLaw.CategoryName))
            {
                throw new BusinessException("El nombre de la categoria ya existe");
            }
            int idCategoria = _categoryRepository.Insert(categoryLaw, codUsuario);

            return idCategoria;
        }

        public bool Update(CategoryLaw categoryLaw, int codUsuario)
        {
            try
            {
                CategoryValidator.Validate(categoryLaw);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);

            }
            if (_categoryRepository.Exists(categoryLaw.CategoryName))
            {
                throw new BusinessException("No se puede actualizar a un nombre de categoria ya existente");
            }
            return _categoryRepository.Update(categoryLaw, codUsuario);
        }

        public bool Delete(int id, int codUsuario)
        {
            return _categoryRepository.Delete(id, codUsuario);
        }

        public List<CategoryLaw> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public IEnumerable<CategoryLaw> FindBy(string pattern)
        {
            var category = _categoryRepository.FindBy(pattern);
            if (category == null || !category.Any())
            {
                throw new BusinessException("No se encontraron resultados de busqueda");
            }

            return category;
        }
    }
}