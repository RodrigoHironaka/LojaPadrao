﻿using LojaPadraoMYSQL.Formularios.FormBotoes.Movimentos;
using LojaPadraoMYSQL.Formularios.FormBotoes.ObjetoValorForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.FormBotoes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            frmBotoesCadastros f = new frmBotoesCadastros();
            f.TopLevel = false;
            pFormInfo.Controls.Add(f);
            f.Show();
            lbTitulo.Text = TituloForms.CADASTROS.ToString();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            pFormInfo.Controls.Clear();
            lbTitulo.Text = TituloForms.MENU.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBotoesMovimentos f = new frmBotoesMovimentos();
            f.TopLevel = false;
            pFormInfo.Controls.Add(f);
            f.Show();
            lbTitulo.Text = TituloForms.MOVIMENTOS.ToString();
        }

        private void tDataHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = (DateTime.Now.ToLongTimeString());
            lbData.Text = (DateTime.Now.ToLongDateString());
        }
    }
}
