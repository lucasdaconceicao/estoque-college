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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo");
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtUn.Clear();
            txtGrupo.Clear();
            txtCod_Barras.Clear();
        }

        private void txtCod_Barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //vincular as teclas ENTER e ESC ao botao salvar e cancelar
            this.AcceptButton = this.btnSalvar;
            this.CancelButton = this.btnCancelar;
        }
    }
}
