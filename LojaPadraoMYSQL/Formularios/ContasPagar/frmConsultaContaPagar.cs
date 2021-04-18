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
            dgvDados.Columns[3].HeaderText = "PESSOA";
            dgvDados.Columns[4].HeaderText = "VALOR";
            dgvDados.Columns[5].HeaderText = "VENCIMENTO";
            dgvDados.Columns[6].HeaderText = "EMISSÃO";
            dgvDados.Columns[7].HeaderText = "CADASTRO";
            dgvDados.Columns[8].HeaderText = "TIPO GASTO";
            dgvDados.Columns[9].HeaderText = "SIT";

        }

        public void FiltroLocalizarDepoisIncluir(Int64 ultimoidInserido)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            Int64 id = bll.VerificaUltimoIdInserido();
            //Int64 ultimoId = Convert.ToInt64(ultimoidInserido);
            if (id != 0)
            {
                if (id == ultimoidInserido)
                {
                    dgvDados.DataSource = null;
                    txtPesquisar.Select();
                }
                else
                {
                    dgvDados.DataSource = bll.LocalizarUltimoItemInserido();
                    this.AtualizaCabecalhoGridConsulta();
                }
            }

        }
        public void FiltroLocalizarDepoisAlterar(Int64 idAlterado)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            if (id != 0)
            {
                dgvDados.DataSource = bll.LocalizarUltimoItemInserido();
                this.AtualizaCabecalhoGridConsulta();
            }

        }

        public frmConsultaContaPagar()
        {
            InitializeComponent();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarPorDataAtual();
            dgvDados.Select();
            this.AtualizaCabecalhoGridConsulta();

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            pFiltro.Visible = true;

            if (rbTodos.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                dgvDados.DataSource = bll.LocalizarTodos(txtPesquisar.Text);
            }
            else if (rbPago.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                dgvDados.DataSource = bll.LocalizarPagos(txtPesquisar.Text);
            }
            else if (rbPendente.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                dgvDados.DataSource = bll.LocalizarPendentes(txtPesquisar.Text);
            }
            else if (rbCancelado.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                dgvDados.DataSource = bll.LocalizarCancelados(txtPesquisar.Text);
            }
            //dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);
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
            var ultimoidinserido = bll.VerificaUltimoIdInserido();
            frmCadastroContaPagar f = new frmCadastroContaPagar();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
            this.FiltroLocalizarDepoisIncluir(ultimoidinserido);

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Editar, carrega dados do item selecionado para o form de cadastro
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
                this.FiltroLocalizarDepoisAlterar(id);
            }
        }

        //FILTRO DE RADIOBUTTON STATUS-----------------------------------------------------------------------
        private void frmConsultaContaPagar_Load(object sender, EventArgs e)
        {
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarTodos(txtPesquisar.Text);
        }

        private void rbPago_CheckedChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarPagos(txtPesquisar.Text);
        }

        private void rbPendente_CheckedChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarPendentes(txtPesquisar.Text);
        }

        private void rbCancelado_CheckedChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarCancelados(txtPesquisar.Text);
        }

        //LIMPA FILTRO E RETORNA BUSCA POR DATA ATUAL PENDENTE------------------------------------------------
        public void LimpaFiltro()
        {
            rbPendente.Checked = true;
            cbTipoBuscaData.SelectedIndex = 0;
            cbPessoa.SelectedIndex = 0;
            dtpInicio.Value = System.DateTime.Now;
            dtpFinal.Value = System.DateTime.Now;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            dgvDados.DataSource = bll.LocalizarPorDataAtual();
            dgvDados.Select();
            this.AtualizaCabecalhoGridConsulta();
        }
        private void btLimpaFiltro_Click(object sender, EventArgs e)
        {
            this.LimpaFiltro();
        }

        //FECHA PAINEL DE FILTRO E RETORNA BUSCA POR DATA ATUAL PENDENTE--------------------------------------
        private void btFecharPanelFiltro_Click(object sender, EventArgs e)
        {
            pFiltro.Visible = false;
            this.LimpaFiltro();
        }
    }
}
