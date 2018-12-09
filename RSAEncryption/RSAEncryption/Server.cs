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

        private string _message = "";
        private byte[] _encryptedData;

        public byte[] EncryptedData
        {
            get
            {
                return _encryptedData;
            }
        }

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

            IPEndPoint remoteEndPoint = s.RemoteEndPoint as IPEndPoint;
            string clientIP = remoteEndPoint.Address.ToString();

            Messages[0] = new Message();
            Messages[0].Text = _publicKey.ToString() + " " + _coPrimeNumber.ToString();
            Messages[0].FromIP = ip.ToString();
            Messages[0].ToIP = clientIP + " Client";

            s.Send(ascii.GetBytes(_publicKey.ToString()));
            s.Send(ascii.GetBytes(_coPrimeNumber.ToString()));


            byte[] b = new byte[10000];

            int i = s.Receive(b);

            byte[] transfer = new byte[i];
            for (int k = 0; k < i; k++)
                transfer[k] = b[k];
            _encryptedData = transfer;

            string temp = "";
            Byte[] bytes = new Byte[4];
            for (int k = 0; k < i; k += 4)
            {

                temp += BitConverter.ToInt32(b, k).ToString() + " ";
            }

            Messages[1] = new Message();
            Messages[1].Text = temp;
            Messages[1].FromIP = ip.ToString() + " Client";
            Messages[1].ToIP = clientIP;

            _message = RSAEncryptor.Decrypt(b, _publicKey, _computedPrivateKey, i);

            
            Messages[2] = new Message();
            Messages[2].Text = _message;
            Messages[2].FromIP = ip.ToString() + " Client";
            Messages[2].ToIP = clientIP;

            s.Close();
            myListener.Stop();

        }

    }
}
