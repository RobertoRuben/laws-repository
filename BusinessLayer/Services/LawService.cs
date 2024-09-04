using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BusinessLayer.Exceptions;
using BusinessLayer.Utilities;
using BusinessLayer.Validators;
using DataLayer.Repositories;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;

namespace BusinessLayer.Services
{
    public class LawService
    {
        private readonly ILawRepository _lawRepository;

        public LawService(ILawRepository lawRepository)
        {
            _lawRepository = lawRepository;
        }

        public int Insert(Law law, int codUsuario)
        {
            try
            {
                LawValidator.Validate(law);
                if (_lawRepository.Exists(law.LawNumber))
                {
                    throw new BusinessException("El número de norma ya se encuentra registrada");
                }

                // Guarda el archivo en el servidor antes de insertar la ley
                string savedFilePath = FileManager.SaveFileToServer(law.PathArchive);
                law.PathArchive = savedFilePath;

                int idLaw = _lawRepository.Insert(law, codUsuario);

                return idLaw;
            }
            catch (Exception ex)
            {
                // Si hay un error y el archivo fue guardado, intenta eliminarlo
                if (!string.IsNullOrEmpty(law.PathArchive))
                {
                    FileManager.DeleteFile(law.PathArchive);
                }

                throw new BusinessException("Error al guardar la norma: " + ex.Message);
            }
        }

        public bool Update(Law law, int codUsuario)
        {
            string originalFilePath = null;
            try
            {
                LawValidator.Validate(law);
                law.LawName = TextTransformer.CapitalizeFirstLetter(law.LawName);
                law.LawSummary = TextTransformer.CapitalizeFirstLetter(law.LawSummary);

                // Obtener la ley existente para verificar el path del archivo actual
                var existingLaw = _lawRepository.GetById(law.CodLaw);
                if (existingLaw == null)
                {
                    throw new BusinessException("No se pudo encontrar la ley especificada para actualizar.");
                }

                // Guarda el path original en caso de necesitar revertir los cambios
                originalFilePath = existingLaw.PathArchive;

                // Si el path del archivo es diferente, reemplazar el archivo
                if (!string.IsNullOrEmpty(law.PathArchive) && law.PathArchive != existingLaw.PathArchive)
                {
                    // Eliminar el archivo antiguo
                    FileManager.DeleteFile(originalFilePath);

                    // Guardar el nuevo archivo
                    string savedFilePath = FileManager.SaveFileToServer(law.PathArchive);
                    law.PathArchive = savedFilePath;
                }

                // Actualizar la ley en la base de datos
                bool updateResult = _lawRepository.Update(law, codUsuario);
                if (!updateResult)
                {
                    // Si la actualización falla, intentar revertir el cambio de archivo
                    if (!string.IsNullOrEmpty(law.PathArchive) && law.PathArchive != originalFilePath)
                    {
                        FileManager.ReplaceFile(law.PathArchive, originalFilePath);
                        law.PathArchive = originalFilePath; // Restablecer el path al original
                    }

                    throw new BusinessException("No se pudo actualizar la ley.");
                }

                return true;
            }
            catch (Exception ex)
            {
                // Si hay una excepción y se cambió el archivo, intentar revertir al archivo original
                if (!string.IsNullOrEmpty(originalFilePath) && originalFilePath != law.PathArchive)
                {
                    FileManager.ReplaceFile(law.PathArchive, originalFilePath);
                    law.PathArchive = originalFilePath; // Restablecer el path al original
                }

                throw new BusinessException("Error al actualizar la ley: " + ex.Message);
            }
        }

        public bool Delete(int id, int codUsuario)
        {
            // Primero, obtener la información de la ley para acceder al path del archivo
            var law = _lawRepository.GetById(id);
            if (law == null)
            {
                throw new BusinessException("La ley especificada no existe.");
            }

            // Eliminar la ley de la base de datos
            bool isDeleted = _lawRepository.Delete(id, codUsuario);
            if (!isDeleted)
            {
                throw new BusinessException("No se pudo eliminar la ley de la base de datos.");
            }

            // Si la ley se eliminó exitosamente, intentar eliminar el archivo asociado
            if (!string.IsNullOrEmpty(law.PathArchive))
            {
                FileManager.DeleteFile(law.PathArchive); // Aquí se lanza la excepción si falla la eliminación
            }

            return true;
        }

        public List<LawDTO> GetAll(int pageSize, int pageNumber)
        {
            return _lawRepository.GetAll(pageSize, pageNumber);
        }

        public IEnumerable<LawDTO> FindBy(string pattern)
        {
            var law = _lawRepository.FindBy(pattern);
            if (law == null || !law.Any())
            {
                throw new BusinessException("No se encontraron resultados de su busqueda");
            }

            return law;
        }

        public void OpenDocument(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ValidationException("El path del documento no puede estar vacío.");
            }

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                throw new BusinessException("No se pudo abrir el documento: " + ex.Message);
            }
        }
    }
}