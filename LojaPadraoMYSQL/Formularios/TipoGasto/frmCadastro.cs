using BLL.BLLTipoGasto;
using DAL;
using DAL.DALTipoGasto;
using Modelos.ModeloTipoGasto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.TipoGasto
{
    public partial class frmCadastro : LojaPadraoMYSQL.Formularios.Base.CadastrosSimples.frmCadastrosSimples
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        public frmCadastro(Modelo modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.Id);
            txtNome.Text = modelo.Nome;
            if (modelo.Status.Equals('A'))
                chkAtivo.Checked = true;
            else if (modelo.Status.Equals('I'))
                chkAtivo.Checked = false;
        }

        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            chkAtivo.Checked = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                CBLL dal = new CBLL(cx);
                Modelo modelo = new Modelo();
                modelo.Nome = txtNome.Text;
                if (chkAtivo.Checked)
                {
                    modelo.Status = Convert.ToChar("A");
                }
                else
                {
                    modelo.Status = Convert.ToChar("I");
                }

                if (txtID.Text == "")
                {
                    dal.Incluir(modelo);
                    this.LimpaTela();
                }
                else
                {
                    modelo.Id = int.Parse(txtID.Text);
                    dal.Alterar(modelo);
                }
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);
            }
        }
    }
}
