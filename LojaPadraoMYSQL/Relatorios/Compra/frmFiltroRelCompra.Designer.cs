namespace LojaPadraoMYSQL.Relatorios.Compra
{
    partial class frmFiltroRelCompra
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
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.btFaturar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBotoes.BackColor = System.Drawing.Color.DarkCyan;
            this.gbBotoes.Controls.Add(this.btFaturar);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btSalvar);
            this.gbBotoes.Location = new System.Drawing.Point(653, 419);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(185, 70);
            this.gbBotoes.TabIndex = 372;
            this.gbBotoes.TabStop = false;
            // 
            // btFaturar
            // 
            this.btFaturar.FlatAppearance.BorderSize = 0;
            this.btFaturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFaturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFaturar.Location = new System.Drawing.Point(6, 14);
            this.btFaturar.Name = "btFaturar";
            this.btFaturar.Size = new System.Drawing.Size(50, 50);
            this.btFaturar.TabIndex = 0;
            this.btFaturar.Text = "Gerar";
            this.btFaturar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaPadraoMYSQL.Properties.Resources.Retornar48x48;
            this.btSair.Location = new System.Drawing.Point(118, 14);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 2;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(62, 14);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(50, 50);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Limpar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.lbRazaoSocial.Location = new System.Drawing.Point(105, 73);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(555, 76);
            this.lbRazaoSocial.TabIndex = 373;
            this.lbRazaoSocial.Text = "Ainda vou montar";
            // 
            // frmFiltroRelCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(850, 501);
            this.Controls.Add(this.lbRazaoSocial);
            this.Controls.Add(this.gbBotoes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFiltroRelCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiltroRelCompra";
            this.gbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBotoes;
        public System.Windows.Forms.Button btFaturar;
        private System.Windows.Forms.Button btSair;
        public System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbRazaoSocial;
    }
}