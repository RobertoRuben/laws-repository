using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Utilities
{
    public static class PasswordEncryptor
    {
        public static string Encryptor(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la password en una matriz de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir los bytes en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                // Devolver la cadena hexadecimal hasheada
                return builder.ToString();
            }
        }
    }
}