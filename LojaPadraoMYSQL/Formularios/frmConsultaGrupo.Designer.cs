namespace LojaPadraoMYSQL.Formularios
{
    partial class frmConsultaGrupo
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 42);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(386, 240);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(12, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(142, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(236, 14);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(36, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdt
            // 
            this.btEdt.Location = new System.Drawing.Point(278, 14);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(36, 23);
            this.btEdt.TabIndex = 3;
            this.btEdt.Text = "edt";
            this.btEdt.UseVisualStyleBackColor = true;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btExc
            // 
            this.btExc.Location = new System.Drawing.Point(320, 14);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(36, 23);
            this.btExc.TabIndex = 4;
            this.btExc.Text = "exc";
            this.btExc.UseVisualStyleBackColor = true;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(362, 14);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(36, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.cbStatus.Location = new System.Drawing.Point(160, 15);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(69, 21);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // frmConsultaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 300);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExc);
            this.Controls.Add(this.btEdt);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvDados);
            this.MaximizeBox = false;
            this.Name = "frmConsultaGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaGrupo";
            this.Load += new System.EventHandler(this.frmConsultaGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdt;
        private System.Windows.Forms.Button btExc;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}