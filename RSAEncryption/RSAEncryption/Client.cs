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
        int ServerPublicKey;

        public void SetData( int max, int min)
        {
            GenerateKey( max, min);
            RSAEncryption.SetClientKeys(_publicKey, _computedPrivateKey);
        }

        public void StartClient()
        {
            string message, ipAddress;
            int port;
            port = RSAEncryption.getPort();
            message = RSAEncryption.GetMessage();
            ipAddress = RSAEncryption.GetServerIP();
            Thread t = new Thread(() => StartClient(ipAddress, port, message));
            t.Start();
            RSAEncryption.SetOverviewFrom(ServerPublicKey.ToString());
        }
        private void StartClient(string ipAddress, int port, string message)
        {

            TcpClient tcpclient = new TcpClient();
            IPAddress ip;
            if (!IPAddress.TryParse(ipAddress, out ip))
                ip = IPAddress.Loopback;

            if (port < 0 || port > 7000)
                port = 6969;

            tcpclient.Connect(ip, port);

            Stream stm = tcpclient.GetStream();

           
            string temp = "";
            byte[] b = new byte[100];
            int i = stm.Read(b, 0, 100);

            for (int k = 0; k < i; k++)
                temp += Convert.ToChar(b[k]);
            ServerPublicKey = Int32.Parse(temp);

            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] messageBytes = ascii.GetBytes(message);
            stm.Write(messageBytes, 0, messageBytes.Length);

            tcpclient.Close();
        }

    }
}
