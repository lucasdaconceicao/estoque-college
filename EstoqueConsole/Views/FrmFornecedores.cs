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

namespace EstoqueConsole.Views
{
    public partial class FrmFornecedores : Form
    {
        int cod;
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        public FrmFornecedores(int id)
        {
            cod = id;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.cod == null)
            {
                Fornecedor fornecedores = new Fornecedor();
                fornecedores.CadastrarFornecedores(
                    Convert.ToInt32(txtFixo.Text),
                    Convert.ToInt32(txtCelular.Text),
                    txtRazaoSocial.Text,
                    txtNome.Text,
                    Convert.ToInt32(txtCnpj.Text),
                    Convert.ToInt32(txtUf.Text),
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
                Fornecedor fornecedores = new Fornecedor();
                fornecedores.AlterarFornecedores(
                    this.cod,
                    Convert.ToInt32(txtFixo.Text),
                    Convert.ToInt32(txtCelular.Text),
                    txtRazaoSocial.Text,
                    txtNome.Text,
                    Convert.ToInt32(txtCnpj.Text),
                    Convert.ToInt32(txtUf.Text),
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

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_casa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void LimparCampos()
        {
            txtNome.Clear();
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
            txtIE.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtCelular.Clear();
            txtFixo.Clear();
            txtEstado.Clear();
            txtUf.Clear();
            txtBairro.Clear();
            txtNumero_casa.Clear();
            txtPais.Clear();
            txtSigla_pais.Clear();
            txtRua.Clear();
            txtReferencia.Clear();
            txtComplemento.Clear();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            //vincular as teclas ENTER e ESC ao botao salvar e cancelar
            this.AcceptButton = this.btnSalvar;
            this.CancelButton = this.btnCancelar;
        }
    }
}
