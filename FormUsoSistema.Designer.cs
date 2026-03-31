namespace Projeto_Integrador
{
    partial class Form11
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
            this.btnFiltrarPeriodo = new System.Windows.Forms.Button();
            this.lstUsoSistema = new System.Windows.Forms.ListBox();
            this.lblUsoSistema = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrarPeriodo
            // 
            this.btnFiltrarPeriodo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPeriodo.Location = new System.Drawing.Point(300, 334);
            this.btnFiltrarPeriodo.Name = "btnFiltrarPeriodo";
            this.btnFiltrarPeriodo.Size = new System.Drawing.Size(155, 50);
            this.btnFiltrarPeriodo.TabIndex = 5;
            this.btnFiltrarPeriodo.Text = "Filtrar por periodo";
            this.btnFiltrarPeriodo.UseVisualStyleBackColor = true;
            this.btnFiltrarPeriodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstUsoSistema
            // 
            this.lstUsoSistema.FormattingEnabled = true;
            this.lstUsoSistema.Location = new System.Drawing.Point(69, 127);
            this.lstUsoSistema.Name = "lstUsoSistema";
            this.lstUsoSistema.Size = new System.Drawing.Size(625, 160);
            this.lstUsoSistema.TabIndex = 4;
            // 
            // lblUsoSistema
            // 
            this.lblUsoSistema.AutoSize = true;
            this.lblUsoSistema.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsoSistema.Location = new System.Drawing.Point(257, 40);
            this.lblUsoSistema.Name = "lblUsoSistema";
            this.lblUsoSistema.Size = new System.Drawing.Size(246, 38);
            this.lblUsoSistema.TabIndex = 3;
            this.lblUsoSistema.Text = "Uso do sistema";
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbVoltar.Image = global::Projeto_Integrador.Properties.Resources.Blue_Green_Red_and_Pink_Playful_Creative_Studio_Logo__5_;
            this.pbVoltar.Location = new System.Drawing.Point(-3, -5);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(81, 67);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoltar.TabIndex = 47;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.btnFiltrarPeriodo);
            this.Controls.Add(this.lstUsoSistema);
            this.Controls.Add(this.lblUsoSistema);
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrarPeriodo;
        private System.Windows.Forms.ListBox lstUsoSistema;
        private System.Windows.Forms.Label lblUsoSistema;
        private System.Windows.Forms.PictureBox pbVoltar;
    }
}