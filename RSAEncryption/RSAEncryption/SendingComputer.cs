using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class SendingComputer : Computer
    {
        protected int _privateKeyA;
        protected int _privateKeyB;
        protected int _computedPrivateKey;
        protected int _publicKey;
        protected int _coPrimeNumber;

        public void GenerateKey( int max, int min)
        {
            _privateKeyA = PrimeNumber.returnPrime(min, max);
            _privateKeyB = PrimeNumber.returnPrime(min, max);
            _publicKey = RSAEncryptor.GeneratePublicKey(_privateKeyA, _privateKeyB);
            int x = RSAEncryptor.LeastCommonMultiple(_privateKeyA, _privateKeyB);
            _coPrimeNumber = RSAEncryptor.GenerateCoPrime( _privateKeyA, _privateKeyB, x);
            _computedPrivateKey = RSAEncryptor.GeneratePrivateKey(_privateKeyA, _privateKeyB, _coPrimeNumber, x);
        }

    }
}
