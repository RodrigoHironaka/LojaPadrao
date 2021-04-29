namespace LojaPadraoMYSQL.Formularios.ContasPagar
{
    partial class frmConsultaContaPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaContaPagar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.btPagar = new System.Windows.Forms.Button();
            this.btRenegociar = new System.Windows.Forms.Button();
            this.btClonar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.pFiltro = new System.Windows.Forms.Panel();
            this.btLimpaFiltro = new System.Windows.Forms.Button();
            this.btFecharPanelFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pDivisao = new System.Windows.Forms.Panel();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.cbTipoBuscaData = new System.Windows.Forms.ComboBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pNomeForm = new System.Windows.Forms.Panel();
            this.lbNomeForm = new System.Windows.Forms.Label();
            this.gbBotoes.SuspendLayout();
            this.pFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pNomeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(249, 37);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(85, 23);
            this.dtpInicio.TabIndex = 5;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(340, 37);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(85, 23);
            this.dtpFinal.TabIndex = 4;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBotoes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbBotoes.Controls.Add(this.btPagar);
            this.gbBotoes.Controls.Add(this.btRenegociar);
            this.gbBotoes.Controls.Add(this.btClonar);
            this.gbBotoes.Controls.Add(this.btImprimir);
            this.gbBotoes.Controls.Add(this.btAdd);
            this.gbBotoes.Controls.Add(this.btEdt);
            this.gbBotoes.Controls.Add(this.txtPesquisar);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btExc);
            this.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBotoes.Location = new System.Drawing.Point(3, 424);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(949, 72);
            this.gbBotoes.TabIndex = 18;
            this.gbBotoes.TabStop = false;
            // 
            // btPagar
            // 
            this.btPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPagar.BackColor = System.Drawing.Color.Transparent;
            this.btPagar.FlatAppearance.BorderSize = 0;
            this.btPagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagar.ForeColor = System.Drawing.Color.Black;
            this.btPagar.Image = ((System.Drawing.Image)(resources.GetObject("btPagar.Image")));
            this.btPagar.Location = new System.Drawing.Point(471, 16);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(50, 50);
            this.btPagar.TabIndex = 381;
            this.btPagar.UseVisualStyleBackColor = false;
            // 
            // btRenegociar
            // 
            this.btRenegociar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRenegociar.BackColor = System.Drawing.Color.Transparent;
            this.btRenegociar.FlatAppearance.BorderSize = 0;
            this.btRenegociar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btRenegociar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btRenegociar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btRenegociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRenegociar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenegociar.ForeColor = System.Drawing.Color.Black;
            this.btRenegociar.Image = ((System.Drawing.Image)(resources.GetObject("btRenegociar.Image")));
            this.btRenegociar.Location = new System.Drawing.Point(527, 16);
            this.btRenegociar.Name = "btRenegociar";
            this.btRenegociar.Size = new System.Drawing.Size(50, 50);
            this.btRenegociar.TabIndex = 380;
            this.btRenegociar.UseVisualStyleBackColor = false;
            // 
            // btClonar
            // 
            this.btClonar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClonar.FlatAppearance.BorderSize = 0;
            this.btClonar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btClonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btClonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btClonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClonar.Image = ((System.Drawing.Image)(resources.GetObject("btClonar.Image")));
            this.btClonar.Location = new System.Drawing.Point(583, 14);
            this.btClonar.Name = "btClonar";
            this.btClonar.Size = new System.Drawing.Size(55, 55);
            this.btClonar.TabIndex = 379;
            this.btClonar.UseVisualStyleBackColor = true;
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.Location = new System.Drawing.Point(827, 11);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(55, 55);
            this.btImprimir.TabIndex = 13;
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(644, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(55, 55);
            this.btAdd.TabIndex = 9;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdt
            // 
            this.btEdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdt.Image = ((System.Drawing.Image)(resources.GetObject("btEdt.Image")));
            this.btEdt.Location = new System.Drawing.Point(705, 11);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(55, 55);
            this.btEdt.TabIndex = 10;
            this.btEdt.UseVisualStyleBackColor = true;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.White;
            this.txtPesquisar.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(444, 24);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(888, 11);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(55, 55);
            this.btSair.TabIndex = 12;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExc.Image = ((System.Drawing.Image)(resources.GetObject("btExc.Image")));
            this.btExc.Location = new System.Drawing.Point(766, 11);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(55, 55);
            this.btExc.TabIndex = 11;
            this.btExc.UseVisualStyleBackColor = true;
            // 
            // pFiltro
            // 
            this.pFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pFiltro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFiltro.Controls.Add(this.btLimpaFiltro);
            this.pFiltro.Controls.Add(this.btFecharPanelFiltro);
            this.pFiltro.Controls.Add(this.label1);
            this.pFiltro.Controls.Add(this.lbCodigo);
            this.pFiltro.Controls.Add(this.panel1);
            this.pFiltro.Controls.Add(this.pDivisao);
            this.pFiltro.Controls.Add(this.cbPessoa);
            this.pFiltro.Controls.Add(this.rbTodos);
            this.pFiltro.Controls.Add(this.rbCancelado);
            this.pFiltro.Controls.Add(this.rbPendente);
            this.pFiltro.Controls.Add(this.rbPago);
            this.pFiltro.Controls.Add(this.cbTipoBuscaData);
            this.pFiltro.Controls.Add(this.dtpInicio);
            this.pFiltro.Controls.Add(this.dtpFinal);
            this.pFiltro.ForeColor = System.Drawing.Color.White;
            this.pFiltro.Location = new System.Drawing.Point(18, 325);
            this.pFiltro.Name = "pFiltro";
            this.pFiltro.Size = new System.Drawing.Size(432, 112);
            this.pFiltro.TabIndex = 17;
            this.pFiltro.Visible = false;
            // 
            // btLimpaFiltro
            // 
            this.btLimpaFiltro.FlatAppearance.BorderSize = 0;
            this.btLimpaFiltro.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btLimpaFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btLimpaFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btLimpaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpaFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btLimpaFiltro.Image")));
            this.btLimpaFiltro.Location = new System.Drawing.Point(355, 73);
            this.btLimpaFiltro.Name = "btLimpaFiltro";
            this.btLimpaFiltro.Size = new System.Drawing.Size(32, 32);
            this.btLimpaFiltro.TabIndex = 381;
            this.btLimpaFiltro.UseVisualStyleBackColor = true;
            this.btLimpaFiltro.Click += new System.EventHandler(this.btLimpaFiltro_Click);
            // 
            // btFecharPanelFiltro
            // 
            this.btFecharPanelFiltro.FlatAppearance.BorderSize = 0;
            this.btFecharPanelFiltro.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btFecharPanelFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btFecharPanelFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btFecharPanelFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharPanelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharPanelFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btFecharPanelFiltro.Image")));
            this.btFecharPanelFiltro.Location = new System.Drawing.Point(393, 73);
            this.btFecharPanelFiltro.Name = "btFecharPanelFiltro";
            this.btFecharPanelFiltro.Size = new System.Drawing.Size(32, 32);
            this.btFecharPanelFiltro.TabIndex = 380;
            this.btFecharPanelFiltro.UseVisualStyleBackColor = true;
            this.btFecharPanelFiltro.Click += new System.EventHandler(this.btFecharPanelFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 283;
            this.label1.Text = "Por data";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(3, 77);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(55, 17);
            this.lbCodigo.TabIndex = 282;
            this.lbCodigo.Text = "Pessoa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(-2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 1);
            this.panel1.TabIndex = 32;
            // 
            // pDivisao
            // 
            this.pDivisao.BackColor = System.Drawing.Color.DarkCyan;
            this.pDivisao.Location = new System.Drawing.Point(-2, 30);
            this.pDivisao.Name = "pDivisao";
            this.pDivisao.Size = new System.Drawing.Size(432, 1);
            this.pDivisao.TabIndex = 31;
            // 
            // cbPessoa
            // 
            this.cbPessoa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPessoa.ForeColor = System.Drawing.Color.White;
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Items.AddRange(new object[] {
            "",
            "CLIENTE",
            "FORNECEDOR"});
            this.cbPessoa.Location = new System.Drawing.Point(71, 74);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(150, 24);
            this.cbPessoa.TabIndex = 29;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(3, 3);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(66, 21);
            this.rbTodos.TabIndex = 28;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelado.ForeColor = System.Drawing.Color.White;
            this.rbCancelado.Location = new System.Drawing.Point(332, 3);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(93, 21);
            this.rbCancelado.TabIndex = 27;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            this.rbCancelado.CheckedChanged += new System.EventHandler(this.rbCancelado_CheckedChanged);
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Checked = true;
            this.rbPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPendente.ForeColor = System.Drawing.Color.White;
            this.rbPendente.Location = new System.Drawing.Point(206, 3);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(87, 21);
            this.rbPendente.TabIndex = 26;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            this.rbPendente.CheckedChanged += new System.EventHandler(this.rbPendente_CheckedChanged);
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPago.ForeColor = System.Drawing.Color.White;
            this.rbPago.Location = new System.Drawing.Point(108, 3);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(59, 21);
            this.rbPago.TabIndex = 25;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            this.rbPago.CheckedChanged += new System.EventHandler(this.rbPago_CheckedChanged);
            // 
            // cbTipoBuscaData
            // 
            this.cbTipoBuscaData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbTipoBuscaData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBuscaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoBuscaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoBuscaData.ForeColor = System.Drawing.Color.White;
            this.cbTipoBuscaData.FormattingEnabled = true;
            this.cbTipoBuscaData.Items.AddRange(new object[] {
            "",
            "CADASTRO",
            "VENCIMENTO",
            "PAGAMENTO"});
            this.cbTipoBuscaData.Location = new System.Drawing.Point(71, 36);
            this.cbTipoBuscaData.Name = "cbTipoBuscaData";
            this.cbTipoBuscaData.Size = new System.Drawing.Size(150, 24);
            this.cbTipoBuscaData.TabIndex = 24;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(3, 41);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(949, 388);
            this.dgvDados.TabIndex = 16;
            // 
            // pNomeForm
            // 
            this.pNomeForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNomeForm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pNomeForm.Controls.Add(this.lbNomeForm);
            this.pNomeForm.Location = new System.Drawing.Point(3, -1);
            this.pNomeForm.Name = "pNomeForm";
            this.pNomeForm.Size = new System.Drawing.Size(949, 36);
            this.pNomeForm.TabIndex = 19;
            // 
            // lbNomeForm
            // 
            this.lbNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeForm.AutoSize = true;
            this.lbNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeForm.ForeColor = System.Drawing.Color.White;
            this.lbNomeForm.Location = new System.Drawing.Point(381, 6);
            this.lbNomeForm.Name = "lbNomeForm";
            this.lbNomeForm.Size = new System.Drawing.Size(200, 24);
            this.lbNomeForm.TabIndex = 0;
            this.lbNomeForm.Text = "CONSULTA A PAGAR";
            // 
            // frmConsultaContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 501);
            this.Controls.Add(this.pNomeForm);
            this.Controls.Add(this.pFiltro);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaContaPagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultaContaPagar_Load);
            this.gbBotoes.ResumeLayout(false);
            this.gbBotoes.PerformLayout();
            this.pFiltro.ResumeLayout(false);
            this.pFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pNomeForm.ResumeLayout(false);
            this.pNomeForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdt;
        private System.Windows.Forms.Button btExc;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btClonar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel pFiltro;
        private System.Windows.Forms.ComboBox cbTipoBuscaData;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.Panel pDivisao;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimpaFiltro;
        private System.Windows.Forms.Button btFecharPanelFiltro;
        public System.Windows.Forms.Button btPagar;
        public System.Windows.Forms.Button btRenegociar;
        public System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Panel pNomeForm;
        private System.Windows.Forms.Label lbNomeForm;
    }
}