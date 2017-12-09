using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoqueConsole.controllers;

namespace EstoqueConsole.Views
{
    public partial class FrmProdutos_Visualizar : Form
    {
        public FrmProdutos_Visualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            dgvproduto.DataSource=produto.ListarProduto(txtNome.Text);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            int codigo = Convert.ToInt32(dgvproduto.CurrentRow.Cells[0].Value.ToString());
            produto.ExcluirProduto(codigo);
            dgvproduto.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvproduto.CurrentRow.Cells[0].Value.ToString());
            FrmProdutos tela = new FrmProdutos(codigo);
            tela.ShowDialog();
            tela.Text = "Alterar produtos";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
