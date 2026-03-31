namespace Projeto_Integrador
{
    partial class Form4
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblaAlterarSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblConfirmeNovaSenha = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmeNovaSenha = new System.Windows.Forms.TextBox();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(332, 326);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 49);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblaAlterarSenha
            // 
            this.lblaAlterarSenha.AutoSize = true;
            this.lblaAlterarSenha.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaAlterarSenha.Location = new System.Drawing.Point(290, 20);
            this.lblaAlterarSenha.Name = "lblaAlterarSenha";
            this.lblaAlterarSenha.Size = new System.Drawing.Size(217, 38);
            this.lblaAlterarSenha.TabIndex = 1;
            this.lblaAlterarSenha.Text = "Alterar senha";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Location = new System.Drawing.Point(131, 102);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(183, 23);
            this.lblNovaSenha.TabIndex = 2;
            this.lblNovaSenha.Text = "Digite sua nova senha:";
            // 
            // lblConfirmeNovaSenha
            // 
            this.lblConfirmeNovaSenha.AutoSize = true;
            this.lblConfirmeNovaSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmeNovaSenha.Location = new System.Drawing.Point(131, 201);
            this.lblConfirmeNovaSenha.Name = "lblConfirmeNovaSenha";
            this.lblConfirmeNovaSenha.Size = new System.Drawing.Size(209, 23);
            this.lblConfirmeNovaSenha.TabIndex = 3;
            this.lblConfirmeNovaSenha.Text = "Confirme sua nova senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(120, 128);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(542, 26);
            this.txtNovaSenha.TabIndex = 4;
            // 
            // txtConfirmeNovaSenha
            // 
            this.txtConfirmeNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmeNovaSenha.Location = new System.Drawing.Point(120, 227);
            this.txtConfirmeNovaSenha.Name = "txtConfirmeNovaSenha";
            this.txtConfirmeNovaSenha.Size = new System.Drawing.Size(542, 26);
            this.txtConfirmeNovaSenha.TabIndex = 5;
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbVoltar.Image = global::Projeto_Integrador.Properties.Resources.Blue_Green_Red_and_Pink_Playful_Creative_Studio_Logo__5_;
            this.pbVoltar.Location = new System.Drawing.Point(-1, -9);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(81, 67);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVoltar.TabIndex = 47;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.txtConfirmeNovaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.lblConfirmeNovaSenha);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.lblaAlterarSenha);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "Form4";
            this.Text = "Form4";
          
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblaAlterarSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblConfirmeNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmeNovaSenha;
        private System.Windows.Forms.PictureBox pbVoltar;
    }
}