using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class RSAEncryptor
    {
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
            while (i * Coprime % lcm != 1)
                i++;
            return i;
        }

    }
}
