using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Message
    {
        string _message = "";
        string _toIP = "";
        string _fromIP = "";

        public string Text
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }

        public string ToIP
        {
            get
            {
                return _toIP;
            }
            set
            {
                _toIP = value;
            }
        }

        public string FromIP
        {
            get
            {
                return _fromIP;
            }
            set
            {
                _fromIP = value;
            }
        }
    }
}
