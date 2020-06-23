using BLL;
using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmCadastroFuncao : Form
    {
        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            chkAtivo.Checked = true;
        }
        public frmCadastroFuncao()
        {
            InitializeComponent();
        }

        public frmCadastroFuncao(ModeloFuncao modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.FuncaoId);
            txtNome.Text = modelo.Nome;
            txtDescricao.Text = modelo.Descricao;
            if (modelo.Status.Equals('A'))
                chkAtivo.Checked = true;
            else if (modelo.Status.Equals('I'))
                chkAtivo.Checked = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFuncao dal = new BLLFuncao(cx);
                ModeloFuncao modelo = new ModeloFuncao();
                modelo.Nome = txtNome.Text;
                modelo.Descricao = txtDescricao.Text;
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
                    modelo.FuncaoId = int.Parse(txtID.Text);
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
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);
            }
        }
    }
}
