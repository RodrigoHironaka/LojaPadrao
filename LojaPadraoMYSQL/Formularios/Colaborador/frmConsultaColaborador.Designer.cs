namespace LojaPadraoMYSQL.Formularios.Colaborador
{
    partial class frmConsultaColaborador
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.cbStatus.Location = new System.Drawing.Point(584, 12);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(69, 21);
            this.cbStatus.TabIndex = 22;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(786, 11);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(36, 23);
            this.btSair.TabIndex = 26;
            this.btSair.Text = "sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.Location = new System.Drawing.Point(744, 11);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(36, 23);
            this.btExc.TabIndex = 25;
            this.btExc.Text = "exc";
            this.btExc.UseVisualStyleBackColor = true;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // btEdt
            // 
            this.btEdt.Location = new System.Drawing.Point(702, 11);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(36, 23);
            this.btEdt.TabIndex = 24;
            this.btEdt.Text = "edt";
            this.btEdt.UseVisualStyleBackColor = true;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(660, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(36, 23);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(12, 13);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(566, 20);
            this.txtPesquisa.TabIndex = 21;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 39);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(810, 412);
            this.dgvDados.TabIndex = 27;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // frmConsultaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExc);
            this.Controls.Add(this.btEdt);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaColaborador";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaColaborador_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsultaColaborador_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExc;
        private System.Windows.Forms.Button btEdt;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}