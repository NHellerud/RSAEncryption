using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Server : SendingComputer
    {

        public string message = "";
        public void SetData( int max, int min)
        {
            GenerateKey( max, min);
        }

        public Thread StartServer()
        {
            Thread t = new Thread(() => StartServer(_ipAddress, _port));
            t.Start();
            return t;
        }

        private void StartServer(string ipAddress, int port)
        {
            IPAddress ip;
            ASCIIEncoding ascii = new ASCIIEncoding();
            bool res = IPAddress.TryParse(ipAddress, out ip);
            if (!res)
                ip = IPAddress.Loopback;
            TcpListener myListener = new TcpListener(ip, port);

            myListener.Start();

            Socket s = myListener.AcceptSocket();

            Messages[0] = new Message();
            Messages[0].Text = _publicKey.ToString() + " " + _coPrimeNumber + " " + _privateKeyA + " " + _privateKeyB;
            Messages[0].FromIP = ip.ToString();

            s.Send(ascii.GetBytes(_publicKey.ToString()));
            s.Send(ascii.GetBytes(_coPrimeNumber.ToString()));


            byte[] b = new byte[10000];

            int i = s.Receive(b);

            message = RSAEncryptor.Decrypt(b, _publicKey, _computedPrivateKey, i);

            Messages[1] = new Message();
            Messages[1].Text = message;
            Messages[1].ToIP = ip.ToString();


            Messages[2] = new Message();
            Messages[2].Text = message;
            Messages[2].ToIP = ip.ToString();

            s.Close();
            myListener.Stop();

        }

    }
}
