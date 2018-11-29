using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keprendezo
{
    public partial class Keprendezo : Form
    {
        public Keprendezo()
        {
            InitializeComponent();
        }

        private void buttonCel_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                textBoxCel.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void buttonForras_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxForras.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonRendezes_Click(object sender, EventArgs e)
        {

        }
    }
}
