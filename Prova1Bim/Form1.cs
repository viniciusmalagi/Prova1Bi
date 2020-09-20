using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova1Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prod cadastro = new Prod();
            cadastro.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Deseja encerrar o sistema? ", "Mensage do sistema ",

                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                Application.Exit();
            }
        }
    }
}
