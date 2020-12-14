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
            folderBrowserDialog.ShowDialog();
            MessageBox.Show("Seleccionaste la carpeta " + folderBrowserDialog.SelectedPath, "Mensaje importante", MessageBoxButtons.OK);

            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                linklblCarpeta.Text = folderBrowserDialog.SelectedPath;
                linklblCarpeta.Enabled = true;

            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                string[] archivos = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);

                foreach (string archivo in archivos)
                {
                    // MessageBox.Show(archivo, "Ventanita", MessageBoxButtons.OK);
                }
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
