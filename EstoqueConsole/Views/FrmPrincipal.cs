using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueConsole.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores tela = new FrmFornecedores();
            tela.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
        }

        //telas visualizar
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes_Visualizar tela = new FrmClientes_Visualizar();
            tela.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFornecedores_Visualizar tela = new FrmFornecedores_Visualizar();
            tela.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutos_Visualizar tela = new FrmProdutos_Visualizar();
            tela.ShowDialog();
        }
    }
}
