namespace Projeto_Integrador
{
    partial class Form9
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
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.btnHistoricoEventos = new System.Windows.Forms.Button();
            this.btnUsoSistema = new System.Windows.Forms.Button();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorios.Location = new System.Drawing.Point(230, 33);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(340, 38);
            this.lblRelatorios.TabIndex = 0;
            this.lblRelatorios.Text = "Relatorios do sistema";
            // 
            // btnHistoricoEventos
            // 
            this.btnHistoricoEventos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoEventos.Location = new System.Drawing.Point(178, 122);
            this.btnHistoricoEventos.Name = "btnHistoricoEventos";
            this.btnHistoricoEventos.Size = new System.Drawing.Size(186, 48);
            this.btnHistoricoEventos.TabIndex = 1;
            this.btnHistoricoEventos.Text = "Historico de eventos ";
            this.btnHistoricoEventos.UseVisualStyleBackColor = true;
            this.btnHistoricoEventos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsoSistema
            // 
            this.btnUsoSistema.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsoSistema.Location = new System.Drawing.Point(178, 209);
            this.btnUsoSistema.Name = "btnUsoSistema";
            this.btnUsoSistema.Size = new System.Drawing.Size(186, 45);
            this.btnUsoSistema.TabIndex = 2;
            this.btnUsoSistema.Text = "Uso do sistema";
            this.btnUsoSistema.UseVisualStyleBackColor = true;
            this.btnUsoSistema.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbVoltar.Image = global::Projeto_Integrador.Properties.Resources.Blue_Green_Red_and_Pink_Playful_Creative_Studio_Logo__5_;
            this.pbVoltar.Location = new System.Drawing.Point(0, -7);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(81, 67);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoltar.TabIndex = 47;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 513);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.btnUsoSistema);
            this.Controls.Add(this.btnHistoricoEventos);
            this.Controls.Add(this.lblRelatorios);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Button btnHistoricoEventos;
        private System.Windows.Forms.Button btnUsoSistema;
        private System.Windows.Forms.PictureBox pbVoltar;
    }
}