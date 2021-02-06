using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

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

        private void BtnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            archivosXLS.Items.Clear();

            folderBrowserDialog.ShowDialog();

            bool carpetaExiste = System.IO.Directory.Exists(folderBrowserDialog.SelectedPath);

            if (carpetaExiste)
            {
                ActualizarLabelCarpeta();
                string[] archivos = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);
                CargarArchivosXLS(archivos);
            }
        }

        private void ActualizarLabelCarpeta()
        {
            linklblCarpeta.Text = folderBrowserDialog.SelectedPath;
            linklblCarpeta.Enabled = true;
        }

        private void LinklblCarpeta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", linklblCarpeta.Text);
        }

        private void CargarArchivosXLS(string[] archivos)
        {
            for (int i = 0; i < archivos.Length; i++)
            {
                FileInfo fi = new FileInfo(archivos[i]);
                string ext = fi.Extension;
                if (ext == ".xls" || ext == ".xlsx")
                {
                    string nombreArchivo = fi.Name;
                    archivosXLS.Items.Add(nombreArchivo, true);
                }
            }
        }

        private void CargarDataGridArchivos()
        {
            foreach (var archivo in archivosXLS.CheckedItems)
            {
                int i = dgArchivosAConvertir.Rows.Count;
                string nombreArch = archivo.ToString().Length > 30 ? archivo.ToString().Substring(0, 30) + "..." : archivo.ToString();
                dgArchivosAConvertir.Rows.Insert(i, nombreArch, "Pendiente");
                dgArchivosAConvertir.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                dgArchivosAConvertir.Rows.Clear();
                Cursor.Current = Cursors.WaitCursor;

                int totalArchivos = archivosXLS.CheckedItems.Count;
                // si no marco nada o no hay ningun archivo seleccionado...

                CargarDataGridArchivos();
                Application.DoEvents();

                for (int nroArch = 0; nroArch < totalArchivos; nroArch++)
                {
                    ActualizarDataGrid(nroArch, "Convirtiendo...", Color.SteelBlue);
                    Convertir(nroArch);
                    ActualizarDataGrid(nroArch, "Terminado", Color.LightGreen);
                }

                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("¡No seleccionaste una carpeta!", "Algo salió mal", MessageBoxButtons.YesNo);
            }
        }

        private void Convertir(int nroArch)
        {
            string nombreExcel = archivosXLS.Items[nroArch].ToString();
            string rutaExcel = folderBrowserDialog.SelectedPath + "\\" + nombreExcel;
            string rutaCSV = GenerarRutaCSV(nombreExcel);

            // TODO: si el excel está abierto tira excepcion
            using (var writer = new StreamWriter(rutaCSV))
            using (var stream = new FileStream(rutaExcel, FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                HSSFWorkbook libro = new HSSFWorkbook(stream);
                ISheet hoja = libro.GetSheetAt(0);

                foreach (IRow fila in hoja)
                {
                    foreach (ICell celda in fila)
                    {
                        if (celda.ColumnIndex == fila.LastCellNum - 1)
                        {
                            writer.WriteLine(GetValorCelda(celda));
                        } else
                        {
                            writer.Write(GetValorCelda(celda) + ";");
                        }
                    }

                    dgArchivosAConvertir.Rows[nroArch].Cells[2].Value = fila.RowNum + "/" + hoja.LastRowNum;
                    Application.DoEvents();
                }
            }

        }

        private String GetValorCelda(ICell celda)
        {
            string valorCelda;
            switch (celda.CellType)
            {
                case CellType.Numeric:
                    if (DateUtil.IsCellDateFormatted(celda))
                    {
                        valorCelda = celda.DateCellValue.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        valorCelda = celda.NumericCellValue.ToString().Trim().ToUpper();
                    }
                    break;

                case CellType.String:
                    valorCelda = celda.StringCellValue.Trim().ToUpper();
                    break;

                case CellType.Boolean:
                    valorCelda = celda.BooleanCellValue ? "1" : "0";
                    break;

                default:
                    valorCelda = "";
                    break;
            }

            return valorCelda;
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
