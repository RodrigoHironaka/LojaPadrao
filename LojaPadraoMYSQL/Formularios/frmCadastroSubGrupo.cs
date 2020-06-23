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
    public partial class frmCadastroSubGrupo : Form
    {
        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            cbGrupo.Text = "";
            chkAtivo.Checked = true;
            
        }

        private void carregaGrupo()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubGrupo bll = new BLLSubGrupo(cx);
            cbGrupo.DataSource = bll.CarregaComboGrupo();
            cbGrupo.ValueMember = "id";
            cbGrupo.DisplayMember = "nome";
        }

        public frmCadastroSubGrupo()
        {
            InitializeComponent();
            this.carregaGrupo();
        }

        public frmCadastroSubGrupo(ModeloSubGrupo modelo)
        {
            InitializeComponent();
            this.carregaGrupo();

            txtID.Text = Convert.ToString(modelo.SubGrupoId);
            txtNome.Text = modelo.Nome;
            cbGrupo.SelectedValue = modelo.GrupoId.ToString();
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
                BLLSubGrupo dal = new BLLSubGrupo(cx);
                ModeloSubGrupo modelo = new ModeloSubGrupo();
                modelo.Nome = txtNome.Text;
                modelo.GrupoId = Convert.ToInt32(cbGrupo.SelectedValue);
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
                    modelo.SubGrupoId = int.Parse(txtID.Text);
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroGrupo f = new frmCadastroGrupo();
            f.ShowDialog();
            f.Dispose();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLGrupo bll = new BLLGrupo(cx);
            cbGrupo.DataSource = bll.Localizar("");
            cbGrupo.ValueMember = "id";
            cbGrupo.DisplayMember = "nNome";
            
        }
    }
}
