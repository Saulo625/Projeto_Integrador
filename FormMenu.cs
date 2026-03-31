using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void btnUsuarios_Click(object sender, EventArgs e) //O botao Administrar Usuario Abre o FormUsuarios
        {
            Form6 Usuario = new Form6();
            Usuario.ShowDialog();  
        }

        private void btnCapacetes_Click(object sender, EventArgs e) //O botao Administrar Capacetes Abre o FormCapacetes
        {
            Form7 Capacete = new Form7();
            Capacete.ShowDialog();
        }

        private void btnQRCodes_Click(object sender, EventArgs e) //O botao Administrar QR Codes Abre o FormQRCodes
        {
            Form8 QrCode = new Form8();
            QrCode.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e) //O botao Relatorios Abre o FormRelatorios
        {
            Form9 Relatorios = new Form9();
            Relatorios.ShowDialog();
        }
       
    }
}
