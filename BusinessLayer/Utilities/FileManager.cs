using System;
using System.IO;
using BusinessLayer.Exceptions;

namespace BusinessLayer.Utilities
{
    public static class FileManager
    {
        public static string ServerPath { get; set; } = @"\\192.168.10.12\prueba\normatividad";

        public static string SaveFileToServer(string sourceFilePath)
        {
            string lawsFolderPath = EnsureFolderStructure("Laws");

            try
            {
                string filePath = Path.Combine(lawsFolderPath, Path.GetFileName(sourceFilePath));
                File.Copy(sourceFilePath, filePath, true);
                return filePath;
            }
            catch (ArgumentException ex)
            {
                throw new BusinessException("Ocurrió un error al almacenar el archivo: " + ex.Message);
            }
            catch (IOException ex)
            {
                throw new BusinessException("Error de E/S al almacenar el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new BusinessException("Acceso no autorizado al almacenar el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessException("Error inesperado al almacenar el archivo: " + ex.Message);
            }
        }
        
        public static void DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                else
                {
                    throw new BusinessException("El archivo no existe y no se puede eliminar.");
                }
            }
            catch (IOException ex)
            {
                throw new BusinessException("Error de E/S al eliminar el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new BusinessException("Acceso no autorizado al eliminar el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessException("Error inesperado al eliminar el archivo: " + ex.Message);
            }
        }
        
        public static void ReplaceFile(string sourceFilePath, string targetFilePath)
        {
            try
            {
                // Elimina el archivo existente si existe
                if (File.Exists(targetFilePath))
                {
                    File.Delete(targetFilePath);
                }
        
                // Copia el nuevo archivo en la ubicación deseada
                File.Copy(sourceFilePath, targetFilePath, true);
            }
            catch (IOException ex)
            {
                throw new BusinessException("Error de E/S al reemplazar el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new BusinessException("Acceso no autorizado al reemplazar el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessException("Error inesperado al reemplazar el archivo: " + ex.Message);
            }
        }

        
        private static string EnsureFolderStructure(string subFolder)
        {
            string fullPath = Path.Combine(ServerPath, subFolder);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
            return fullPath;
        }
    }
}