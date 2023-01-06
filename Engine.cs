using System.Security.Cryptography;
using System.Text;

namespace Cosy
{
    public class Engine
    {
        public static string salt = "TTMC Corporation";
        public static Aes aes = Aes.Create();
        public static SHA256 sha = SHA256.Create();
        public static MD5 md5 = MD5.Create();
        public static byte[] Encrypt(byte[] data, string key)
        {
            aes.Key = sha.ComputeHash(Encoding.UTF8.GetBytes(key));
            return aes.EncryptCfb(data, md5.ComputeHash(Encoding.UTF8.GetBytes(salt)));
        }
        public static byte[] Decrypt(byte[] data, string key)
        {
            aes.Key = sha.ComputeHash(Encoding.UTF8.GetBytes(key));
            return aes.DecryptCfb(data, md5.ComputeHash(Encoding.UTF8.GetBytes(salt)));
        }
    }
}