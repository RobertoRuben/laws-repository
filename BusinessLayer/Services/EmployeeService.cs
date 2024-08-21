﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using BusinessLayer.Exceptions;
using BusinessLayer.Validators;
using DataLayer.Repositories;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace BusinessLayer.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public int Insert(Trabajador trabajador, int codUsuario)
        {
            try
            {
                EmployeeValidator.Validate(trabajador);
            }
            catch (ArgumentException ex)
            {
                throw new ValidationException(ex.Message);
            }

            if (_employeeRepository.Exists(trabajador.Dni))
            {
                throw new BusinessException("El DNI ingresado ya se encuentra registrado en la base de datos");
            }
            

            int idEmployee = _employeeRepository.Insert(trabajador, codUsuario);

            return idEmployee;
        }

        public bool Update(Trabajador trabajador, int codUsuario)
        {
            try
            {
                EmployeeValidator.Validate(trabajador);
            }
            catch (ArgumentException ex)
            {
                throw new BusinessException(ex.Message);
            }
            return _employeeRepository.Update(trabajador, codUsuario);
        }

        public bool Delete(int id, int codUsuario)
        {
            return _employeeRepository.Delete(id, codUsuario);
        }

        public List<Trabajador> GetAll(int pageSize, int pageNumber)
        {
            return _employeeRepository.GetAll(pageSize, pageNumber);
        }

        public IEnumerable<Trabajador> FindBy(String pattern)
        {
            var employee = _employeeRepository.FindBy(pattern);

            if (employee == null || !employee.Any())
            {
                throw new BusinessException("No se encontraron resultados de busqueda");
            }

            return employee;
        }

        public List<EmployeeDTO> GetNames()
        {
            return _employeeRepository.GetNames();
        }
    }
}