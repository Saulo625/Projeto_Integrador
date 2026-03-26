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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form10 HistoricodEventos = new Form10();
            HistoricodEventos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 UsodSistema = new Form11();
            UsodSistema.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
