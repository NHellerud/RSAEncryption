using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Eavesdropper
    {
        int[] _primes;
        int _privateKeyClient;
        int _privateKeyServer;

        public int PrivateKeyClient
        {
            get
            {
                return _privateKeyClient;
            }
        }

        public int PrivateKeyServer
        {
            get
            {
                return _privateKeyServer;
            }
        }

        public Eavesdropper()
        {
            PrimeNumber primeNumber = new PrimeNumber();
            _primes = primeNumber.Primes;
        }

        public void Break(int publicKeyClient, int clientPrime, int publicKeyServer, int serverPrime)
        {
            int lcm;
            for (int i = 2; i < publicKeyClient; i++)
            {
                if(_primes[i] == 0)
                    for (int k = 2; k < publicKeyClient; k++)
                    {
                        if (_primes[k] == 0)
                        {
                            if (i * k > publicKeyClient)
                                k = publicKeyClient;
                            if(i * k == publicKeyClient)
                            {
                                lcm = RSAEncryptor.LeastCommonMultiple(i, k);
                                _privateKeyClient = RSAEncryptor.GeneratePrivateKey( clientPrime, lcm);
                                i = publicKeyClient;
                            }
                        }
                    }
            }

            for (int i = 2; i < publicKeyServer; i++)
            {
                if (_primes[i] == 0)
                    for (int k = 2; k < publicKeyServer; k++)
                    {
                        if (_primes[k] == 0)
                        {
                            if (i * k > publicKeyServer)
                                k = publicKeyServer;
                            if (i * k == publicKeyServer)
                            {
                                lcm = RSAEncryptor.LeastCommonMultiple(i, k);
                                _privateKeyServer = RSAEncryptor.GeneratePrivateKey( serverPrime, lcm);
                                i = publicKeyServer;
                            }
                        }
                    }
            }
        }
    }
}
