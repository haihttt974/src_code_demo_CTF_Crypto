using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DES.CodeMaHoa
{
    public class RC4Cipher
    {
        private byte[] S = new byte[256];
        private byte[] T = new byte[256];
        private int keylen;

        public RC4Cipher(byte[] key)
        {
            keylen = key.Length;
            for (int i = 0; i < 256; i++)
            {
                S[i] = (byte)i;
                T[i] = key[i % keylen];
            }

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + T[i]) & 0xFF;
                Swap(S, i, j);
            }
        }

        private void Swap(byte[] arr, int i, int j)
        {
            byte temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public byte[] Encrypt(byte[] plaintext)
        {
            byte[] ciphertext = new byte[plaintext.Length];
            int i = 0, j = 0;

            for (int k = 0; k < plaintext.Length; k++)
            {
                i = (i + 1) & 0xFF;
                j = (j + S[i]) & 0xFF;
                Swap(S, i, j);
                int t = (S[i] + S[j]) & 0xFF;
                ciphertext[k] = (byte)(plaintext[k] ^ S[t]);
            }

            return ciphertext;
        }

        public byte[] Decrypt(byte[] ciphertext)
        {
            return Encrypt(ciphertext); // RC4 uses the same function for encryption and decryption
        }
    }
}
