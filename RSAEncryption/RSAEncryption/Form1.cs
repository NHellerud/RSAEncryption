using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAEncryption
{
    public partial class RSAEncryption : Form
    {
        Simulation simulation;
        bool _keyGenerated = false;
        bool _messageSent = false;

        public RSAEncryption()
        {
            InitializeComponent();
            OverviewPanel.BringToFront();
            simulation = new Simulation();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            OverviewPanel.BringToFront();
        }

        private void EavesdropperButton_Click(object sender, EventArgs e)
        {
            EavesdropperPanel.BringToFront();
        }

        private void RSAEncryption_Load(object sender, EventArgs e)
        {

        }

        private void ValuesButton_Click(object sender, EventArgs e)
        {
            ValuesPanel.BringToFront();
        }

        private void NetworkButton_Click(object sender, EventArgs e)
        {
            NetworkPanel.BringToFront();
  
        }

        private void ValuesGenerateButton_Click(object sender, EventArgs e)
        {
            _keyGenerated = true;

            //Value verification
            int max, min;
            if (!Int32.TryParse(MaxKeyValueTextBox.Text, out max))
                max = 200;
    
            if (!Int32.TryParse(MinKeyValueTextBox.Text, out min))
                min = 10;

            if(max < min || max - min < 30)
            {
                max = 200;
                min = 10;
            }

            MaxKeyValueTextBox.Text = max.ToString();
            MinKeyValueTextBox.Text = min.ToString();

            //Set the keys
            simulation.SetValues(max, min);
            OverviewClientPubKeyTextBox.Text = simulation.client.PublicKey.ToString();
            OverviewClientPrivKeyTextBox.Text = simulation.client.PrivateKey.ToString();
            OverviewServerPubKeyTextBox.Text = simulation.server.PublicKey.ToString();
            OverviewServerPrivKeyTextBox.Text = simulation.server.PrivateKey.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!_keyGenerated)
                ValuesGenerateButton_Click(sender, e);

            _messageSent = true;
            //Value verification
            int port;
            string message;

            message = ValuesMessageTextBox.Text;

            if (message.Length == 0 || message.Length > 200)
            {
                message = "Test Message";
                ValuesMessageTextBox.Text = message;
            }

            if (!Int32.TryParse(NetworkPortTextBox.Text, out port))
                port = 6969;
            if (port > 65000 || port < 0)
                port = 6969;
            NetworkPortTextBox.Text = port.ToString();


            //Set values in server and client
            simulation.client.IPAddr = NetworkServerTextBox.Text;
            simulation.client.Port = port;
            simulation.client.Message = message;
            simulation.server.IPAddr = NetworkServerTextBox.Text;
            simulation.server.Port = port;

            //Set values in Overview panel
            OverviewClientIPTextBox.Text = simulation.client.IPAddr;
            OverviewClientPortTextBox.Text = simulation.client.Port.ToString();
            OverviewServerIPTextBox.Text = simulation.server.IPAddr;
            OverviewServerPortTextBox.Text = simulation.server.Port.ToString();

            Message m;
            if (ClientCheckBox.Checked && !ServerCheckBox.Checked)
                m = simulation.StartClient();
            if (!ClientCheckBox.Checked && ServerCheckBox.Checked)
                m = simulation.StartServer();
            else
                m = simulation.Start();
            OverviewFromTextBox.Text = m.FromIP;
            OverviewToTextBox.Text = m.ToIP;
            OverviewMessageTextBox.Text = m.Text;
          
        }

        
       

      

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_messageSent)
            {
                Message m = simulation.NextMessage();
                OverviewFromTextBox.Text = m.FromIP;
                OverviewToTextBox.Text = m.ToIP;
                OverviewMessageTextBox.Text = m.Text;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (_messageSent)
            {
                Message m = simulation.PrevMessage();
                OverviewFromTextBox.Text = m.FromIP;
                OverviewToTextBox.Text = m.ToIP;
                OverviewMessageTextBox.Text = m.Text;
            }
        }

        private void EavesdropperGoButton_Click(object sender, EventArgs e)
        {
            if (_messageSent)
            {
                Eavesdropper eavesdropper = new Eavesdropper();
                eavesdropper.Break(simulation.client.PublicKey, simulation.client.CoPrime, simulation.server.PublicKey, simulation.server.CoPrime);

                EavesdropperClientPublicKeyTextBox.Text = simulation.client.PublicKey.ToString();
                EavesdropperServerPublicKeyTextBox.Text = simulation.server.PublicKey.ToString();
                EavesdropperClientPrivateKeyTextBox.Text = eavesdropper.PrivateKeyClient.ToString();
                EavesdropperServerPrivateKeyTextBox.Text = eavesdropper.PrivateKeyServer.ToString();

                string message = RSAEncryptor.Decrypt(simulation.server.EncryptedData, simulation.server.PublicKey, eavesdropper.PrivateKeyServer, simulation.server.EncryptedData.Length);
                EavesdropperMessageTextBox.Text = message;
            }
        }
    }
}
