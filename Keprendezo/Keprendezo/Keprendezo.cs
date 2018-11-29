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
        //Megadjuk azt a mappát amelyből másolni szeretnénk
        private void buttonCel_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                textBoxCel.Text = folderBrowserDialog2.SelectedPath;
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

            string sourceFile = System.IO.Path.Combine(forrasPath, fileNev);
            string destFile = System.IO.Path.Combine(celPath, fileNev);

            //Létrehozza a mappát ha még nem létezik
            if (!System.IO.Directory.Exists(celPath))
            {
                System.IO.Directory.CreateDirectory(celPath);
            }

            //Felülírja az azonos nevő fáljokat
            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(forrasPath))
            {
                string[] files = System.IO.Directory.GetFiles(forrasPath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileNev = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(celPath, fileNev);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
        }
    }
}
