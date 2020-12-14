using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder2CSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            chkArchivos.Items.Clear();

            folderBrowserDialog.ShowDialog();
            MessageBox.Show("Seleccionaste la carpeta " + folderBrowserDialog.SelectedPath, "Mensaje importante", MessageBoxButtons.OK);

            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                linklblCarpeta.Text = folderBrowserDialog.SelectedPath;
                linklblCarpeta.Enabled = true;

                string[] archivos = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);

                for (int i = 0; i < archivos.Length; i++)
                {
                    string ext = (archivos[i].Split('.')).Last();

                    if(ext == ".xls")
                    {
                        chkArchivos.Items.Add(archivos[i], true);
                    }
                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                
            }
            else
            {
                MessageBox.Show("¡No seleccionaste una carpeta!", "Algo salió mal", MessageBoxButtons.YesNo);
            }
        }

        private void linklblCarpeta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", linklblCarpeta.Text);
        }
    }
}
