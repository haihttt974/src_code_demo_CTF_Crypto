using System;
using System.Numerics;

namespace _3DES.CodeMaHoa
{
    public class RSACipher
    {
        private BigInteger p, q, N, r, E, D;
        private int bitLength;

        public RSACipher(int bitLength)
        {
            this.bitLength = bitLength;
            GenerateKey();
        }

        private void GenerateKey()
        {
            Random random = new Random();

            // Tạo số nguyên tố p và q
            p = GenerateProbablePrime(bitLength / 2, random);
            q = GenerateProbablePrime(bitLength / 2, random);

            // Tính N và r (phi(N))
            N = BigInteger.Multiply(p, q);
            r = BigInteger.Multiply(p - 1, q - 1);

            // Chọn E sao cho gcd(E, r) = 1 và 1 < E < r
            do
            {
                E = GenerateRandomBigInteger(bitLength, random);
            } while (E >= r || BigInteger.GreatestCommonDivisor(E, r) != 1);

            // Tính D, là nghịch đảo modulo của E với r
            D = ModInverse(E, r);
        }

        public BigInteger[] Encrypt(string message)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(message);
            BigInteger[] encrypted = new BigInteger[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                encrypted[i] = BigInteger.ModPow(new BigInteger(bytes[i]), E, N);
            }

            return encrypted;
        }

        public string Decrypt(BigInteger[] message, BigInteger d, BigInteger n)
        {
            byte[] bytes = new byte[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                bytes[i] = (byte)BigInteger.ModPow(message[i], d, n);
            }

            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        private BigInteger GenerateProbablePrime(int bits, Random random)
        {
            BigInteger prime;
            do
            {
                prime = GenerateRandomBigInteger(bits, random);
            } while (!IsProbablePrime(prime, 20)); // Kiểm tra tính nguyên tố xác suất
            return prime;
        }

        private BigInteger GenerateRandomBigInteger(int bits, Random random)
        {
            byte[] bytes = new byte[(bits + 7) / 8]; // Tính số byte cần thiết cho bitLength
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F; // Đảm bảo số không âm
            return new BigInteger(bytes);
        }

        private bool IsProbablePrime(BigInteger number, int certainty)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            BigInteger d = number - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random random = new Random();
            for (int i = 0; i < certainty; i++)
            {
                BigInteger a = 2 + (BigInteger)(random.NextDouble() * (double)(number - 4));
                BigInteger x = BigInteger.ModPow(a, d, number);

                if (x == 1 || x == number - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == 1) return false;
                    if (x == number - 1) break;
                }

                if (x != number - 1) return false;
            }

            return true;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1) return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;

                m = a % m;
                a = t;

                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        public BigInteger GetP() => p;
        public BigInteger GetQ() => q;
        public BigInteger GetN() => N;
        public BigInteger GetR() => r;
        public BigInteger GetE() => E;
        public BigInteger GetD() => D;
    }
}
