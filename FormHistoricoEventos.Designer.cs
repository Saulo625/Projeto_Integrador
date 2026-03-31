namespace Projeto_Integrador
{
    partial class Form10
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
            this.lblHistoricoEventos = new System.Windows.Forms.Label();
            this.lstHistoricoEventos = new System.Windows.Forms.ListBox();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistoricoEventos
            // 
            this.lblHistoricoEventos.AutoSize = true;
            this.lblHistoricoEventos.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoEventos.Location = new System.Drawing.Point(260, 30);
            this.lblHistoricoEventos.Name = "lblHistoricoEventos";
            this.lblHistoricoEventos.Size = new System.Drawing.Size(322, 38);
            this.lblHistoricoEventos.TabIndex = 0;
            this.lblHistoricoEventos.Text = "Historico de eventos";
            // 
            // lstHistoricoEventos
            // 
            this.lstHistoricoEventos.FormattingEnabled = true;
            this.lstHistoricoEventos.Location = new System.Drawing.Point(54, 88);
            this.lstHistoricoEventos.Name = "lstHistoricoEventos";
            this.lstHistoricoEventos.Size = new System.Drawing.Size(734, 368);
            this.lstHistoricoEventos.TabIndex = 46;
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbVoltar.Image = global::Projeto_Integrador.Properties.Resources.Blue_Green_Red_and_Pink_Playful_Creative_Studio_Logo__5_;
            this.pbVoltar.Location = new System.Drawing.Point(-1, -8);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(81, 67);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoltar.TabIndex = 47;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.lstHistoricoEventos);
            this.Controls.Add(this.lblHistoricoEventos);
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoricoEventos;
        private System.Windows.Forms.ListBox lstHistoricoEventos;
        private System.Windows.Forms.PictureBox pbVoltar;
    }
}