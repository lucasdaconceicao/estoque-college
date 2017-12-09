using EstoqueConsole.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueConsole
{
    public partial class FrmClientes : Form
    {
        int cod;
        public FrmClientes()
        {
            InitializeComponent();
        }

        public FrmClientes(int id)
        {
            cod = id;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.cod == null)
            {
                Cliente clientes = new Cliente();
                clientes.CadastrarClientes(
                    Convert.ToInt32(txtFixo.Text),
                    Convert.ToInt32(txtCelular.Text),
                    txtNome.Text,
                    txtCpf.Text,
                    Convert.ToDateTime(dtpNascimento.Text),
                    txtEmail.Text,
                    txtRua.Text,
                    Convert.ToInt32(txtCep.Text),
                    Convert.ToInt32(txtNumero_casa.Text),
                    txtComplemento.Text,
                    txtReferencia.Text,
                    txtPais.Text,
                    txtEstado.Text,
                    txtCidade.Text,
                    txtBairro.Text,
                   txtRua.Text
                );
                LimparCampos();
            }
            else
            {
                Cliente clientes = new Cliente();
                clientes.AlterarClientes(
                    this.cod,
                    Convert.ToInt32(txtFixo.Text),
                    Convert.ToInt32(txtCelular.Text),
                    txtNome.Text,
                    txtCpf.Text,
                    Convert.ToDateTime(dtpNascimento.Text),
                    txtEmail.Text,
                    txtRua.Text,
                    Convert.ToInt32(txtCep.Text),
                    Convert.ToInt32(txtNumero_casa.Text),
                    txtComplemento.Text,
                    txtReferencia.Text,
                    txtPais.Text,
                    txtEstado.Text,
                    txtCidade.Text,
                    txtBairro.Text,
                    txtRua.Text
                );
                LimparCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumero_casa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            //vincular as teclas ENTER e ESC ao botao salvar e cancelar
            this.AcceptButton = this.btnSalvar;
            this.CancelButton = this.btnCancelar;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtCelular.Clear();
            txtFixo.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            txtNumero_casa.Clear();
            txtReferencia.Clear();
            txtComplemento.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtUf.Clear();
            txtPais.Clear();
            txtSigla_pais.Clear();
        }
    }
}
