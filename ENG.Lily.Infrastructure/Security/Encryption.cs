using ENG.Lily.Infrastructure.Shared;
using System.Security.Cryptography;
using System.Text;

namespace ENG.Lily.Infrastructure.Security
{
    public class Encryption
    {
        public static string Encrypt(string text) => GetEncrypted(text + Constants.Security.SALT);

        private static string GetEncrypted(string text)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(text);
            var hash = md5.ComputeHash(inputBytes);
            var strBuilder = new StringBuilder();

            foreach (var b in hash)
            {
                strBuilder.Append(b.ToString("X2"));
            }

            return strBuilder.ToString();
        }
    }
}
