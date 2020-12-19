
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
            this.chkArchivos = new System.Windows.Forms.CheckedListBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.version = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConvertirAsinc = new System.Windows.Forms.Button();
            this.dgArchivosAConvertir = new System.Windows.Forms.DataGridView();
            this.colArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescTiempo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArchivosAConvertir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(12, 162);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(162, 29);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir Sinc.";
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
            this.lblCarpeta.Location = new System.Drawing.Point(192, 9);
            this.lblCarpeta.Name = "lblCarpeta";
            this.lblCarpeta.Size = new System.Drawing.Size(113, 13);
            this.lblCarpeta.TabIndex = 5;
            this.lblCarpeta.Text = "Carpeta seleccionada:";
            // 
            // linklblCarpeta
            // 
            this.linklblCarpeta.AutoSize = true;
            this.linklblCarpeta.Enabled = false;
            this.linklblCarpeta.Location = new System.Drawing.Point(192, 28);
            this.linklblCarpeta.Name = "linklblCarpeta";
            this.linklblCarpeta.Size = new System.Drawing.Size(47, 13);
            this.linklblCarpeta.TabIndex = 6;
            this.linklblCarpeta.TabStop = true;
            this.linklblCarpeta.Text = "Ninguna";
            this.linklblCarpeta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCarpeta_LinkClicked);
            // 
            // chkArchivos
            // 
            this.chkArchivos.FormattingEnabled = true;
            this.chkArchivos.HorizontalScrollbar = true;
            this.chkArchivos.Location = new System.Drawing.Point(12, 47);
            this.chkArchivos.Name = "chkArchivos";
            this.chkArchivos.Size = new System.Drawing.Size(433, 109);
            this.chkArchivos.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estado,
            this.version});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(458, 22);
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
            this.version.Size = new System.Drawing.Size(443, 17);
            this.version.Spring = true;
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConvertirAsinc
            // 
            this.btnConvertirAsinc.Location = new System.Drawing.Point(283, 162);
            this.btnConvertirAsinc.Name = "btnConvertirAsinc";
            this.btnConvertirAsinc.Size = new System.Drawing.Size(162, 29);
            this.btnConvertirAsinc.TabIndex = 9;
            this.btnConvertirAsinc.Text = "Convertir Asinc.";
            this.btnConvertirAsinc.UseVisualStyleBackColor = true;
            this.btnConvertirAsinc.Click += new System.EventHandler(this.btnConvertirAsinc_Click);
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
            this.colTiempo});
            this.dgArchivosAConvertir.Location = new System.Drawing.Point(13, 205);
            this.dgArchivosAConvertir.Name = "dgArchivosAConvertir";
            this.dgArchivosAConvertir.ReadOnly = true;
            this.dgArchivosAConvertir.RowHeadersVisible = false;
            this.dgArchivosAConvertir.Size = new System.Drawing.Size(431, 115);
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
            // colTiempo
            // 
            this.colTiempo.HeaderText = "Tiempo";
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            this.colTiempo.Width = 67;
            // 
            // lblDescTiempo
            // 
            this.lblDescTiempo.AutoSize = true;
            this.lblDescTiempo.Location = new System.Drawing.Point(12, 330);
            this.lblDescTiempo.Name = "lblDescTiempo";
            this.lblDescTiempo.Size = new System.Drawing.Size(68, 13);
            this.lblDescTiempo.TabIndex = 11;
            this.lblDescTiempo.Text = "Tiempo total:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(86, 330);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 383);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblDescTiempo);
            this.Controls.Add(this.dgArchivosAConvertir);
            this.Controls.Add(this.btnConvertirAsinc);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.chkArchivos);
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
        private System.Windows.Forms.CheckedListBox chkArchivos;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel version;
        private System.Windows.Forms.ToolStripStatusLabel estado;
        private System.Windows.Forms.Button btnConvertirAsinc;
        private System.Windows.Forms.DataGridView dgArchivosAConvertir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.Label lblDescTiempo;
        private System.Windows.Forms.Label lblTiempo;
    }
}

