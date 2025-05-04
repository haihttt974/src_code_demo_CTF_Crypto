using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3DES
{
    public class _3DES
    {
        private static readonly string ALGORITHM = "TripleDES";

        public static string Encrypt(string plaintext, string secretKey)
        {
            using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider())
            {
                tripleDES.Key = GenerateKey(secretKey);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = tripleDES.CreateEncryptor();
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        public static string Decrypt(string ciphertext, string secretKey)
        {
            using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider())
            {
                tripleDES.Key = GenerateKey(secretKey);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = tripleDES.CreateDecryptor();
                byte[] ciphertextBytes = Convert.FromBase64String(ciphertext);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(ciphertextBytes, 0, ciphertextBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        private static byte[] GenerateKey(string secretKey)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(secretKey);
            byte[] validKeyBytes = new byte[24];

            for (int i = 0; i < validKeyBytes.Length; i++)
            {
                validKeyBytes[i] = i < keyBytes.Length ? keyBytes[i] : (byte)0;
            }

            return validKeyBytes;
        }
    }
}
