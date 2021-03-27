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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaContaPagar));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pFiltro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cbTipoBuscaData = new System.Windows.Forms.ComboBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFaturado = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.chbTipoBuscaData = new System.Windows.Forms.CheckBox();
            this.btClonar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.gbBotoes.SuspendLayout();
            this.pFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Controls.Add(this.btClonar);
            this.gbBotoes.Controls.Add(this.btImprimir);
            this.gbBotoes.Controls.Add(this.btAdd);
            this.gbBotoes.Controls.Add(this.btEdt);
            this.gbBotoes.Controls.Add(this.txtPesquisar);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btExc);
            this.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBotoes.Location = new System.Drawing.Point(12, 417);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(810, 72);
            this.gbBotoes.TabIndex = 18;
            this.gbBotoes.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.White;
            this.txtPesquisar.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(432, 24);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "De";
            // 
            // pFiltro
            // 
            this.pFiltro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFiltro.Controls.Add(this.rbTodos);
            this.pFiltro.Controls.Add(this.rbCancelado);
            this.pFiltro.Controls.Add(this.rbFaturado);
            this.pFiltro.Controls.Add(this.rbAberto);
            this.pFiltro.Controls.Add(this.cbTipoBuscaData);
            this.pFiltro.Controls.Add(this.dateTimePicker2);
            this.pFiltro.Controls.Add(this.dateTimePicker1);
            this.pFiltro.Controls.Add(this.label1);
            this.pFiltro.Controls.Add(this.label2);
            this.pFiltro.Controls.Add(this.chbTipoBuscaData);
            this.pFiltro.ForeColor = System.Drawing.Color.White;
            this.pFiltro.Location = new System.Drawing.Point(18, 289);
            this.pFiltro.Name = "pFiltro";
            this.pFiltro.Size = new System.Drawing.Size(312, 148);
            this.pFiltro.TabIndex = 17;
            this.pFiltro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Até";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(810, 399);
            this.dgvDados.TabIndex = 16;
            // 
            // cbTipoBuscaData
            // 
            this.cbTipoBuscaData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbTipoBuscaData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBuscaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoBuscaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoBuscaData.ForeColor = System.Drawing.Color.White;
            this.cbTipoBuscaData.FormattingEnabled = true;
            this.cbTipoBuscaData.Items.AddRange(new object[] {
            "CADASTRO",
            "VENCIMENTO",
            "PAGAMENTO"});
            this.cbTipoBuscaData.Location = new System.Drawing.Point(138, 34);
            this.cbTipoBuscaData.Name = "cbTipoBuscaData";
            this.cbTipoBuscaData.Size = new System.Drawing.Size(150, 28);
            this.cbTipoBuscaData.TabIndex = 24;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(16, 12);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 28;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelado.ForeColor = System.Drawing.Color.White;
            this.rbCancelado.Location = new System.Drawing.Point(16, 102);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(103, 24);
            this.rbCancelado.TabIndex = 27;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFaturado
            // 
            this.rbFaturado.AutoSize = true;
            this.rbFaturado.Checked = true;
            this.rbFaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFaturado.ForeColor = System.Drawing.Color.White;
            this.rbFaturado.Location = new System.Drawing.Point(16, 72);
            this.rbFaturado.Name = "rbFaturado";
            this.rbFaturado.Size = new System.Drawing.Size(96, 24);
            this.rbFaturado.TabIndex = 26;
            this.rbFaturado.TabStop = true;
            this.rbFaturado.Text = "Pendente";
            this.rbFaturado.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAberto.ForeColor = System.Drawing.Color.White;
            this.rbAberto.Location = new System.Drawing.Point(16, 42);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(64, 24);
            this.rbAberto.TabIndex = 25;
            this.rbAberto.Text = "Pago";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // chbTipoBuscaData
            // 
            this.chbTipoBuscaData.AutoSize = true;
            this.chbTipoBuscaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTipoBuscaData.ForeColor = System.Drawing.Color.White;
            this.chbTipoBuscaData.Location = new System.Drawing.Point(136, 12);
            this.chbTipoBuscaData.Name = "chbTipoBuscaData";
            this.chbTipoBuscaData.Size = new System.Drawing.Size(136, 24);
            this.chbTipoBuscaData.TabIndex = 24;
            this.chbTipoBuscaData.Text = "Busca por data";
            this.chbTipoBuscaData.UseVisualStyleBackColor = true;
            // 
            // btClonar
            // 
            this.btClonar.FlatAppearance.BorderSize = 0;
            this.btClonar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btClonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btClonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btClonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClonar.Image = ((System.Drawing.Image)(resources.GetObject("btClonar.Image")));
            this.btClonar.Location = new System.Drawing.Point(444, 14);
            this.btClonar.Name = "btClonar";
            this.btClonar.Size = new System.Drawing.Size(55, 55);
            this.btClonar.TabIndex = 379;
            this.btClonar.UseVisualStyleBackColor = true;
            // 
            // btImprimir
            // 
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.Location = new System.Drawing.Point(688, 11);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(55, 55);
            this.btImprimir.TabIndex = 13;
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(505, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(55, 55);
            this.btAdd.TabIndex = 9;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdt
            // 
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdt.Image = ((System.Drawing.Image)(resources.GetObject("btEdt.Image")));
            this.btEdt.Location = new System.Drawing.Point(566, 11);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(55, 55);
            this.btEdt.TabIndex = 10;
            this.btEdt.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(749, 11);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(55, 55);
            this.btSair.TabIndex = 12;
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btExc
            // 
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExc.Image = ((System.Drawing.Image)(resources.GetObject("btExc.Image")));
            this.btExc.Location = new System.Drawing.Point(627, 11);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(55, 55);
            this.btExc.TabIndex = 11;
            this.btExc.UseVisualStyleBackColor = true;
            // 
            // frmConsultaContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.pFiltro);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaContaPagar";
            this.gbBotoes.ResumeLayout(false);
            this.gbBotoes.PerformLayout();
            this.pFiltro.ResumeLayout(false);
            this.pFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdt;
        private System.Windows.Forms.Button btExc;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btClonar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ComboBox cbTipoBuscaData;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbFaturado;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.CheckBox chbTipoBuscaData;
    }
}