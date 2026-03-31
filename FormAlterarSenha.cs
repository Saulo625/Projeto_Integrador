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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Botao Confirmar salvar a nova senha e retorna para a tela de Login
        {
            Close(); //responsavel por fechar a tela atual
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Botao que retorna para a tela de login (porem sem alteracoes feitas)
        {
            Close(); //Responsavel por fechar a tela 
        }

    }
}
