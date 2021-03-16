namespace LojaPadraoMYSQL.Formularios
{
    partial class frmCadastroMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMarca));
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.pBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.Color.White;
            this.txtAno.Location = new System.Drawing.Point(264, 136);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(84, 26);
            this.txtAno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ano";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(16, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(122, 26);
            this.txtID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Código";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(59, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 5;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(3, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(50, 50);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(144, 34);
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
            this.txtNome.Location = new System.Drawing.Point(16, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(332, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.Location = new System.Drawing.Point(18, 136);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(240, 26);
            this.txtModelo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Modelo";
            // 
            // pBotoes
            // 
            this.pBotoes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBotoes.Controls.Add(this.btSair);
            this.pBotoes.Controls.Add(this.btSalvar);
            this.pBotoes.ForeColor = System.Drawing.Color.White;
            this.pBotoes.Location = new System.Drawing.Point(229, 12);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(119, 62);
            this.pBotoes.TabIndex = 35;
            // 
            // frmCadastroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(360, 178);
            this.Controls.Add(this.pBotoes);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAno);
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
            this.Name = "frmCadastroMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroMarca";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroMarca_KeyDown);
            this.pBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pBotoes;
    }
}