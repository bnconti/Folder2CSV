
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.lblCarpeta = new System.Windows.Forms.Label();
            this.linklblCarpeta = new System.Windows.Forms.LinkLabel();
            this.chkArchivos = new System.Windows.Forms.CheckedListBox();
            this.estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(12, 162);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(162, 29);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.estado});
            this.statusBar.Location = new System.Drawing.Point(0, 208);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(458, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
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
            // estado
            // 
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 230);
            this.Controls.Add(this.chkArchivos);
            this.Controls.Add(this.linklblCarpeta);
            this.Controls.Add(this.lblCarpeta);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnConvertir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Folder2CSV";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSeleccionarCarpeta;
        private System.Windows.Forms.Label lblCarpeta;
        private System.Windows.Forms.LinkLabel linklblCarpeta;
        private System.Windows.Forms.CheckedListBox chkArchivos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel estado;
    }
}

