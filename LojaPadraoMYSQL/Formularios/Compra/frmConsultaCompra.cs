using BLL;
using DAL;
using LojaPadraoMYSQL.Relatorios.Compra;
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
        public void AtualizaCabecalhoGridConsulta()
        {
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "CADASTRO";
            dgvDados.Columns[2].HeaderText = "Nº NOTA";
            dgvDados.Columns[3].HeaderText = "EMISSÃO";
            dgvDados.Columns[4].HeaderText = "VALOR NOTA";
            dgvDados.Columns[5].HeaderText = "Nº FORN";
            dgvDados.Columns[6].HeaderText = "FORNECEDOR";
            dgvDados.Columns[7].HeaderText = "SIT";
            //dgvDados.Columns[8].Visible = false;
            //dgvDados.Columns[9].Visible = false;
            //dgvDados.Columns[10].Visible = false;
            //dgvDados.Columns[11].Visible = false;
            //dgvDados.Columns[13].Visible = false;
        }

        public frmConsultaCompra()
        {
            InitializeComponent();
            pFiltro.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvDados.DataSource = bll.Localizar();
            dgvDados.Select();
            this.AtualizaCabecalhoGridConsulta();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCompra f = new frmCadastroCompra();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvDados.DataSource = bll.Localizar();
            dgvDados.Select();
            this.AtualizaCabecalhoGridConsulta();
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
                    f.txtTotalItens.Text = modelocompra.TotalItens.ToString();
                    f.txtTotalCusto.Text = modelocompra.TotalCusto.ToString();
                    f.txtTotalAvista.Text = modelocompra.TotalAvista.ToString();
                    f.txtTotalPrazo.Text = modelocompra.TotalPrazo.ToString();
                    if (modelocompra.Status == 'A')
                    {
                        f.lbStatus.Text = SituacaoCompra.Aberto.ToString().ToUpper();
                        f.lbStatus.ForeColor = Color.White;
                    }
                    else if (modelocompra.Status == 'F')
                    {
                        f.lbStatus.Text = SituacaoCompra.Faturado.ToString().ToUpper();
                        f.lbStatus.ForeColor = Color.Lime;
                    }
                    else
                    {
                        f.lbStatus.Text = SituacaoCompra.Cancelado.ToString().ToUpper();
                        f.lbStatus.ForeColor = Color.LightCoral;
                    }

                    //DADOS DA TABELA COMPRAITENS
                    DataTable tabelaitens = bllitens.Localizar(Convert.ToInt32(modelocompra.CompraId));
                    for (int i = 0; i < tabelaitens.Rows.Count; i++)
                    {
                        string idproduto = tabelaitens.Rows[i]["idProduto"].ToString();
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
                        string parcela = tabelapagamento.Rows[i]["NParcela"].ToString();
                        string valor = tabelapagamento.Rows[i]["precoParcela"].ToString();
                        DateTime dataparcela = Convert.ToDateTime(tabelapagamento.Rows[i]["dataInicioPagamento"].ToString());
                        string data = dataparcela.ToString("dd/MM/yyyy");
                        string formapag = tabelapagamento.Rows[i]["nome"].ToString();
                        String[] ip = new String[] { parcela, valor, data, formapag };
                        f.dgvParcelas.Rows.Add(ip);
                    }

                    //VERIFICA SE COMPRA ESTA FATURADA E/OU CANCELA PROIBINDO DE EDITAR
                    if ((f.lbStatus.Text == "FATURADO") || (f.lbStatus.Text == "CANCELADO"))
                    {
                        f.gbDadosCompra.Enabled = false;
                        f.gbParcelas.Enabled = false;
                        f.pItensProdutos.Enabled = false;
                        f.dgvItens.Enabled = false;
                        f.dgvItens.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
                        f.dgvItens.DefaultCellStyle.SelectionForeColor = Color.White;
                        f.dgvParcelas.Enabled = false;
                        f.dgvParcelas.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
                        f.dgvParcelas.DefaultCellStyle.SelectionForeColor = Color.White;
                        f.txtObservacao.Enabled = false;
                        f.btFaturar.Enabled = false;
                        f.btSalvar.Enabled = false;
                    }

                    //ABRE FORM DE CADASTRO COM DADOS EM SEUS CAMPOS
                    f.ShowDialog();
                    f.Dispose();

                    //QNDO VOLTAR PARA CONSULTA E VOLTA A CARREGAR OS GRIDS COM AS FUNÇÕES ABAIXOS DEPENDENDO DO FILTRO SELECIONADO
                    if (rbAberto.Checked)
                    {
                        dgvDados.DataSource = bllcompra.Localizar();
                        dgvDados.ClearSelection();
                    }
                    else if (rbTodos.Checked)
                    {
                        dgvDados.DataSource = bllcompra.Localizar();
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
                    this.AtualizaCabecalhoGridConsulta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: "+ex.ToString());
            }
            
        }

        private void btExc_Click(object sender, EventArgs e)
        {
            try
            {
                //Cancelando
                var sit = " ";
                if (dgvDados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                   sit = Convert.ToString(dgvDados.CurrentRow.Cells[3].Value);
                    if (sit == "CANCELADO")
                    {
                        MessageBox.Show("Esse registro já foi cancelado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    DialogResult d = MessageBox.Show("Deseja realmente cancelar este registro? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLCompra bll = new BLLCompra(cx);
                        if (bll.Cancelar(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value)) == true)
                        {
                            MessageBox.Show("Cancelada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvDados.DataSource = bll.Localizar();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel cancelar. \nConsulte o suporte tecnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvDados.ClearSelection();
                        this.AtualizaCabecalhoGridConsulta();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            frmFiltroRelCompra f = new frmFiltroRelCompra();
            f.ShowDialog();
        }
    }
}
