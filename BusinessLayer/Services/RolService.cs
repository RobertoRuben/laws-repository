using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Exceptions;
using BusinessLayer.Validators;
using DataLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLayer.Services
{
    public class RolService
    {
        private readonly IRepository<Rol> _rolRepository; 
        public RolService(IRepository<Rol> rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public int Insert(Rol rol, int codUsuario)
        {
            try
            {
                RolValidator.Validate(rol);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }

            if (_rolRepository.Exists(rol.RolName))
            {
                throw new BusinessException("El nombre del rol ya existe");
            }
            
            int rolId = _rolRepository.Insert(rol, codUsuario);

            return rolId;
        }

        public bool Update(Rol rol, int codUsuario)
        {
            try
            {
                RolValidator.Validate(rol);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }
            if (_rolRepository.Exists(rol.RolName))
            {
                throw new BusinessException("No se puede actualizar a un nombre de rol ya existente");
            }

            return _rolRepository.Update(rol, codUsuario);
        }

        public bool Delete(int id, int codUsuario)
        {
            return _rolRepository.Delete(id, codUsuario);
        }
        
        public List<Rol> GetAll()
        {
            return _rolRepository.GetAll();
        }

        public IEnumerable<Rol> FindBy(string pattern)
        {
            var roles = _rolRepository.FindBy(pattern);
            if (roles == null || !roles.Any())
            {
                throw new BusinessException("No se encontraron resultados de su busqueda");
            }
            return roles;
        }
    }
}