namespace LojaPadraoMYSQL.Formularios
{
    partial class frmConsultaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pFiltro = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbBotoes.SuspendLayout();
            this.pFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.cbStatus.Location = new System.Drawing.Point(14, 48);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(97, 28);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Lavender;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaPadraoMYSQL.Properties.Resources.Retornar48x48;
            this.btSair.Location = new System.Drawing.Point(753, 19);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 6;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.BackColor = System.Drawing.Color.Lavender;
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExc.Image = global::LojaPadraoMYSQL.Properties.Resources.Delete48x48;
            this.btExc.Location = new System.Drawing.Point(697, 19);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(50, 50);
            this.btExc.TabIndex = 5;
            this.btExc.UseVisualStyleBackColor = false;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // btEdt
            // 
            this.btEdt.BackColor = System.Drawing.Color.Lavender;
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdt.Image = global::LojaPadraoMYSQL.Properties.Resources.Editar48x48;
            this.btEdt.Location = new System.Drawing.Point(641, 19);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(50, 50);
            this.btEdt.TabIndex = 4;
            this.btEdt.UseVisualStyleBackColor = false;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lavender;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = global::LojaPadraoMYSQL.Properties.Resources.Novo48x48;
            this.btAdd.Location = new System.Drawing.Point(585, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 3;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(573, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(810, 352);
            this.dgvDados.TabIndex = 7;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // cbFiltroTipo
            // 
            this.cbFiltroTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroTipo.FormattingEnabled = true;
            this.cbFiltroTipo.Items.AddRange(new object[] {
            "Todos",
            "Física",
            "Jurídica"});
            this.cbFiltroTipo.Location = new System.Drawing.Point(14, 14);
            this.cbFiltroTipo.Name = "cbFiltroTipo";
            this.cbFiltroTipo.Size = new System.Drawing.Size(97, 28);
            this.cbFiltroTipo.TabIndex = 1;
            this.cbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTipo_SelectedIndexChanged);
            // 
            // gbBotoes
            // 
            this.gbBotoes.BackColor = System.Drawing.Color.Lavender;
            this.gbBotoes.Controls.Add(this.label5);
            this.gbBotoes.Controls.Add(this.label3);
            this.gbBotoes.Controls.Add(this.panel4);
            this.gbBotoes.Controls.Add(this.panel2);
            this.gbBotoes.Controls.Add(this.btAdd);
            this.gbBotoes.Controls.Add(this.btEdt);
            this.gbBotoes.Controls.Add(this.btExc);
            this.gbBotoes.Controls.Add(this.txtPesquisa);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Location = new System.Drawing.Point(13, 370);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(809, 80);
            this.gbBotoes.TabIndex = 8;
            this.gbBotoes.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 385;
            this.label5.Text = "INATIVO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(237, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 382;
            this.label3.Text = "ATIVO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(292, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 17);
            this.panel4.TabIndex = 384;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(214, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 17);
            this.panel2.TabIndex = 383;
            // 
            // pFiltro
            // 
            this.pFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.pFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFiltro.Controls.Add(this.dateTimePicker2);
            this.pFiltro.Controls.Add(this.dateTimePicker1);
            this.pFiltro.Controls.Add(this.label1);
            this.pFiltro.Controls.Add(this.label2);
            this.pFiltro.Controls.Add(this.cbFiltroTipo);
            this.pFiltro.Controls.Add(this.cbStatus);
            this.pFiltro.Location = new System.Drawing.Point(19, 298);
            this.pFiltro.Name = "pFiltro";
            this.pFiltro.Size = new System.Drawing.Size(573, 85);
            this.pFiltro.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data de Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "a";
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.pFiltro);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaCliente_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsultaCliente_KeyUp);
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
        private System.Windows.Forms.ComboBox cbFiltroTipo;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Panel pFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}