using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Server : SendingComputer
    {
        public void SetData( int max, int min)
        {
            GenerateKey( max, min);
            RSAEncryption.SetServerKeys(_publicKey, _computedPrivateKey);
        }

    }
}
