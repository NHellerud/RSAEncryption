using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class RSAEncryptor
    {
        public static byte[] Encrypt(string message, int key, int constant)
        {
            Byte[] encryt = new byte[4 * message.Length];
            for(int i = 0; i < message.Length;i++)
            {
                char c = message[i];
                int n = (int) c;
                int temp = n;
                for(int k = 0; k < constant - 1;k++)
                    n = (n * temp) % key;
                byte[] bytes = BitConverter.GetBytes(n);
                for (int k = 0; k < bytes.Length; k++)
                    encryt[i * 4 + k] = bytes[k];
            }
            return encryt;

        }

        public static string Decrypt(byte[] message, int publicKey, int privateKey, int len)
        {
            int[] numbers = new int[len / 4];
            string s = "";
            for(int i = 0; i < len/4; i++)
            {
                numbers[i] = BitConverter.ToInt32(message, i * 4);
         
            }

            
            for(int i = 0; i < numbers.Length;i++)
            {
                int temp = numbers[i];
                for(int k = 0; k < privateKey - 1;k++)
                {
                    numbers[i] = (numbers[i] * temp) % publicKey;
                }
                s += (char)numbers[i];
            }
     
            return s;
        }

       

        public static int GeneratePublicKey(int KeyA, int KeyB)
        {
            return KeyA * KeyB;
        }

        public static int LeastCommonMultiple( int KeyA, int KeyB)
        {
            int x, y, z;
            x = KeyA - 1;
            y = KeyB - 1;
            z = x * 2;
            while (z % y != 0)
                z += x;
            return z;
        }

        public static int GenerateCoPrime(int KeyA, int KeyB, int lcm)
        { 
            int coprime = PrimeNumber.returnPrime(1, lcm);
            while (lcm % coprime == 0)
                coprime = PrimeNumber.returnPrime(1, lcm);
            return coprime;
        }

        public static int GeneratePrivateKey(int KeyA, int KeyB, int Coprime, int lcm)
        {
            int i = 1;
            while ((i * Coprime) % lcm != 1)
                i++;
            return i;
        }

    }
}
