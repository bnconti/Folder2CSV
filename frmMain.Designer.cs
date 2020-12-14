
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.lblCarpeta = new System.Windows.Forms.Label();
            this.linklblCarpeta = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(12, 220);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(230, 29);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar archivos";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 501);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(458, 22);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(12, 12);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(230, 29);
            this.btnSeleccionarCarpeta.TabIndex = 4;
            this.btnSeleccionarCarpeta.Text = "Seleccionar carpeta";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // lblCarpeta
            // 
            this.lblCarpeta.AutoSize = true;
            this.lblCarpeta.Location = new System.Drawing.Point(258, 9);
            this.lblCarpeta.Name = "lblCarpeta";
            this.lblCarpeta.Size = new System.Drawing.Size(113, 13);
            this.lblCarpeta.TabIndex = 5;
            this.lblCarpeta.Text = "Carpeta seleccionada:";
            // 
            // linklblCarpeta
            // 
            this.linklblCarpeta.AutoSize = true;
            this.linklblCarpeta.Enabled = false;
            this.linklblCarpeta.Location = new System.Drawing.Point(258, 28);
            this.linklblCarpeta.Name = "linklblCarpeta";
            this.linklblCarpeta.Size = new System.Drawing.Size(47, 13);
            this.linklblCarpeta.TabIndex = 6;
            this.linklblCarpeta.TabStop = true;
            this.linklblCarpeta.Text = "Ninguna";
            this.linklblCarpeta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCarpeta_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 523);
            this.Controls.Add(this.linklblCarpeta);
            this.Controls.Add(this.lblCarpeta);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConvertir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Folder2CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSeleccionarCarpeta;
        private System.Windows.Forms.Label lblCarpeta;
        private System.Windows.Forms.LinkLabel linklblCarpeta;
    }
}

