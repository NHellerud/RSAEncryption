using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class SendingComputer
    {
        protected int _privateKeyA;
        protected int _privateKeyB;
        protected int _computedPrivateKey;
        protected int _publicKey;
        protected int _coPrimeNumber;
        protected int _port;
        protected string _ipAddress;
        protected Message[] _messages = new Message[3];

        public int PublicKey
        {
            get
            {
                return _publicKey;
            }
            protected set
            {
                _publicKey = value;
            }
        }

        public int PrivateKey
        {
            get
            {
                return _computedPrivateKey;
            }
            protected set
            {
                _computedPrivateKey = value;
            }
        }

        public int PrivateKeyA
        {
            get
            {
                return _privateKeyA;
            }
            set
            {
                _privateKeyA = value;
            }
        }

        public int PrivateKeyB
        {
            get
            {
                return _privateKeyB;
            }
            set
            {
                _privateKeyB = value;
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
            }
        }

        public string IPAddr
        {
            get
            {
                return _ipAddress;
            }
            set
            {
                _ipAddress = value;
            }
        }

        public Message[] Messages
        {
            get
            {
                return _messages;
            }
            set
            {
                _messages = value;
            }
        }

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
