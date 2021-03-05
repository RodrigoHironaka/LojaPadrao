namespace LojaPadraoMYSQL.Formularios.TipoGasto
{
    partial class frmCadastro
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
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = true;
            this.txtID.ForeColor = System.Drawing.Color.White;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.White;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(351, 167);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
