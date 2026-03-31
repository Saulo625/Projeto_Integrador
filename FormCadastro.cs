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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) //botao que leva para a tela de login
        {
            Form3 realizaLogin = new Form3();
            realizaLogin.ShowDialog(); //Abre o FormLogin
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //Fecha este FormCadastro, retornando para o FormAcesso
        {
            Close(); //Responsavel por fechar a tela 
        }

       
    }
}