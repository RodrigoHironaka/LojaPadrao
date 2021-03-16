namespace LojaPadraoMYSQL.Formularios
{
    partial class frmCadastroUnidadeMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUnidadeMedida));
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(16, 33);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código";
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(71, 10);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 4;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(6, 10);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(50, 50);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(122, 35);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(63, 24);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(16, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // txtSigla
            // 
            this.txtSigla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.ForeColor = System.Drawing.Color.White;
            this.txtSigla.Location = new System.Drawing.Point(251, 98);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(61, 26);
            this.txtSigla.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sigla";
            // 
            // gbBotoes
            // 
            this.gbBotoes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btSalvar);
            this.gbBotoes.Location = new System.Drawing.Point(185, 12);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(127, 66);
            this.gbBotoes.TabIndex = 24;
            this.gbBotoes.TabStop = false;
            // 
            // frmCadastroUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroUnidadeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Unidade de Medida";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroUnidadeMedida_KeyDown);
            this.gbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbBotoes;
    }
}