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
        private readonly IRepository<CategoriaDeNorma> _categoryRepository;

        public CategoryService(IRepository<CategoriaDeNorma> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public int Insert(CategoriaDeNorma categoriaDeNorma, int codUsuario)
        {
            try
            {
                CategoryValidator.Validate(categoriaDeNorma);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);

            }

            if (_categoryRepository.Exists(categoriaDeNorma.TipoDeNorma))
            {
                throw new BusinessException("El nombre de la categoria ya existe");
            }
            int idCategoria = _categoryRepository.Insert(categoriaDeNorma, codUsuario);

            return idCategoria;
        }

        public bool Update(CategoriaDeNorma categoriaDeNorma, int codUsuario)
        {
            try
            {
                CategoryValidator.Validate(categoriaDeNorma);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);

            }
            if (_categoryRepository.Exists(categoriaDeNorma.TipoDeNorma))
            {
                throw new BusinessException("No se puede actualizar a un nombre de categoria ya existente");
            }
            return _categoryRepository.Update(categoriaDeNorma, codUsuario);
        }

        public bool Delete(int id, int codUsuario)
        {
            return _categoryRepository.Delete(id, codUsuario);
        }

        public List<CategoriaDeNorma> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public IEnumerable<CategoriaDeNorma> FindBy(string pattern)
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