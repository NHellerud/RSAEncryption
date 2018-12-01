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
        string message = "";
        public void SetData( int max, int min)
        {
            GenerateKey( max, min);
            RSAEncryption.SetServerKeys(_publicKey, _computedPrivateKey);
        }

        public void StartServer()
        {
            string  ipAddress;
            int port;
            port = RSAEncryption.getPort();
            ipAddress = RSAEncryption.GetServerIP();
            Thread t = new Thread(() => StartServer(ipAddress, port));
            t.Start();
            RSAEncryption.SetOverviewMessage(message);
        }

        private void StartServer(string ipAddress, int port)
        {
            IPAddress ip;
            ASCIIEncoding ascii = new ASCIIEncoding();
            bool res = IPAddress.TryParse(ipAddress, out ip);
            if (!res)
                ip = IPAddress.Loopback;
            if (port < 0 || port > 7000)
                port = 6969;
            TcpListener myListener = new TcpListener(ip, port);

            myListener.Start();

            Socket s = myListener.AcceptSocket();

            s.Send(ascii.GetBytes(_publicKey.ToString()));

            byte[] b = new byte[10000];

            int i = s.Receive(b);
            for (int k = 0; k < i; k++)
                message += Convert.ToChar(b[k]);


            s.Close();
            myListener.Stop();

        }

    }
}
