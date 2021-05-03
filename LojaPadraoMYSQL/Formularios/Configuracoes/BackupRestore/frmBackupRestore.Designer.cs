namespace LojaPadraoMYSQL.Formularios.Configuracoes.BackupRestore
{
    partial class frmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupRestore));
            this.pNomeForm = new System.Windows.Forms.Panel();
            this.lbNomeForm = new System.Windows.Forms.Label();
            this.rbBackup = new System.Windows.Forms.RadioButton();
            this.rbRestore = new System.Windows.Forms.RadioButton();
            this.pCampo = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btRealizar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbPorcentagem = new System.Windows.Forms.Label();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.pNomeForm.SuspendLayout();
            this.pCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNomeForm
            // 
            this.pNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNomeForm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pNomeForm.Controls.Add(this.lbNomeForm);
            this.pNomeForm.Location = new System.Drawing.Point(12, 0);
            this.pNomeForm.Name = "pNomeForm";
            this.pNomeForm.Size = new System.Drawing.Size(603, 36);
            this.pNomeForm.TabIndex = 18;
            // 
            // lbNomeForm
            // 
            this.lbNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeForm.AutoSize = true;
            this.lbNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeForm.ForeColor = System.Drawing.Color.White;
            this.lbNomeForm.Location = new System.Drawing.Point(202, 9);
            this.lbNomeForm.Name = "lbNomeForm";
            this.lbNomeForm.Size = new System.Drawing.Size(199, 24);
            this.lbNomeForm.TabIndex = 0;
            this.lbNomeForm.Text = "BACKUP E RESTORE";
            // 
            // rbBackup
            // 
            this.rbBackup.AutoSize = true;
            this.rbBackup.Checked = true;
            this.rbBackup.Location = new System.Drawing.Point(81, 9);
            this.rbBackup.Name = "rbBackup";
            this.rbBackup.Size = new System.Drawing.Size(81, 24);
            this.rbBackup.TabIndex = 19;
            this.rbBackup.TabStop = true;
            this.rbBackup.Text = "Backup";
            this.rbBackup.UseVisualStyleBackColor = true;
            this.rbBackup.CheckedChanged += new System.EventHandler(this.rbBackup_CheckedChanged);
            // 
            // rbRestore
            // 
            this.rbRestore.AutoSize = true;
            this.rbRestore.Location = new System.Drawing.Point(168, 9);
            this.rbRestore.Name = "rbRestore";
            this.rbRestore.Size = new System.Drawing.Size(84, 24);
            this.rbRestore.TabIndex = 20;
            this.rbRestore.Text = "Restore";
            this.rbRestore.UseVisualStyleBackColor = true;
            this.rbRestore.CheckedChanged += new System.EventHandler(this.rbRestore_CheckedChanged);
            // 
            // pCampo
            // 
            this.pCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pCampo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pCampo.Controls.Add(this.btSair);
            this.pCampo.Controls.Add(this.btRealizar);
            this.pCampo.Controls.Add(this.progressBar1);
            this.pCampo.Controls.Add(this.lbPorcentagem);
            this.pCampo.Controls.Add(this.rbBackup);
            this.pCampo.Controls.Add(this.btPesquisa);
            this.pCampo.Controls.Add(this.rbRestore);
            this.pCampo.Controls.Add(this.label1);
            this.pCampo.Controls.Add(this.txtCaminho);
            this.pCampo.Location = new System.Drawing.Point(12, 42);
            this.pCampo.Name = "pCampo";
            this.pCampo.Size = new System.Drawing.Size(603, 123);
            this.pCampo.TabIndex = 21;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(552, 66);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(48, 48);
            this.btSair.TabIndex = 22;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btRealizar
            // 
            this.btRealizar.FlatAppearance.BorderSize = 0;
            this.btRealizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btRealizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealizar.Image = ((System.Drawing.Image)(resources.GetObject("btRealizar.Image")));
            this.btRealizar.Location = new System.Drawing.Point(498, 66);
            this.btRealizar.Name = "btRealizar";
            this.btRealizar.Size = new System.Drawing.Size(48, 48);
            this.btRealizar.TabIndex = 21;
            this.btRealizar.UseVisualStyleBackColor = true;
            this.btRealizar.Click += new System.EventHandler(this.btRealizar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(483, 26);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // lbPorcentagem
            // 
            this.lbPorcentagem.AutoSize = true;
            this.lbPorcentagem.Location = new System.Drawing.Point(3, 94);
            this.lbPorcentagem.Name = "lbPorcentagem";
            this.lbPorcentagem.Size = new System.Drawing.Size(32, 20);
            this.lbPorcentagem.TabIndex = 3;
            this.lbPorcentagem.Text = "0%";
            this.lbPorcentagem.Visible = false;
            // 
            // btPesquisa
            // 
            this.btPesquisa.FlatAppearance.BorderSize = 0;
            this.btPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisa.Image")));
            this.btPesquisa.Location = new System.Drawing.Point(565, 34);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(35, 28);
            this.btPesquisa.TabIndex = 2;
            this.btPesquisa.Text = "...";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho";
            // 
            // txtCaminho
            // 
            this.txtCaminho.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCaminho.ForeColor = System.Drawing.Color.White;
            this.txtCaminho.Location = new System.Drawing.Point(7, 34);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(552, 26);
            this.txtCaminho.TabIndex = 0;
            this.txtCaminho.Text = "C:\\_Projetos\\DESKTOP\\LojaPadrao\\BD\\BACKUP";
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(628, 177);
            this.Controls.Add(this.pCampo);
            this.Controls.Add(this.pNomeForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackupRestore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pNomeForm.ResumeLayout(false);
            this.pNomeForm.PerformLayout();
            this.pCampo.ResumeLayout(false);
            this.pCampo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNomeForm;
        private System.Windows.Forms.Label lbNomeForm;
        private System.Windows.Forms.RadioButton rbBackup;
        private System.Windows.Forms.RadioButton rbRestore;
        private System.Windows.Forms.Panel pCampo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbPorcentagem;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btRealizar;
    }
}