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
    public partial class FrmClientes_Visualizar : Form
    {
        public FrmClientes_Visualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            dgvclientes.DataSource = clientes.ListarCliente(txtNome.Text);
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            int codigo = Convert.ToInt32(dgvclientes.CurrentRow.Cells[0].Value.ToString());
            clientes.RemoverCliente(codigo);
            dgvclientes.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvclientes.CurrentRow.Cells[0].Value.ToString());
            FrmClientes tela = new FrmClientes(codigo);
            tela.ShowDialog();
            tela.Text = "Alterar cliente";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
