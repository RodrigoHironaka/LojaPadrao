﻿namespace LojaPadraoMYSQL.Formularios
{
    partial class frmCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedor));
            this.label2 = new System.Windows.Forms.Label();
            this.btRemFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.txtIdCidade = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageDadosPrincipais = new System.Windows.Forms.TabPage();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.mskCelular2 = new System.Windows.Forms.MaskedTextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.mskIe = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.lbUf = new System.Windows.Forms.Label();
            this.lbCelular2 = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbIe = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btAddFoto = new System.Windows.Forms.Button();
            this.btProcurarCidade = new System.Windows.Forms.Button();
            this.pctCepInvalido = new System.Windows.Forms.PictureBox();
            this.pctCnpjInvalido = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpageDadosPrincipais.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCepInvalido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCnpjInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(310, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 311;
            this.label2.Text = "Logo:";
            // 
            // btRemFoto
            // 
            this.btRemFoto.FlatAppearance.BorderSize = 0;
            this.btRemFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btRemFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btRemFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemFoto.Image = global::LojaPadraoMYSQL.Properties.Resources.RemoverFoto16x16;
            this.btRemFoto.Location = new System.Drawing.Point(455, 3);
            this.btRemFoto.Name = "btRemFoto";
            this.btRemFoto.Size = new System.Drawing.Size(20, 20);
            this.btRemFoto.TabIndex = 309;
            this.btRemFoto.UseVisualStyleBackColor = true;
            this.btRemFoto.Click += new System.EventHandler(this.btRemFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 301;
            this.label1.Text = "Código:";
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Enabled = false;
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUf.Location = new System.Drawing.Point(426, 441);
            this.txtUf.MaxLength = 30;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(48, 26);
            this.txtUf.TabIndex = 300;
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Enabled = false;
            this.txtNomeCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCidade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCidade.Location = new System.Drawing.Point(111, 441);
            this.txtNomeCidade.MaxLength = 30;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(309, 26);
            this.txtNomeCidade.TabIndex = 299;
            this.txtNomeCidade.TextChanged += new System.EventHandler(this.txtNomeCidade_TextChanged);
            // 
            // txtIdCidade
            // 
            this.txtIdCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCidade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdCidade.Location = new System.Drawing.Point(5, 441);
            this.txtIdCidade.MaxLength = 30;
            this.txtIdCidade.Name = "txtIdCidade";
            this.txtIdCidade.Size = new System.Drawing.Size(59, 26);
            this.txtIdCidade.TabIndex = 15;
            this.txtIdCidade.TextChanged += new System.EventHandler(this.txtIdCidade_TextChanged);
            this.txtIdCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCidade_KeyPress);
            this.txtIdCidade.Leave += new System.EventHandler(this.txtIdCidade_Leave);
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtObservacao.Location = new System.Drawing.Point(481, 82);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(221, 308);
            this.txtObservacao.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(6, 30);
            this.txtID.MaxLength = 6;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 26);
            this.txtID.TabIndex = 279;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRazaoSocial.Location = new System.Drawing.Point(6, 186);
            this.txtRazaoSocial.MaxLength = 100;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(469, 26);
            this.txtRazaoSocial.TabIndex = 4;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeFantasia.Location = new System.Drawing.Point(5, 134);
            this.txtNomeFantasia.MaxLength = 100;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(470, 26);
            this.txtNomeFantasia.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndereco.Location = new System.Drawing.Point(98, 341);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(298, 26);
            this.txtEndereco.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(6, 290);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(468, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumero.Location = new System.Drawing.Point(402, 341);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(72, 26);
            this.txtNumero.TabIndex = 12;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtComplemento.Location = new System.Drawing.Point(5, 393);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(233, 26);
            this.txtComplemento.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBairro.Location = new System.Drawing.Point(243, 393);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(230, 26);
            this.txtBairro.TabIndex = 14;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataCadastro.Location = new System.Drawing.Point(76, 30);
            this.txtDataCadastro.MaxLength = 10;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(160, 26);
            this.txtDataCadastro.TabIndex = 262;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.ForeColor = System.Drawing.Color.Black;
            this.lbObservacao.Location = new System.Drawing.Point(477, 59);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(98, 20);
            this.lbObservacao.TabIndex = 297;
            this.lbObservacao.Text = "Observação:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageDadosPrincipais);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 508);
            this.tabControl1.TabIndex = 1;
            // 
            // tpageDadosPrincipais
            // 
            this.tpageDadosPrincipais.BackColor = System.Drawing.Color.Lavender;
            this.tpageDadosPrincipais.Controls.Add(this.gbBotoes);
            this.tpageDadosPrincipais.Controls.Add(this.txtNomeVendedor);
            this.tpageDadosPrincipais.Controls.Add(this.label3);
            this.tpageDadosPrincipais.Controls.Add(this.pbFoto);
            this.tpageDadosPrincipais.Controls.Add(this.label2);
            this.tpageDadosPrincipais.Controls.Add(this.btAddFoto);
            this.tpageDadosPrincipais.Controls.Add(this.btRemFoto);
            this.tpageDadosPrincipais.Controls.Add(this.btProcurarCidade);
            this.tpageDadosPrincipais.Controls.Add(this.txtUf);
            this.tpageDadosPrincipais.Controls.Add(this.txtNomeCidade);
            this.tpageDadosPrincipais.Controls.Add(this.txtIdCidade);
            this.tpageDadosPrincipais.Controls.Add(this.txtObservacao);
            this.tpageDadosPrincipais.Controls.Add(this.txtID);
            this.tpageDadosPrincipais.Controls.Add(this.txtRazaoSocial);
            this.tpageDadosPrincipais.Controls.Add(this.txtNomeFantasia);
            this.tpageDadosPrincipais.Controls.Add(this.txtEndereco);
            this.tpageDadosPrincipais.Controls.Add(this.txtEmail);
            this.tpageDadosPrincipais.Controls.Add(this.txtNumero);
            this.tpageDadosPrincipais.Controls.Add(this.txtComplemento);
            this.tpageDadosPrincipais.Controls.Add(this.txtBairro);
            this.tpageDadosPrincipais.Controls.Add(this.txtDataCadastro);
            this.tpageDadosPrincipais.Controls.Add(this.lbObservacao);
            this.tpageDadosPrincipais.Controls.Add(this.pctCepInvalido);
            this.tpageDadosPrincipais.Controls.Add(this.pctCnpjInvalido);
            this.tpageDadosPrincipais.Controls.Add(this.lbCnpj);
            this.tpageDadosPrincipais.Controls.Add(this.lbTelefone);
            this.tpageDadosPrincipais.Controls.Add(this.chbAtivo);
            this.tpageDadosPrincipais.Controls.Add(this.lbRazaoSocial);
            this.tpageDadosPrincipais.Controls.Add(this.lbNomeFantasia);
            this.tpageDadosPrincipais.Controls.Add(this.lbEndereco);
            this.tpageDadosPrincipais.Controls.Add(this.mskCelular2);
            this.tpageDadosPrincipais.Controls.Add(this.lbNumero);
            this.tpageDadosPrincipais.Controls.Add(this.lbEmail);
            this.tpageDadosPrincipais.Controls.Add(this.mskCelular);
            this.tpageDadosPrincipais.Controls.Add(this.lbComplemento);
            this.tpageDadosPrincipais.Controls.Add(this.mskTelefone);
            this.tpageDadosPrincipais.Controls.Add(this.mskCnpj);
            this.tpageDadosPrincipais.Controls.Add(this.lbBairro);
            this.tpageDadosPrincipais.Controls.Add(this.mskIe);
            this.tpageDadosPrincipais.Controls.Add(this.mskCep);
            this.tpageDadosPrincipais.Controls.Add(this.lbCidade);
            this.tpageDadosPrincipais.Controls.Add(this.lbDataCadastro);
            this.tpageDadosPrincipais.Controls.Add(this.lbUf);
            this.tpageDadosPrincipais.Controls.Add(this.lbCelular2);
            this.tpageDadosPrincipais.Controls.Add(this.lbCep);
            this.tpageDadosPrincipais.Controls.Add(this.lbCodigo);
            this.tpageDadosPrincipais.Controls.Add(this.lbIe);
            this.tpageDadosPrincipais.Controls.Add(this.lbCelular);
            this.tpageDadosPrincipais.Controls.Add(this.label1);
            this.tpageDadosPrincipais.Location = new System.Drawing.Point(4, 22);
            this.tpageDadosPrincipais.Name = "tpageDadosPrincipais";
            this.tpageDadosPrincipais.Padding = new System.Windows.Forms.Padding(3);
            this.tpageDadosPrincipais.Size = new System.Drawing.Size(714, 482);
            this.tpageDadosPrincipais.TabIndex = 0;
            this.tpageDadosPrincipais.Text = "Dados Principais";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVendedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeVendedor.Location = new System.Drawing.Point(481, 28);
            this.txtNomeVendedor.MaxLength = 20;
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(221, 26);
            this.txtNomeVendedor.TabIndex = 313;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(477, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 314;
            this.label3.Text = "Vendedor:";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCnpj.ForeColor = System.Drawing.Color.Black;
            this.lbCnpj.Location = new System.Drawing.Point(2, 59);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(53, 20);
            this.lbCnpj.TabIndex = 272;
            this.lbCnpj.Text = "CNPJ:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.Color.Black;
            this.lbTelefone.Location = new System.Drawing.Point(2, 215);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(75, 20);
            this.lbTelefone.TabIndex = 275;
            this.lbTelefone.Text = "Telefone:";
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Checked = true;
            this.chbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAtivo.Location = new System.Drawing.Point(645, 2);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(63, 24);
            this.chbAtivo.TabIndex = 1;
            this.chbAtivo.Text = "Ativo";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.lbRazaoSocial.Location = new System.Drawing.Point(1, 163);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(107, 20);
            this.lbRazaoSocial.TabIndex = 263;
            this.lbRazaoSocial.Text = "Razão Social:";
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFantasia.ForeColor = System.Drawing.Color.Black;
            this.lbNomeFantasia.Location = new System.Drawing.Point(3, 111);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(121, 20);
            this.lbNomeFantasia.TabIndex = 264;
            this.lbNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.ForeColor = System.Drawing.Color.Black;
            this.lbEndereco.Location = new System.Drawing.Point(98, 318);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(82, 20);
            this.lbEndereco.TabIndex = 265;
            this.lbEndereco.Text = "Endereço:";
            // 
            // mskCelular2
            // 
            this.mskCelular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular2.Location = new System.Drawing.Point(349, 238);
            this.mskCelular2.Mask = "(00)00000-0000";
            this.mskCelular2.Name = "mskCelular2";
            this.mskCelular2.Size = new System.Drawing.Size(125, 26);
            this.mskCelular2.TabIndex = 8;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.ForeColor = System.Drawing.Color.Black;
            this.lbNumero.Location = new System.Drawing.Point(398, 318);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(69, 20);
            this.lbNumero.TabIndex = 266;
            this.lbNumero.Text = "Número:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(2, 267);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 276;
            this.lbEmail.Text = "Email:";
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.Location = new System.Drawing.Point(181, 238);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(125, 26);
            this.mskCelular.TabIndex = 7;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.ForeColor = System.Drawing.Color.Black;
            this.lbComplemento.Location = new System.Drawing.Point(2, 370);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(112, 20);
            this.lbComplemento.TabIndex = 267;
            this.lbComplemento.Text = "Complemento:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(5, 238);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(125, 26);
            this.mskTelefone.TabIndex = 6;
            // 
            // mskCnpj
            // 
            this.mskCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCnpj.Location = new System.Drawing.Point(6, 82);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(161, 26);
            this.mskCnpj.TabIndex = 2;
            this.mskCnpj.Leave += new System.EventHandler(this.mskCnpj_Leave);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.ForeColor = System.Drawing.Color.Black;
            this.lbBairro.Location = new System.Drawing.Point(240, 373);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 20);
            this.lbBairro.TabIndex = 268;
            this.lbBairro.Text = "Bairro:";
            // 
            // mskIe
            // 
            this.mskIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIe.Location = new System.Drawing.Point(175, 82);
            this.mskIe.Mask = "000,000,000,000";
            this.mskIe.Name = "mskIe";
            this.mskIe.Size = new System.Drawing.Size(133, 26);
            this.mskIe.TabIndex = 2;
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(6, 341);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(86, 26);
            this.mskCep.TabIndex = 10;
            this.mskCep.Text = "17800000";
            this.mskCep.Leave += new System.EventHandler(this.mskCep_Leave);
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.ForeColor = System.Drawing.Color.Black;
            this.lbCidade.Location = new System.Drawing.Point(111, 418);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(63, 20);
            this.lbCidade.TabIndex = 269;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadastro.ForeColor = System.Drawing.Color.Black;
            this.lbDataCadastro.Location = new System.Drawing.Point(75, 7);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(117, 20);
            this.lbDataCadastro.TabIndex = 283;
            this.lbDataCadastro.Text = "Data Cadastro:";
            // 
            // lbUf
            // 
            this.lbUf.AutoSize = true;
            this.lbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUf.ForeColor = System.Drawing.Color.Black;
            this.lbUf.Location = new System.Drawing.Point(422, 418);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(35, 20);
            this.lbUf.TabIndex = 270;
            this.lbUf.Text = "UF:";
            // 
            // lbCelular2
            // 
            this.lbCelular2.AutoSize = true;
            this.lbCelular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular2.ForeColor = System.Drawing.Color.Black;
            this.lbCelular2.Location = new System.Drawing.Point(345, 215);
            this.lbCelular2.Name = "lbCelular2";
            this.lbCelular2.Size = new System.Drawing.Size(71, 20);
            this.lbCelular2.TabIndex = 281;
            this.lbCelular2.Text = "Celular2:";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.ForeColor = System.Drawing.Color.Black;
            this.lbCep.Location = new System.Drawing.Point(4, 318);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(45, 20);
            this.lbCep.TabIndex = 271;
            this.lbCep.Text = "CEP:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.Black;
            this.lbCodigo.Location = new System.Drawing.Point(6, 7);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(63, 20);
            this.lbCodigo.TabIndex = 280;
            this.lbCodigo.Text = "Código:";
            // 
            // lbIe
            // 
            this.lbIe.AutoSize = true;
            this.lbIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIe.ForeColor = System.Drawing.Color.Black;
            this.lbIe.Location = new System.Drawing.Point(173, 59);
            this.lbIe.Name = "lbIe";
            this.lbIe.Size = new System.Drawing.Size(29, 20);
            this.lbIe.TabIndex = 273;
            this.lbIe.Text = "IE:";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.ForeColor = System.Drawing.Color.Black;
            this.lbCelular.Location = new System.Drawing.Point(177, 215);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(62, 20);
            this.lbCelular.TabIndex = 274;
            this.lbCelular.Text = "Celular:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbBotoes
            // 
            this.gbBotoes.BackColor = System.Drawing.Color.Lavender;
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btSalvar);
            this.gbBotoes.Location = new System.Drawing.Point(481, 393);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(227, 80);
            this.gbBotoes.TabIndex = 317;
            this.gbBotoes.TabStop = false;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = global::LojaPadraoMYSQL.Properties.Resources.Retornar48x48;
            this.btSair.Location = new System.Drawing.Point(171, 24);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 19;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Image = global::LojaPadraoMYSQL.Properties.Resources.Salvar48x48;
            this.btSalvar.Location = new System.Drawing.Point(115, 24);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(50, 50);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(314, 28);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(161, 97);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 312;
            this.pbFoto.TabStop = false;
            // 
            // btAddFoto
            // 
            this.btAddFoto.FlatAppearance.BorderSize = 0;
            this.btAddFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btAddFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btAddFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddFoto.Image = global::LojaPadraoMYSQL.Properties.Resources.InserirFoto16x16;
            this.btAddFoto.Location = new System.Drawing.Point(427, 3);
            this.btAddFoto.Name = "btAddFoto";
            this.btAddFoto.Size = new System.Drawing.Size(20, 20);
            this.btAddFoto.TabIndex = 310;
            this.btAddFoto.UseVisualStyleBackColor = true;
            this.btAddFoto.Click += new System.EventHandler(this.btAddFoto_Click_1);
            // 
            // btProcurarCidade
            // 
            this.btProcurarCidade.FlatAppearance.BorderSize = 0;
            this.btProcurarCidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btProcurarCidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btProcurarCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurarCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurarCidade.Image = global::LojaPadraoMYSQL.Properties.Resources.lupa32x32;
            this.btProcurarCidade.Location = new System.Drawing.Point(70, 437);
            this.btProcurarCidade.Name = "btProcurarCidade";
            this.btProcurarCidade.Size = new System.Drawing.Size(35, 35);
            this.btProcurarCidade.TabIndex = 16;
            this.btProcurarCidade.UseVisualStyleBackColor = true;
            this.btProcurarCidade.Click += new System.EventHandler(this.btProcurarCidade_Click);
            // 
            // pctCepInvalido
            // 
            this.pctCepInvalido.Image = ((System.Drawing.Image)(resources.GetObject("pctCepInvalido.Image")));
            this.pctCepInvalido.Location = new System.Drawing.Point(76, 322);
            this.pctCepInvalido.Name = "pctCepInvalido";
            this.pctCepInvalido.Size = new System.Drawing.Size(16, 16);
            this.pctCepInvalido.TabIndex = 290;
            this.pctCepInvalido.TabStop = false;
            this.pctCepInvalido.Visible = false;
            this.pctCepInvalido.WaitOnLoad = true;
            // 
            // pctCnpjInvalido
            // 
            this.pctCnpjInvalido.Image = ((System.Drawing.Image)(resources.GetObject("pctCnpjInvalido.Image")));
            this.pctCnpjInvalido.Location = new System.Drawing.Point(151, 63);
            this.pctCnpjInvalido.Name = "pctCnpjInvalido";
            this.pctCnpjInvalido.Size = new System.Drawing.Size(16, 16);
            this.pctCnpjInvalido.TabIndex = 289;
            this.pctCnpjInvalido.TabStop = false;
            this.pctCnpjInvalido.Visible = false;
            this.pctCnpjInvalido.WaitOnLoad = true;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(741, 521);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroFornecedor_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tpageDadosPrincipais.ResumeLayout(false);
            this.tpageDadosPrincipais.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCepInvalido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCnpjInvalido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddFoto;
        private System.Windows.Forms.Button btRemFoto;
        private System.Windows.Forms.Button btProcurarCidade;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.TextBox txtNomeCidade;
        public System.Windows.Forms.TextBox txtIdCidade;
        public System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtRazaoSocial;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.PictureBox pctCepInvalido;
        private System.Windows.Forms.PictureBox pctCnpjInvalido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpageDadosPrincipais;
        public System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.Label lbTelefone;
        public System.Windows.Forms.CheckBox chbAtivo;
        private System.Windows.Forms.Label lbRazaoSocial;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.Label lbEndereco;
        public System.Windows.Forms.MaskedTextBox mskCelular2;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbEmail;
        public System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lbComplemento;
        public System.Windows.Forms.MaskedTextBox mskTelefone;
        public System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.Label lbBairro;
        public System.Windows.Forms.MaskedTextBox mskIe;
        public System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.Label lbUf;
        private System.Windows.Forms.Label lbCelular2;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbIe;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbBotoes;
    }
}