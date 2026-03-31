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
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  //Este botao Cadastrar leva o funcionario para a tela de cadastro
        {
            Form2 Cadastrofuncionario = new Form2();          
            Cadastrofuncionario.ShowDialog(); //Abre o FormCadastro
        }

        private void button1_Click(object sender, EventArgs e) //Este botao Entrar leva o funcionario para a tela de Login
        {
           Form3 entrar = new Form3();
            entrar.ShowDialog(); //Abre o FormLogin 
        }

       
    }
}
