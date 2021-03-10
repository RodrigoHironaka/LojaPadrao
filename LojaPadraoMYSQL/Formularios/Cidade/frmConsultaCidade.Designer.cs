namespace LojaPadraoMYSQL.Formularios
{
    partial class frmConsultaCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCidade));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVOS",
            "INATIVOS"});
            this.cbStatus.Location = new System.Drawing.Point(6, 50);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(88, 24);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(436, 18);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 5;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExc.Image = ((System.Drawing.Image)(resources.GetObject("btExc.Image")));
            this.btExc.Location = new System.Drawing.Point(380, 18);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(50, 50);
            this.btExc.TabIndex = 4;
            this.btExc.UseVisualStyleBackColor = false;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // btEdt
            // 
            this.btEdt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdt.Image = ((System.Drawing.Image)(resources.GetObject("btEdt.Image")));
            this.btEdt.Location = new System.Drawing.Point(324, 18);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(50, 50);
            this.btEdt.TabIndex = 3;
            this.btEdt.UseVisualStyleBackColor = false;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(268, 18);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 2;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(6, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(256, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(491, 341);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // gbBotoes
            // 
            this.gbBotoes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbBotoes.Controls.Add(this.cbStatus);
            this.gbBotoes.Controls.Add(this.label5);
            this.gbBotoes.Controls.Add(this.label3);
            this.gbBotoes.Controls.Add(this.panel4);
            this.gbBotoes.Controls.Add(this.panel2);
            this.gbBotoes.Controls.Add(this.btAdd);
            this.gbBotoes.Controls.Add(this.btEdt);
            this.gbBotoes.Controls.Add(this.txtPesquisa);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btExc);
            this.gbBotoes.Location = new System.Drawing.Point(12, 359);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(491, 80);
            this.gbBotoes.TabIndex = 7;
            this.gbBotoes.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(200, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 381;
            this.label5.Text = "INATIVO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 378;
            this.label3.Text = "ATIVO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(177, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 17);
            this.panel4.TabIndex = 380;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(99, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 17);
            this.panel2.TabIndex = 379;
            // 
            // frmConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(518, 452);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cidades";
            this.Load += new System.EventHandler(this.frmConsultaCidade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaCidade_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsultaCidade_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbBotoes.ResumeLayout(false);
            this.gbBotoes.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}