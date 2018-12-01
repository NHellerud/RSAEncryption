using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Client : SendingComputer
    {
        private int _serverPublicKey;
        private int _serverConstant;
        private string _message;

        public string Message
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

        public void SetData( int max, int min)
        {
            GenerateKey( max, min);
        }

        public Thread StartClient()
        {
            Thread t = new Thread(() => StartClient(_ipAddress, _port, _message));
            t.Start();
            return t;
        }
        private void StartClient(string ipAddress, int port, string message)
        {

            TcpClient tcpclient = new TcpClient();
            IPAddress ip;
            if (!IPAddress.TryParse(ipAddress, out ip))
                ip = IPAddress.Loopback;

            tcpclient.Connect(ip, port);

            Stream stm = tcpclient.GetStream();

           
            string temp = "";
            byte[] b = new byte[100];
            int i = stm.Read(b, 0, 100);

            for (int k = 0; k < i; k++)
                temp += Convert.ToChar(b[k]);
            _serverPublicKey = Int32.Parse(temp);

            temp = "";
            b = new byte[100];
            i = stm.Read(b, 0, 100);

            for (int k = 0; k < i; k++)
                temp += Convert.ToChar(b[k]);
            _serverConstant = Int32.Parse(temp);

            Messages[0] = new Message();
            Messages[0].Text = _serverPublicKey.ToString() + " " + _serverConstant.ToString();
            Messages[0].FromIP = ip.ToString();
            Messages[0].ToIP = _ipAddress;

            Messages[1] = new Message();
            Messages[1].Text = message;
            Messages[1].ToIP = ip.ToString();
            Messages[1].FromIP = _ipAddress;

            byte[] encrypt = RSAEncryptor.Encrypt(message, _serverPublicKey, _serverConstant);

            temp = "";
            Byte[] bytes = new Byte[4];
            for (int k = 0; k < encrypt.Length; k += 4)
            {
                
                temp += BitConverter.ToInt32(encrypt, k).ToString() + " ";
            }

            Messages[2] = new Message();
            Messages[2].Text = temp;
            Messages[2].ToIP = ip.ToString();
            Messages[2].FromIP = _ipAddress;

            ASCIIEncoding ascii = new ASCIIEncoding();
   
            stm.Write(encrypt, 0, encrypt.Length);

            tcpclient.Close();
        }

    }
}
