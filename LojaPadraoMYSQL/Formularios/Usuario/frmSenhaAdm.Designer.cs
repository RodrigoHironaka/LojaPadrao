namespace LojaPadraoMYSQL.Formularios
{
    partial class frmSenhaAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenhaAdm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaAdmin = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha Admin";
            // 
            // txtSenhaAdmin
            // 
            this.txtSenhaAdmin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtSenhaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAdmin.ForeColor = System.Drawing.Color.White;
            this.txtSenhaAdmin.Location = new System.Drawing.Point(16, 94);
            this.txtSenhaAdmin.Name = "txtSenhaAdmin";
            this.txtSenhaAdmin.Size = new System.Drawing.Size(286, 26);
            this.txtSenhaAdmin.TabIndex = 1;
            this.txtSenhaAdmin.UseSystemPasswordChar = true;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(163, 142);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.TabIndex = 3;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.FlatAppearance.BorderSize = 0;
            this.btConfirmar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkCyan;
            this.btConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(89, 142);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(50, 50);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAdmin.ForeColor = System.Drawing.Color.White;
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(16, 32);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(286, 26);
            this.txtUsuarioAdmin.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Usuário Admin";
            // 
            // frmSenhaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(314, 210);
            this.Controls.Add(this.txtUsuarioAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.txtSenhaAdmin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSenhaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSenhaAdm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSenhaAdm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaAdmin;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.Label label2;
    }
}