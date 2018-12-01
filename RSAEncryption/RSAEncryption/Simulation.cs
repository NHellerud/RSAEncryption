using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Simulation
    {
        PrimeNumber primeNumber;
        public Client client;
        public Server server;
        Message[] messages;

        private int _mnum = 0;

        public Simulation()
        {
            client = new Client();
            server = new Server();
            primeNumber = new PrimeNumber();
            
        }

        public void SetValues(int max, int min)
        {
            client.SetData( max, min);
            server.SetData( max, min);
        }

        public Message Start()
        {
            messages = new Message[10];
            Thread sThread = server.StartServer();
            Thread cThread = client.StartClient();
            sThread.Join();
            cThread.Join();
            messages[0] = server.Messages[0];
            messages[1] = client.Messages[0];
            messages[2] = client.Messages[1];
            messages[3] = client.Messages[2];
            messages[4] = server.Messages[1];
            messages[5] = server.Messages[2];
            _mnum = 0;
            return messages[_mnum];
        }

        public Message NextMessage()
        {
            if (_mnum == 5)
                return messages[_mnum];
            _mnum++;
            return messages[_mnum];
        }

        public Message PrevMessage()
        {
            if (_mnum == 0)
                return messages[_mnum];
            _mnum--;
            return messages[_mnum];
        }


    }
}
