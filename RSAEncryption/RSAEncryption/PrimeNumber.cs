using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class PrimeNumber
    {
        public int[] Primes;

        public PrimeNumber()
        {
            Primes = new int[1000000];
            LoadPrimes();
        }

        public void LoadPrimes()
        {
            for (int i = 2; i < 1000000; i++)
            {
                if (Primes[i] == 0)
                {
                    for (int k = 2; i * k < 1000000; k++)
                        Primes[i * k] = 1;
                }
            }

        }

        public int returnPrime(int min, int max)
        {
            Random r = new Random();

            System.Threading.Thread.Sleep(100);
            int n = r.Next(min, max);
            while (Primes[n] != 0)
                n++;
            return n;
        }
    }
}
