namespace Projeto_Integrador
{
    partial class Form12
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
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblFiltarPeriodo = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicial
            // 
            this.dtInicial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Location = new System.Drawing.Point(111, 138);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(296, 25);
            this.dtInicial.TabIndex = 0;
            this.dtInicial.Value = new System.DateTime(2026, 6, 22, 0, 0, 0, 0);
            // 
            // dtFinal
            // 
            this.dtFinal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Location = new System.Drawing.Point(111, 246);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(296, 25);
            this.dtFinal.TabIndex = 1;
            this.dtFinal.Value = new System.DateTime(2026, 6, 22, 0, 0, 0, 0);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(349, 355);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(116, 45);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.Location = new System.Drawing.Point(107, 108);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(97, 23);
            this.lblDataInicial.TabIndex = 3;
            this.lblDataInicial.Text = "Data inicial:";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(107, 210);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(85, 23);
            this.lblDataFinal.TabIndex = 4;
            this.lblDataFinal.Text = "Data final:";
            // 
            // lblFiltarPeriodo
            // 
            this.lblFiltarPeriodo.AutoSize = true;
            this.lblFiltarPeriodo.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltarPeriodo.Location = new System.Drawing.Point(260, 24);
            this.lblFiltarPeriodo.Name = "lblFiltarPeriodo";
            this.lblFiltarPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFiltarPeriodo.Size = new System.Drawing.Size(284, 38);
            this.lblFiltarPeriodo.TabIndex = 5;
            this.lblFiltarPeriodo.Text = "Filtrar por periodo";
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbVoltar.Image = global::Projeto_Integrador.Properties.Resources.Blue_Green_Red_and_Pink_Playful_Creative_Studio_Logo__5_;
            this.pbVoltar.Location = new System.Drawing.Point(0, -5);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(81, 67);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoltar.TabIndex = 46;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.lblFiltarPeriodo);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicial);
            this.Name = "Form12";
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblFiltarPeriodo;
        private System.Windows.Forms.PictureBox pbVoltar;
    }
}