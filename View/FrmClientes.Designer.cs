namespace EstoqueConsole
{
    partial class Frmclientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFixo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero_casa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSigla_pais = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::EstoqueConsole.Properties.Resources.button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(370, 521);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::EstoqueConsole.Properties.Resources.button_ok11;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(262, 522);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 30);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(423, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "NASCIMENTO";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 109);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(221, 20);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(248, 109);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(187, 20);
            this.dtpNascimento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "FIXO";
            // 
            // txtFixo
            // 
            this.txtFixo.Location = new System.Drawing.Point(248, 158);
            this.txtFixo.Name = "txtFixo";
            this.txtFixo.Size = new System.Drawing.Size(187, 20);
            this.txtFixo.TabIndex = 12;
            this.txtFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "CELULAR";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(12, 158);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(221, 20);
            this.txtCelular.TabIndex = 14;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nº CASA";
            // 
            // txtNumero_casa
            // 
            this.txtNumero_casa.Location = new System.Drawing.Point(12, 245);
            this.txtNumero_casa.Name = "txtNumero_casa";
            this.txtNumero_casa.Size = new System.Drawing.Size(221, 20);
            this.txtNumero_casa.TabIndex = 16;
            this.txtNumero_casa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_casa_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "COMPLEMENTO";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(248, 203);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(187, 20);
            this.txtCep.TabIndex = 18;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "CEP";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(248, 245);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(187, 20);
            this.txtReferencia.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "REFERENCIA";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(12, 292);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(221, 20);
            this.txtComplemento.TabIndex = 22;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(248, 292);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(187, 20);
            this.txtRua.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(245, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "RUA";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 337);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(221, 20);
            this.txtBairro.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "BAIRRO";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(248, 337);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(187, 20);
            this.txtCidade.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(248, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "CIDADE";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(12, 379);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(221, 20);
            this.txtEstado.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "ESTADO";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(248, 379);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(187, 20);
            this.txtUf.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(248, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "UF";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(12, 419);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(102, 20);
            this.txtPais.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "PAÍS";
            // 
            // txtSigla_pais
            // 
            this.txtSigla_pais.Location = new System.Drawing.Point(127, 419);
            this.txtSigla_pais.Name = "txtSigla_pais";
            this.txtSigla_pais.Size = new System.Drawing.Size(106, 20);
            this.txtSigla_pais.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(128, 401);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "SIGLA PAÍS";
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(477, 564);
            this.Controls.Add(this.txtSigla_pais);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumero_casa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFixo);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.Name = "Frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar clientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFixo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero_casa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSigla_pais;
        private System.Windows.Forms.Label label17;
    }
}

