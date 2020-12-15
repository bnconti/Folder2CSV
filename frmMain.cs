using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using CsvHelper;

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
            estado.Text = "Seleccionando carpeta...";
            chkArchivos.Items.Clear();

            folderBrowserDialog.ShowDialog();

            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                linklblCarpeta.Text = folderBrowserDialog.SelectedPath;
                linklblCarpeta.Enabled = true;

                string[] archivos = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);

                for (int i = 0; i < archivos.Length; i++)
                {
                    string ext = (archivos[i].Split('.')).Last();

                    if (ext == "xls")
                    {
                        string nombreArchivo = (archivos[i].Split('\\')).Last();
                        chkArchivos.Items.Add(nombreArchivo, true);
                    }
                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            estado.Text = "Procesando...";
            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                Excel.Application xlApp = new Excel.Application();

                foreach (var archivo in chkArchivos.CheckedItems)
                {
                    string rutaCompleta = folderBrowserDialog.SelectedPath + "\\" + archivo.ToString();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(rutaCompleta);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    string rutaCSV = getRutaCSV(archivo.ToString());
                    Console.WriteLine(rutaCSV);

                    var writer = new StreamWriter(rutaCSV);
                    var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture);

                    csv.Configuration.Delimiter = ";";
                    // csv.Configuration.HasHeaderRecord = true;

                    int i, j;
                    i = 1;

                    while (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                    {
                        j = 1;
                        while (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            string campo = xlRange.Cells[i, j].Value.ToString().Trim().ToUpper();
                            csv.WriteField(campo);
                            j += 1;
                        } 
                        csv.NextRecord();
                        i += 1;
                    } 
                    csv.Flush();
                    csv.Dispose();
                }
                estado.Text = "Conversión finalizada";
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

        private string getRutaCSV(string rutaArchivo)
        {
            string nombreArchivo = ((rutaArchivo.Split('\\').Last()).Split('.')).First();
            return folderBrowserDialog.SelectedPath.ToString() + "\\" + nombreArchivo + ".csv";
        }
    }
}
