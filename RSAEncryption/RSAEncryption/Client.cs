using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Client : SendingComputer
    {
        private ThreadStaticAttribute clientThread;

        public void SetData( int max, int min)
        {
            GenerateKey( max, min);
            RSAEncryption.SetClientKeys(_publicKey, _computedPrivateKey);
        }

    }
}
