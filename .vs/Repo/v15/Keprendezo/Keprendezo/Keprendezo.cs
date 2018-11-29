using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Keprendezo
{
    public partial class Keprendezo : Form
    {
        public Keprendezo()
        {
            InitializeComponent();
        }
        //Megadjuk azt a mappát amelyből másolni szeretnénk
        private void buttonCel_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCel.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //Megadjuk azt a mappát amelybe másolni szeretnénk
        private void buttonForras_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxForras.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //Átmásoljuk a fáljokat a forrásmappából a célmappába
        private void buttonRendezes_Click(object sender, EventArgs e)
        {
            string fileNev = "Adatbazis.png";
            string forrasPath = textBoxForras.Text;
            string celPath = textBoxCel.Text;

            string sourceFile = Path.Combine(forrasPath, fileNev);
            string destFile = Path.Combine(celPath, fileNev);

            //Létrehozza a mappát ha még nem létezik
            if (!Directory.Exists(celPath))
            {
                Directory.CreateDirectory(celPath);
            }

            //Valami 
            //Felülírja az azonos nevő fáljt
            //File.Copy(sourceFile, destFile, true);

            if (Directory.Exists(forrasPath))
            {
                string[] files = Directory.GetFiles(forrasPath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileNev = Path.GetFileName(s);
                    destFile = Path.Combine(celPath, fileNev);
                    File.Copy(s, destFile, true);
                }
            }
        }
    }
}
