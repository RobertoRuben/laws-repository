using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Utilities
{
    public static class PasswordEncryptor
    {
        public static string Encryptor(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return "";
            }

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                
                return builder.ToString();
            }
        }
    }
}