namespace LojaPadraoMYSQL.Formularios.FormBotoes.Relatorios.Financeiro
{
    partial class frmFinanceiroRelatorios
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
            this.pNomeForm = new System.Windows.Forms.Panel();
            this.lbNomeForm = new System.Windows.Forms.Label();
            this.pNomeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNomeForm
            // 
            this.pNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNomeForm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pNomeForm.Controls.Add(this.lbNomeForm);
            this.pNomeForm.Location = new System.Drawing.Point(11, 0);
            this.pNomeForm.Name = "pNomeForm";
            this.pNomeForm.Size = new System.Drawing.Size(626, 36);
            this.pNomeForm.TabIndex = 93;
            // 
            // lbNomeForm
            // 
            this.lbNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeForm.AutoSize = true;
            this.lbNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeForm.ForeColor = System.Drawing.Color.White;
            this.lbNomeForm.Location = new System.Drawing.Point(187, 9);
            this.lbNomeForm.Name = "lbNomeForm";
            this.lbNomeForm.Size = new System.Drawing.Size(262, 24);
            this.lbNomeForm.TabIndex = 0;
            this.lbNomeForm.Text = "RELATÓRIOS FINANCEIROS";
            // 
            // frmFinanceiroRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(649, 445);
            this.Controls.Add(this.pNomeForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFinanceiroRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinanceiroRelatorios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pNomeForm.ResumeLayout(false);
            this.pNomeForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNomeForm;
        private System.Windows.Forms.Label lbNomeForm;
    }
}