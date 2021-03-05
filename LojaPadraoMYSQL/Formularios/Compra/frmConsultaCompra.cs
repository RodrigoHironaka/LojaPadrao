using BLL;
using DAL;
using Modelos;
using Modelos.ObejtoValor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmConsultaCompra : Form
    {
        public int idcompraitens = 0;
        public int idcompra = 0;
        public int idproduto = 0;
        public int idformapagamento = 0;

        public frmConsultaCompra()
        {
            InitializeComponent();
            pFiltro.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvDados.DataSource = bll.Localizar();
            dgvDados.Select();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCompra f = new frmCadastroCompra();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvDados.DataSource = bll.Localizar();
            dgvDados.Select();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            pFiltro.Visible = true;
            
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllcompra = new BLLCompra(cx);
            BLLCompraItens bllitens = new BLLCompraItens(cx);
            BLLCompraPagamento bllpagamento = new BLLCompraPagamento(cx);
            frmCadastroCompra f = new frmCadastroCompra();
            try
            {
                if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //DADOS PRINCIPAIS DA COMPRA
                    this.idcompra = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid 
                    ModeloCompra modelocompra = bllcompra.CarregaModeloCompra(idcompra);
                    f.txtID.Text = modelocompra.CompraId.ToString();
                    f.txtDataCadastro.Text = modelocompra.DataCadastro.ToString();
                    f.txtNumNota.Text = modelocompra.NumNota.ToString();
                    f.dtpDataNota.Format = DateTimePickerFormat.Custom;//deixo o datatimepicker livre para customizar
                    f.dtpDataNota.CustomFormat = modelocompra.DataNota.ToString(); ;//aqui coloco a data da tabela no datatimepicker
                    f.txtPrecoNota.Text = modelocompra.PrecoNota.ToString();
                    f.txtObservacao.Text = modelocompra.Observacao;
                    f.txtCodFornecedor.Text = modelocompra.FornecedorId.ToString();
                    f.txtCodFornecedor_Leave(sender, e);
                    if (modelocompra.Status == 'A')
                    {
                        f.lbStatus.Text = SituacaoCompra.Aberto.ToString().ToUpper();
                        f.lbStatus.ForeColor = Color.Blue;
                    }
                    else if (modelocompra.Status == 'F')
                    {
                        f.lbStatus.Text = SituacaoCompra.Faturado.ToString().ToUpper();
                        f.lbStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        f.lbStatus.Text = SituacaoCompra.Cancelado.ToString().ToUpper();
                        f.lbStatus.ForeColor = Color.Red;
                    }

                    //DADOS DA TABELA COMPRAITENS
                    DataTable tabelaitens = bllitens.Localizar(Convert.ToInt32(modelocompra.CompraId));
                    for (int i = 0; i < tabelaitens.Rows.Count; i++)
                    {
                        string idproduto = tabelaitens.Rows[i]["id"].ToString();
                        string nomeproduto = tabelaitens.Rows[i]["nome"].ToString();
                        string custo = tabelaitens.Rows[i]["precoCusto"].ToString();
                        string pcusto = tabelaitens.Rows[i]["porcentagemCusto"].ToString();
                        string avista = tabelaitens.Rows[i]["precoAvista"].ToString();
                        string pavista = tabelaitens.Rows[i]["porcentagemAvista"].ToString();
                        string prazo = tabelaitens.Rows[i]["precoPrazo"].ToString();
                        string estatual = tabelaitens.Rows[i]["estAtual"].ToString();
                        string estnovo = tabelaitens.Rows[i]["estNovo"].ToString();
                        string esttotal = tabelaitens.Rows[i]["estTotal"].ToString();
                        String[] it = new String[] { idproduto, nomeproduto, custo, pcusto, avista, pavista, prazo, estatual, estnovo, esttotal };
                        f.dgvItens.Rows.Add(it);
                    }

                    //DADOS DA TABELA COMPRAPAGAMENTO
                    DataTable tabelapagamento = bllpagamento.Localizar(Convert.ToInt32(modelocompra.CompraId));
                    for (int i = 0; i < tabelapagamento.Rows.Count; i++)
                    {
                        string parcela = tabelapagamento.Rows[i]["id"].ToString();
                        string valor = tabelapagamento.Rows[i]["precoParcela"].ToString();
                        string dataparcela = tabelapagamento.Rows[i]["dataInicioPagamento"].ToString();
                        string formapag = tabelapagamento.Rows[i]["nome"].ToString();
                        String[] ip = new String[] { parcela, valor, dataparcela, formapag };
                        f.dgvParcelas.Rows.Add(ip);
                    }

                    //VERIFICA SE COMPRA ESTA FATURADA E/OU CANCELA PROIBINDO DE EDITAR
                    if ((f.lbStatus.Text == "FATURADO") || (f.lbStatus.Text == "CANCELADO"))
                    {
                        f.gbDadosCompra.Enabled = false;
                        f.gbParcelas.Enabled = false;
                        f.pItensProdutos.Enabled = false;
                        f.dgvItens.Enabled = false;
                        f.dgvItens.DefaultCellStyle.SelectionBackColor = Color.White;
                        f.dgvItens.DefaultCellStyle.SelectionForeColor = Color.Black;
                        f.dgvParcelas.Enabled = false;
                        f.dgvParcelas.DefaultCellStyle.SelectionBackColor = Color.White;
                        f.dgvParcelas.DefaultCellStyle.SelectionForeColor = Color.Black;
                        f.txtObservacao.Enabled = false;
                    }

                    //ABRE FORM DE CADASTRO COM DADOS EM SEUS CAMPOS
                    f.ShowDialog();
                    f.Dispose();

                    //QNDO VOLTAR PARA CONSULTA E VOLTA A CARREGAR OS GRIDS COM AS FUNÇÕES ABAIXOS DEPENDENDO DO FILTRO SELECIONADO
                    if (rbAberto.Checked)
                    {
                        dgvDados.DataSource = bllcompra.LocalizarAbertos(txtPesquisar.Text);
                        dgvDados.ClearSelection();
                    }
                    else if (rbTodos.Checked)
                    {
                        dgvDados.DataSource = bllcompra.LocalizarTodos(txtPesquisar.Text);
                        dgvDados.ClearSelection();
                    }
                    else if (rbFaturado.Checked)
                    {
                        dgvDados.DataSource = bllcompra.LocalizarFaturados(txtPesquisar.Text);
                        dgvDados.ClearSelection();
                    }
                    else if (rbCancelado.Checked)
                    {
                        dgvDados.DataSource = bllcompra.LocalizarCancelados(txtPesquisar.Text);
                        dgvDados.ClearSelection();
                    }
                    dgvDados.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: "+ex.ToString());
            }
            
        }

        private void btExc_Click(object sender, EventArgs e)
        {

        }
    }
}
