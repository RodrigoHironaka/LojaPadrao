namespace LojaPadraoMYSQL.Formularios
{
    partial class frmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.pFiltro = new System.Windows.Forms.Panel();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbBotoes.SuspendLayout();
            this.pFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVOS",
            "INATIVOS"});
            this.cbStatus.Location = new System.Drawing.Point(163, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(99, 28);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(754, 16);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 5;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExc.Image = ((System.Drawing.Image)(resources.GetObject("btExc.Image")));
            this.btExc.Location = new System.Drawing.Point(698, 16);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(50, 50);
            this.btExc.TabIndex = 4;
            this.btExc.UseVisualStyleBackColor = true;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // btEdt
            // 
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdt.Image = ((System.Drawing.Image)(resources.GetObject("btEdt.Image")));
            this.btEdt.Location = new System.Drawing.Point(642, 16);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(50, 50);
            this.btEdt.TabIndex = 3;
            this.btEdt.UseVisualStyleBackColor = true;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(586, 16);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 2;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(6, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(574, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(810, 354);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // gbBotoes
            // 
            this.gbBotoes.Controls.Add(this.txtPesquisa);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btExc);
            this.gbBotoes.Controls.Add(this.btEdt);
            this.gbBotoes.Controls.Add(this.btAdd);
            this.gbBotoes.Location = new System.Drawing.Point(12, 372);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(810, 78);
            this.gbBotoes.TabIndex = 16;
            this.gbBotoes.TabStop = false;
            // 
            // pFiltro
            // 
            this.pFiltro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFiltro.Controls.Add(this.cbTipo);
            this.pFiltro.Controls.Add(this.dtpInicio);
            this.pFiltro.Controls.Add(this.dtpFinal);
            this.pFiltro.Controls.Add(this.cbStatus);
            this.pFiltro.Controls.Add(this.cbGrupo);
            this.pFiltro.Controls.Add(this.label1);
            this.pFiltro.Location = new System.Drawing.Point(18, 283);
            this.pFiltro.Name = "pFiltro";
            this.pFiltro.Size = new System.Drawing.Size(450, 110);
            this.pFiltro.TabIndex = 17;
            this.pFiltro.Visible = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarForeColor = System.Drawing.Color.White;
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.dtpInicio.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dtpInicio.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dtpInicio.CalendarTrailingForeColor = System.Drawing.Color.Teal;
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(9, 32);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(118, 26);
            this.dtpInicio.TabIndex = 10;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFinal.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.dtpFinal.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dtpFinal.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dtpFinal.CalendarTrailingForeColor = System.Drawing.Color.Teal;
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(9, 64);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(118, 26);
            this.dtpFinal.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro";
            // 
            // cbGrupo
            // 
            this.cbGrupo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.ForeColor = System.Drawing.Color.White;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(268, 30);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(163, 28);
            this.cbGrupo.TabIndex = 2;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.ForeColor = System.Drawing.Color.White;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "PRODUTO",
            "SERVIÇO"});
            this.cbTipo.Location = new System.Drawing.Point(163, 62);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(99, 28);
            this.cbTipo.TabIndex = 12;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.pFiltro);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaProduto_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsultaProduto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbBotoes.ResumeLayout(false);
            this.gbBotoes.PerformLayout();
            this.pFiltro.ResumeLayout(false);
            this.pFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExc;
        private System.Windows.Forms.Button btEdt;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Panel pFiltro;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}