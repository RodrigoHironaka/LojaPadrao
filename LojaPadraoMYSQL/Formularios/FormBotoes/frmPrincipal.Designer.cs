﻿namespace LojaPadraoMYSQL.Formularios.FormBotoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pFormInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbHora = new System.Windows.Forms.Label();
            this.tDataHora = new System.Windows.Forms.Timer(this.components);
            this.lbData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pFormInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btInicio);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnCadastros);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 314);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btMinimizar);
            this.panel3.Controls.Add(this.lbTitulo);
            this.panel3.Controls.Add(this.btnDesligar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 45);
            this.panel3.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(206, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(96, 37);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "MENU";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pFormInfo
            // 
            this.pFormInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormInfo.AutoScroll = true;
            this.pFormInfo.AutoSize = true;
            this.pFormInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.pFormInfo.Controls.Add(this.panel2);
            this.pFormInfo.Location = new System.Drawing.Point(200, 43);
            this.pFormInfo.Name = "pFormInfo";
            this.pFormInfo.Size = new System.Drawing.Size(637, 419);
            this.pFormInfo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btMinimizar
            // 
            this.btMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btMinimizar.Image")));
            this.btMinimizar.Location = new System.Drawing.Point(744, 0);
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
            this.btnDesligar.Location = new System.Drawing.Point(789, 0);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(45, 45);
            this.btnDesligar.TabIndex = 0;
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btInicio
            // 
            this.btInicio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btInicio.FlatAppearance.BorderSize = 0;
            this.btInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.Color.White;
            this.btInicio.Image = ((System.Drawing.Image)(resources.GetObject("btInicio.Image")));
            this.btInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInicio.Location = new System.Drawing.Point(0, 264);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(200, 50);
            this.btInicio.TabIndex = 6;
            this.btInicio.Text = " Início";
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "                Configurações";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 150);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(200, 50);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "       Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "           Movimentos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "     Produtos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Vendas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbHora
            // 
            this.lbHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHora.AutoSize = true;
            this.lbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(125, 5);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(417, 108);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "00:00:00";
            // 
            // tDataHora
            // 
            this.tDataHora.Enabled = true;
            this.tDataHora.Interval = 1000;
            this.tDataHora.Tick += new System.EventHandler(this.tDataHora_Tick);
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbData.AutoSize = true;
            this.lbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.White;
            this.lbData.Location = new System.Drawing.Point(30, 113);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(581, 39);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "segunda-feira, 01 de Janeiro de 2021";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHora);
            this.panel2.Controls.Add(this.lbData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 179);
            this.panel2.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.pFormInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pFormInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pFormInfo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tDataHora;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Panel panel2;
    }
}