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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e) //Botao que retorna para o FormUsoSistema
        {
            Close(); //responsavel por fechar a tela
        }

        private void button1_Click(object sender, EventArgs e) //O botao Filtrar filtra a informacao desejada e abre a mesma tela anteriror porem com os dados filtrados.
        {
            Form11 UsoFiltrado = new Form11();
            UsoFiltrado.ShowDialog();
        }
    }
}
