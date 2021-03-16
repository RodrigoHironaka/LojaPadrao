namespace LojaPadraoMYSQL.Formularios.TipoGasto
{
    partial class frmConsulta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pFiltro.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.Size = new System.Drawing.Size(89, 24);
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // btEdt
            // 
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(529, 336);
            this.dgvDados.TabIndex = 11;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(553, 446);
            this.Controls.Add(this.dgvDados);
            this.KeyPreview = true;
            this.Name = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            this.Controls.SetChildIndex(this.gbBotoes, 0);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            this.Controls.SetChildIndex(this.pFiltro, 0);
            this.pFiltro.ResumeLayout(false);
            this.gbBotoes.ResumeLayout(false);
            this.gbBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDados;
    }
}
