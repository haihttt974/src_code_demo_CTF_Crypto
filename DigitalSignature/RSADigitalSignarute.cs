using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DES.DigitalSignature
{
    public class RSADigitalSignarute
    {
        private RSACryptoServiceProvider rsa;

        public RSADigitalSignarute()
        {
            rsa = new RSACryptoServiceProvider();
        }

        public void GenerateKeyPair(out string publicKey, out string privateKey)
        {
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }

        // Ký tệp và trả về chữ ký dưới dạng chuỗi Base64
        public string SignFile(string filePath, string privateKey)
        {
            rsa.FromXmlString(privateKey);

            byte[] fileData = File.ReadAllBytes(filePath);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(fileData);
                byte[] signature = rsa.SignHash(hash, CryptoConfig.MapNameToOID("SHA256"));
                return Convert.ToBase64String(signature);
            }
        }

        // Xác thực chữ ký từ chuỗi Base64
        public bool VerifyFileSignature(string filePath, string signatureBase64, string publicKey)
        {
            try
            {
                rsa.FromXmlString(publicKey);

                byte[] fileData = File.ReadAllBytes(filePath);
                byte[] signature = Convert.FromBase64String(signatureBase64); // Chuyển đổi chữ ký từ Base64

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hash = sha256.ComputeHash(fileData);
                    return rsa.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA256"), signature);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Chữ ký không đúng định dạng Base64: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
                return false;
            }
        }



        // Lưu chữ ký vào tệp dưới dạng Base64 string
        public void SaveSignatureToFile(string signatureBase64, string signatureFilePath)
        {
            File.WriteAllText(signatureFilePath, signatureBase64);
        }
        public void SaveSignatureToXml(string signatureBase64, string filePath)
        {
            var signatureXml = $"<Signature>{signatureBase64}</Signature>";
            File.WriteAllText(filePath, signatureXml);
        }

        // Lưu khóa vào tệp
        public void SaveKeyToFile(string key, string filePath)
        {
            File.WriteAllText(filePath, key.Trim());
        }
        public void SavePublicKeyToXml(string publicKey, string filePath)
        {
            if (!publicKey.StartsWith("<RSAKeyValue>"))
            {
                throw new InvalidDataException("Public Key không đúng định dạng XML.");
            }
            File.WriteAllText(filePath, publicKey);
        }

        // Đọc khóa từ tệp
        public string LoadKeyFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Không tìm thấy tệp tại đường dẫn: {filePath}");
            }

            return File.ReadAllText(filePath).Trim();
        }




        // Đọc nội dung string từ tệp
        public string LoadFromFile(string filePath)
        {
            return File.ReadAllText(filePath); // Đọc nội dung từ file text
        }
    }
}
