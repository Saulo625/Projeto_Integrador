namespace Projeto_Integrador
{
    partial class Form5
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCapacetes = new System.Windows.Forms.Button();
            this.btnQRCodes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(332, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(96, 38);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(172, 100);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(193, 48);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Administrar usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCapacetes
            // 
            this.btnCapacetes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacetes.Location = new System.Drawing.Point(172, 172);
            this.btnCapacetes.Name = "btnCapacetes";
            this.btnCapacetes.Size = new System.Drawing.Size(193, 48);
            this.btnCapacetes.TabIndex = 2;
            this.btnCapacetes.Text = "Administrar capacetes";
            this.btnCapacetes.UseVisualStyleBackColor = true;
            this.btnCapacetes.Click += new System.EventHandler(this.btnCapacetes_Click);
            // 
            // btnQRCodes
            // 
            this.btnQRCodes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCodes.Location = new System.Drawing.Point(172, 247);
            this.btnQRCodes.Name = "btnQRCodes";
            this.btnQRCodes.Size = new System.Drawing.Size(193, 48);
            this.btnQRCodes.TabIndex = 3;
            this.btnQRCodes.Text = "Administrar  QR Codes";
            this.btnQRCodes.UseVisualStyleBackColor = true;
            this.btnQRCodes.Click += new System.EventHandler(this.btnQRCodes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Location = new System.Drawing.Point(172, 321);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(193, 48);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnQRCodes);
            this.Controls.Add(this.btnCapacetes);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblMenu);
            this.Name = "Form5";
            this.Text = "Form5";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCapacetes;
        private System.Windows.Forms.Button btnQRCodes;
        private System.Windows.Forms.Button btnRelatorios;
    }
}