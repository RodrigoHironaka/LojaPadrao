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

namespace LojaPadraoMYSQL.Formularios.ContasPagar
{
    public partial class frmConsultaContaPagar : Form
    {
        public void CarregaDadosEdicao(object sender, EventArgs e, int id)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            frmCadastroContaPagar f = new frmCadastroContaPagar();

            ModeloContaPagar modelo = bll.CarregaModeloContaPagar(id);
            f.txtID.Text = Convert.ToString(modelo.ContaPagarID);
            f.txtDataCadastro.Text = modelo.DataCadastro;
            f.txtNumDoc.Text = modelo.NumDoc.ToString();
            f.cbTipoGasto.SelectedValue = modelo.TipoGastoID.ToString();
            f.cbPeriodo.Text = modelo.Periodo;
            f.txtQtdParcelas.Text = modelo.QtdParcelas.ToString();
            f.txtValor.Text = modelo.Valor.ToString();
            f.txtNome.Text = modelo.Descricao;
            f.dtpEmissão.Format = DateTimePickerFormat.Custom;//deixo o datatimepicker livre para customizar
            f.dtpEmissão.CustomFormat = modelo.Emissão.ToString(); //aqui coloco a data da tabela no datatimepicker
            f.dtpVencimento.Format = DateTimePickerFormat.Custom;//deixo o datatimepicker livre para customizar
            f.dtpVencimento.CustomFormat = modelo.Vencimento.ToString(); //aqui coloco a data da tabela no datatimepicker
            f.cbTipoPessoa.Text = modelo.TipoPessoa;
            f.txtCod.Text = modelo.PessoaID.ToString();
            f.txtCod_Leave(sender, e);
            f.cbFormaPagamento.SelectedValue = modelo.FormaPagamentoID.ToString();
            f.txtObs.Text = modelo.Observacao;
            this.Opacity = 0;
            f.ShowDialog();
            this.Opacity = 1;
            f.Dispose();
        }

        public void AtualizaCabecalhoGridConsulta()
        {
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "DOC";
            dgvDados.Columns[2].HeaderText = "DESCRIÇÃO";
            dgvDados.Columns[3].HeaderText = "TIPO";
            dgvDados.Columns[4].HeaderText = "PESSOA";
            dgvDados.Columns[5].HeaderText = "VALOR";
            dgvDados.Columns[5].DefaultCellStyle.Format = "N2";
            dgvDados.Columns[6].HeaderText = "VENCIMENTO";
            dgvDados.Columns[7].HeaderText = "EMISSÃO";
            dgvDados.Columns[8].HeaderText = "CADASTRO";
            dgvDados.Columns[9].HeaderText = "TIPO GASTO";
            dgvDados.Columns[10].HeaderText = "SIT";
        }

        public void FiltroLocalizarUltimoIdAdd(int totallinhas, int ultimoid)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            var idNovo = bll.VerificaUltimoIdInserido();
            var tipo = bll.CarregaModeloContaPagar(Convert.ToInt32(idNovo));
            if (totallinhas == 0)
            {
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
                var idAnterior = ultimoid;
                if (idAnterior == idNovo)
                {
                    dgvDados.DataSource = null;
                    txtPesquisar.Select();

                }
                else
                {
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
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarTodos(txtPesquisar.Text);
            this.AtualizaCabecalhoGridConsulta();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }
       
        private void btAdd_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            var ultimoid= bll.VerificaUltimoIdInserido();
            int totallinhas = dgvDados.Rows.Count;
            frmCadastroContaPagar f = new frmCadastroContaPagar();
            this.Opacity = 0;
            f.ShowDialog();
            this.Opacity = 1;
            this.FiltroLocalizarUltimoIdAdd(totallinhas, ultimoid);
            

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Editar, carrega dados do item selecionado para o formd e cadastro
        public int id = 0;
        private void btEdt_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //id recebe o valor do codigo da linha selecionada no grid
                this.CarregaDadosEdicao(sender, e, id);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                dgvDados.DataSource = bll.Localizar();
            }
        }

        private void frmConsultaContaPagar_Load(object sender, EventArgs e)
        {
        }
    }
}
