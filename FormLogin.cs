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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Este botao Esqueci minha senha leva o funcionario para a tela de alterar senha
        {
            Form4 Alterarsenha = new Form4();
            Alterarsenha.ShowDialog(); // Abre o FormAlterarSenha
        }

        private void button1_Click(object sender, EventArgs e)  //Este botao Entrar leva o funcionario para a tela de Menu
        {
            Form5 menu = new Form5();
            menu.ShowDialog(); //abre a tela de menu
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Fecha esse FromLogin retornando para a tela de cadastro
        {
            Close(); // responsalvel por fehar essa tela 
        }

    }
}
