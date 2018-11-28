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
        public RSAEncryption()
        {
            InitializeComponent();
            OverviewPanel.BringToFront();
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
    }
}
