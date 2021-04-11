using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.ContasPagar
{
    public partial class frmConsultaContaPagar : Form
    {
        public void AtualizaCabecalhoGridConsulta()
        {
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "DOC";
            dgvDados.Columns[2].HeaderText = "DESCRIÇÃO";
            dgvDados.Columns[3].HeaderText = "TIPO";
            dgvDados.Columns[4].HeaderText = "PESSOA";
            dgvDados.Columns[5].HeaderText = "VALOR";
            dgvDados.Columns[6].HeaderText = "VENCIMENTO";
            dgvDados.Columns[7].HeaderText = "EMISSÃO";
            dgvDados.Columns[8].HeaderText = "CADASTRO";
            dgvDados.Columns[9].HeaderText = "TIPO GASTO";
            dgvDados.Columns[10].HeaderText = "SIT";
            //dgvDados.Columns[10].Visible = false;
            //dgvDados.Columns[11].Visible = false;
            //dgvDados.Columns[12].Visible = false;
            //dgvDados.Columns[13].Visible = false;
            //dgvDados.Columns[14].Visible = false;

        }

        public frmConsultaContaPagar()
        {
            InitializeComponent();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.Localizar();
            dgvDados.Select();
            this.AtualizaCabecalhoGridConsulta();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            pFiltro.Visible = true;
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count == 0)
            {
                frmCadastroContaPagar f = new frmCadastroContaPagar();
                f.ShowDialog();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                var idNovo = bll.VerificaUltimoIdInserido();
                var tipo = bll.CarregaModeloContaPagar(Convert.ToInt32(idNovo));
                if (tipo.TipoPessoa == "CLIENTE")
                {
                    dgvDados.DataSource = bll.LocalizarCliente();
                    dgvDados.Select();
                    this.AtualizaCabecalhoGridConsulta();
                }
                else if (tipo.TipoPessoa == "FORNECEDOR")
                {
                    dgvDados.DataSource = bll.LocalizarFornecedor();
                    dgvDados.Select();
                    this.AtualizaCabecalhoGridConsulta();
                }

            }
            else
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                var idAnterior = bll.VerificaUltimoIdInserido();
                frmCadastroContaPagar f = new frmCadastroContaPagar();
                f.ShowDialog();
                var idNovo = bll.VerificaUltimoIdInserido();
                if (idAnterior == idNovo)
                {
                    dgvDados.DataSource = null;
                    txtPesquisar.Select();
                }
                else
                {
                    var tipo = bll.CarregaModeloContaPagar(Convert.ToInt32(idNovo));
                    if (tipo.TipoPessoa == "CLIENTE")
                    {
                        dgvDados.DataSource = bll.LocalizarCliente();
                        dgvDados.Select();
                        this.AtualizaCabecalhoGridConsulta();
                    }
                    else if (tipo.TipoPessoa == "FORNECEDOR")
                    {
                        dgvDados.DataSource = bll.LocalizarFornecedor();
                        dgvDados.Select();
                        this.AtualizaCabecalhoGridConsulta();
                    }
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
