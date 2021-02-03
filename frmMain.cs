using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

// Para escribir el CSV
using CsvHelper;

// Para leer el Excel
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Folder2CSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            version.Text = Application.ProductVersion;
            cmbDelimitador.SelectedIndex = 0;
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            archivosXLS.Items.Clear();
            
            folderBrowserDialog.ShowDialog();

            bool carpetaExiste = System.IO.Directory.Exists(folderBrowserDialog.SelectedPath);
            if (carpetaExiste)
            {
                actualizarLabelCarpeta();

                string[] archivos = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);
                cargarArchivosXLS(archivos);
            }
        }

        private void actualizarLabelCarpeta()
        {
            linklblCarpeta.Text = folderBrowserDialog.SelectedPath;
            linklblCarpeta.Enabled = true;
        }
        
        private void linklblCarpeta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", linklblCarpeta.Text);
        }

        private void cargarArchivosXLS(string[] archivos)
        {
            for (int i = 0; i < archivos.Length; i++)
            {
                FileInfo fi = new FileInfo(archivos[i]);
                string ext = fi.Extension;
                if (ext == ".xls" || ext == ".xlsx" )
                {
                    string nombreArchivo = fi.Name;
                    archivosXLS.Items.Add(nombreArchivo, true);
                }
            }
        }

        private void cargarDataGridArchivos()
        {
            foreach (var archivo in archivosXLS.CheckedItems)
            {
                var i  = dgArchivosAConvertir.Rows.Count;
                dgArchivosAConvertir.Rows.Insert(i, archivo.ToString(), "Pendiente");
                dgArchivosAConvertir.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                dgArchivosAConvertir.Rows.Clear();
                Cursor.Current = Cursors.WaitCursor;
                
                int totalArchivos = archivosXLS.CheckedItems.Count;

                cargarDataGridArchivos();
                Application.DoEvents();

                for (int indice = 0; indice < totalArchivos; indice++)
                {
                    Convertir(indice);
                }
 
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("¡No seleccionaste una carpeta!", "Algo salió mal", MessageBoxButtons.YesNo);
            }
        }

        private void Convertir(int indice)
        {
            ActualizarDataGrid(indice, "Convirtiendo...", Color.SteelBlue);
            
            string nombreArchExcel = archivosXLS.Items[indice].ToString();
            string rutaCompleta = folderBrowserDialog.SelectedPath + "\\" + nombreArchExcel;
            string rutaCSV = GenerarRutaCSV(nombreArchExcel);
            var writer = new StreamWriter(rutaCSV);
            var csv = new CsvWriter(writer);
            csv.Configuration.Delimiter = ";";

            HSSFWorkbook libro;

            using (var stream = new FileStream(rutaCompleta, FileMode.Open))
            {
                stream.Position = 0;
                libro = new HSSFWorkbook(stream);

                ISheet hoja = libro.GetSheetAt(0);

                int i = 0;

                while (i <= hoja.LastRowNum && hoja.GetRow(i) != null)
                {
                    var fila = hoja.GetRow(i);

                    for (int j = 0; j < fila.Cells.Count; j++)
                    {
                        string campo;
                        if (fila.GetCell(j) != null)
                        {
                            byte[] bytes = Encoding.Default.GetBytes(fila.GetCell(j).ToString());
                            campo = Encoding.UTF8.GetString(bytes).Trim().ToUpper();
                        }
                        else
                        {
                            campo = "";
                        }

                        csv.WriteField(campo);
                    }

                    dgArchivosAConvertir.Rows[indice].Cells[2].Value = i + "/" + hoja.LastRowNum;
                    i += 1;

                    csv.NextRecord();
                    Application.DoEvents();
                }
            }

            csv.Dispose();

            ActualizarDataGrid(indice, "Convertido", Color.LightGreen);
        }

        private void ActualizarDataGrid(int indice, string msj, Color color)
        {
            dgArchivosAConvertir.Rows[indice].Cells[1].Value = msj;
            dgArchivosAConvertir.Rows[indice].DefaultCellStyle.BackColor = color;
        }
        
        private string GenerarRutaCSV(string rutaArchivo)
        {
            FileInfo fi = new FileInfo(rutaArchivo);
            string nombreArchivo = fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
            return folderBrowserDialog.SelectedPath.ToString() + "\\" + nombreArchivo + ".csv";
        }
    }
}
