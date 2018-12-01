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
            simulation.SetValues(Int32.Parse(MaxKeyValueTextBox.Text), Int32.Parse(MinKeyValueTextBox.Text));
            OverviewClientPubKeyTextBox.Text = simulation.client.PublicKey.ToString();
            OverviewClientPrivKeyTextBox.Text = simulation.client.PrivateKey.ToString();
            OverviewServerPubKeyTextBox.Text = simulation.server.PublicKey.ToString();
            OverviewServerPrivKeyTextBox.Text = simulation.server.PrivateKey.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            simulation.client.IPAddr = NetworkServerTextBox.Text;
            simulation.client.Port = Int32.Parse(NetworkPortTextBox.Text);
            simulation.client.Message = ValuesMessageTextBox.Text;
            simulation.server.IPAddr = NetworkServerTextBox.Text;
            simulation.server.Port = Int32.Parse(NetworkPortTextBox.Text);
            Message  m = simulation.Start();
            OverviewFromTextBox.Text = m.FromIP;
            OverviewToTextBox.Text = m.ToIP;
            OverviewMessageTextBox.Text = m.Text;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message m = simulation.NextMessage();
            OverviewFromTextBox.Text = m.FromIP;
            OverviewToTextBox.Text = m.ToIP;
            OverviewMessageTextBox.Text = m.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Message m = simulation.PrevMessage();
            OverviewFromTextBox.Text = m.FromIP;
            OverviewToTextBox.Text = m.ToIP;
            OverviewMessageTextBox.Text = m.Text;
        }
    }
}
