namespace LojaPadraoMYSQL.Formularios.FormBotoes
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pFormInfo = new System.Windows.Forms.Panel();
            this.pBotoesMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.tDataHora = new System.Windows.Forms.Timer(this.components);
            this.pPrincipal.SuspendLayout();
            this.pBotoesMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.pPrincipal.Controls.Add(this.pFormInfo);
            this.pPrincipal.Controls.Add(this.pBotoesMenu);
            this.pPrincipal.Controls.Add(this.panel3);
            this.pPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(877, 577);
            this.pPrincipal.TabIndex = 0;
            // 
            // pFormInfo
            // 
            this.pFormInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormInfo.AutoScroll = true;
            this.pFormInfo.AutoSize = true;
            this.pFormInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.pFormInfo.Location = new System.Drawing.Point(246, 51);
            this.pFormInfo.Name = "pFormInfo";
            this.pFormInfo.Size = new System.Drawing.Size(622, 515);
            this.pFormInfo.TabIndex = 3;
            // 
            // pBotoesMenu
            // 
            this.pBotoesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pBotoesMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pBotoesMenu.Controls.Add(this.button6);
            this.pBotoesMenu.Controls.Add(this.btInicio);
            this.pBotoesMenu.Controls.Add(this.btnCadastros);
            this.pBotoesMenu.Controls.Add(this.button3);
            this.pBotoesMenu.Location = new System.Drawing.Point(0, 45);
            this.pBotoesMenu.Name = "pBotoesMenu";
            this.pBotoesMenu.Size = new System.Drawing.Size(240, 532);
            this.pBotoesMenu.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(234, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "                Configurações";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btInicio
            // 
            this.btInicio.FlatAppearance.BorderSize = 0;
            this.btInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.Color.White;
            this.btInicio.Image = ((System.Drawing.Image)(resources.GetObject("btInicio.Image")));
            this.btInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInicio.Location = new System.Drawing.Point(3, 6);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(234, 50);
            this.btInicio.TabIndex = 1;
            this.btInicio.Text = " Início";
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(3, 62);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(234, 50);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "       Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "           Movimentos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbData);
            this.panel3.Controls.Add(this.lbHora);
            this.panel3.Controls.Add(this.btMinimizar);
            this.panel3.Controls.Add(this.btnDesligar);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 45);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME DA EMPRESA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.White;
            this.lbData.Location = new System.Drawing.Point(541, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(131, 29);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "01/01/1990";
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(678, 10);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(103, 29);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "00:00:00";
            // 
            // btMinimizar
            // 
            this.btMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btMinimizar.Image")));
            this.btMinimizar.Location = new System.Drawing.Point(787, 0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(45, 45);
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDesligar.FlatAppearance.BorderSize = 0;
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesligar.Image")));
            this.btnDesligar.Location = new System.Drawing.Point(832, 0);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(45, 45);
            this.btnDesligar.TabIndex = 0;
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tDataHora
            // 
            this.tDataHora.Enabled = true;
            this.tDataHora.Interval = 1000;
            this.tDataHora.Tick += new System.EventHandler(this.tDataHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.pBotoesMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tDataHora;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pBotoesMenu;
        public System.Windows.Forms.Panel pFormInfo;
    }
}