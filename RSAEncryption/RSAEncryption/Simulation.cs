using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryption
{
    class Simulation
    {
        PrimeNumber primeNumber;
        Client client;
        Server server;

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

        public void Start()
        {
            server.StartServer();
            client.StartClient();

        }


    }
}
