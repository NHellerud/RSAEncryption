using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
     
        public static void SetClientKeys(int PublicKey, int PrivateKey)
        {
            OverviewClientPubKeyTextBox.Text = PublicKey.ToString();
            OverviewClientPrivKeyTextBox.Text = PrivateKey.ToString();
        }

        public static void SetServerKeys(int PublicKey, int PrivateKey)
        {
            OverviewServerPubKeyTextBox.Text = PublicKey.ToString();
            OverviewServerPrivKeyTextBox.Text = PrivateKey.ToString();
        }

        public static int getPort()
        {
            int port;
            if(!Int32.TryParse(NetworkPortTextBox.Text, out port))
            {
                return 6969;
            }
            return port;
        }

        public static string GetClientIP()
        {
            return NetworkClientTextBox.Text;
        }

        public static string GetServerIP()
        {
            return NetworkServerTextBox.Text;
        }

        public static string GetMessage()
        {
            return ValuesMessageTextBox.Text;
        }

        public static void SetOverviewTo(string s)
        {
            OverviewToTextBox.Text = s;
        }

        public static void SetOverviewFrom(string s)
        {
            OverviewFromTextBox.Text = s;
        }

        public static void SetOverviewMessage(string s)
        {
            OverviewMessageTextBox.Text = s;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            simulation.Start();
        }
    }
}
