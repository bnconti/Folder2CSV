
namespace Folder2CSV
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnConvertir = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.lblCarpeta = new System.Windows.Forms.Label();
            this.linklblCarpeta = new System.Windows.Forms.LinkLabel();
            this.archivosXLS = new System.Windows.Forms.CheckedListBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.version = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgArchivosAConvertir = new System.Windows.Forms.DataGridView();
            this.colArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDelimitador = new System.Windows.Forms.Label();
            this.cmbDelimitador = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArchivosAConvertir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(283, 283);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(162, 29);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(12, 12);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(162, 29);
            this.btnSeleccionarCarpeta.TabIndex = 4;
            this.btnSeleccionarCarpeta.Text = "Seleccionar carpeta";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // lblCarpeta
            // 
            this.lblCarpeta.AutoSize = true;
            this.lblCarpeta.Location = new System.Drawing.Point(180, 12);
            this.lblCarpeta.Name = "lblCarpeta";
            this.lblCarpeta.Size = new System.Drawing.Size(113, 13);
            this.lblCarpeta.TabIndex = 5;
            this.lblCarpeta.Text = "Carpeta seleccionada:";
            // 
            // linklblCarpeta
            // 
            this.linklblCarpeta.AutoSize = true;
            this.linklblCarpeta.Enabled = false;
            this.linklblCarpeta.Location = new System.Drawing.Point(180, 28);
            this.linklblCarpeta.Name = "linklblCarpeta";
            this.linklblCarpeta.Size = new System.Drawing.Size(47, 13);
            this.linklblCarpeta.TabIndex = 6;
            this.linklblCarpeta.TabStop = true;
            this.linklblCarpeta.Text = "Ninguna";
            this.linklblCarpeta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCarpeta_LinkClicked);
            // 
            // archivosXLS
            // 
            this.archivosXLS.FormattingEnabled = true;
            this.archivosXLS.HorizontalScrollbar = true;
            this.archivosXLS.Location = new System.Drawing.Point(12, 47);
            this.archivosXLS.Name = "archivosXLS";
            this.archivosXLS.Size = new System.Drawing.Size(433, 109);
            this.archivosXLS.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estado,
            this.version});
            this.statusStrip.Location = new System.Drawing.Point(0, 319);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(459, 22);
            this.statusStrip.TabIndex = 8;
            // 
            // estado
            // 
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(0, 17);
            // 
            // version
            // 
            this.version.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(444, 17);
            this.version.Spring = true;
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgArchivosAConvertir
            // 
            this.dgArchivosAConvertir.AllowUserToAddRows = false;
            this.dgArchivosAConvertir.AllowUserToDeleteRows = false;
            this.dgArchivosAConvertir.AllowUserToResizeColumns = false;
            this.dgArchivosAConvertir.AllowUserToResizeRows = false;
            this.dgArchivosAConvertir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgArchivosAConvertir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArchivosAConvertir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArchivo,
            this.colEstado,
            this.Total});
            this.dgArchivosAConvertir.Location = new System.Drawing.Point(12, 162);
            this.dgArchivosAConvertir.Name = "dgArchivosAConvertir";
            this.dgArchivosAConvertir.ReadOnly = true;
            this.dgArchivosAConvertir.RowHeadersVisible = false;
            this.dgArchivosAConvertir.Size = new System.Drawing.Size(434, 115);
            this.dgArchivosAConvertir.TabIndex = 10;
            // 
            // colArchivo
            // 
            this.colArchivo.HeaderText = "Archivo";
            this.colArchivo.Name = "colArchivo";
            this.colArchivo.ReadOnly = true;
            this.colArchivo.Width = 68;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 65;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // lblDelimitador
            // 
            this.lblDelimitador.AutoSize = true;
            this.lblDelimitador.Location = new System.Drawing.Point(16, 291);
            this.lblDelimitador.Name = "lblDelimitador";
            this.lblDelimitador.Size = new System.Drawing.Size(62, 13);
            this.lblDelimitador.TabIndex = 12;
            this.lblDelimitador.Text = "Delimitador:";
            // 
            // cmbDelimitador
            // 
            this.cmbDelimitador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelimitador.FormattingEnabled = true;
            this.cmbDelimitador.Items.AddRange(new object[] {
            "Punto y coma",
            "Coma"});
            this.cmbDelimitador.Location = new System.Drawing.Point(84, 288);
            this.cmbDelimitador.Name = "cmbDelimitador";
            this.cmbDelimitador.Size = new System.Drawing.Size(90, 21);
            this.cmbDelimitador.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 341);
            this.Controls.Add(this.cmbDelimitador);
            this.Controls.Add(this.lblDelimitador);
            this.Controls.Add(this.dgArchivosAConvertir);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.archivosXLS);
            this.Controls.Add(this.linklblCarpeta);
            this.Controls.Add(this.lblCarpeta);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.btnConvertir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Folder2CSV";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArchivosAConvertir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSeleccionarCarpeta;
        private System.Windows.Forms.Label lblCarpeta;
        private System.Windows.Forms.LinkLabel linklblCarpeta;
        private System.Windows.Forms.CheckedListBox archivosXLS;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel version;
        private System.Windows.Forms.ToolStripStatusLabel estado;
        private System.Windows.Forms.DataGridView dgArchivosAConvertir;
        private System.Windows.Forms.Label lblDelimitador;
        private System.Windows.Forms.ComboBox cmbDelimitador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

