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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //O botao filtrar por periodo leva para o FormFiltrarPeriodo
        {
            Form12 FiltrarPeriodo  = new Form12();
            FiltrarPeriodo.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e) //O botao voltar retorna para a tela anterior (Relatorios)
        {
            Close(); //Fecha a tela atual
        }
    }
}
