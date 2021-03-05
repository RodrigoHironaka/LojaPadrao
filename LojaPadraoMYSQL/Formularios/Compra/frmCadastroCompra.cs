using BLL;
using DAL;
using Modelos;
using Modelos.ObejtoValor;
using System;
using System.Collections;
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
    public partial class frmCadastroCompra : Form
    {
        public void AtualizaCabecalhoGridItens()
        {
            dgvItens.Columns[0].Visible = false;
            dgvItens.Columns[1].Visible = false;
            dgvItens.Columns[2].HeaderText = "Cod";
            dgvItens.Columns[3].HeaderText = "Produto";
            dgvItens.Columns[4].HeaderText = "Custo";
            dgvItens.Columns[5].HeaderText = "%";
            dgvItens.Columns[6].HeaderText = "Avista";
            dgvItens.Columns[7].HeaderText = "%";
            dgvItens.Columns[8].HeaderText = "Prazo";
            dgvItens.Columns[9].HeaderText = "EstAtual";
            dgvItens.Columns[10].HeaderText = "EstNovo";
            dgvItens.Columns[11].HeaderText = "EstTotal";
        }

        public void AtualizaCabecalhoGridParcelas()
        {
            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].HeaderText = "Valor";
            dgvParcelas.Columns[2].HeaderText = "Data";
            dgvParcelas.Columns[3].HeaderText = "F. Pagamento";
            
        }
        //--------------------CARREGACOMBO---------------------------------------------------------
        private void carregaFormaPagamento()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompraPagamento bll = new BLLCompraPagamento(cx);
            cbPagamento.DataSource = bll.CarregaComboFormaPagamento();
            cbPagamento.DisplayMember = "nome";
            cbPagamento.ValueMember = "id";

        }

        //--------------------ABRIR NA JANELA QNDO FOR INCLUIR-------------------------------------
        public frmCadastroCompra()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            lbStatus.Text = Convert.ToString(SituacaoCompra.Aberto).ToUpper();
            dtpDataNota.Format = DateTimePickerFormat.Custom;
            dtpDataNota.CustomFormat = " ";
            this.carregaFormaPagamento();
            this.AtualizaCabecalhoGridParcelas();
            
        }

        //--------------------ABRIR NA JANELA QNDO FOR ALTERAR-------------------------------------
        public frmCadastroCompra(ModeloCompra modelocompra)
        {
            InitializeComponent();
            
            ////carrega campos da tabela compra------------------------------------------------
            //txtID.Text = modelocompra.CompraId.ToString();
            //txtDataCadastro.Text = modelocompra.DataCadastro;
            //txtNumNota.Text = modelocompra.NumNota.ToString();
            //dtpDataNota.Format = DateTimePickerFormat.Custom;//deixo o datatimepicker livre para customizar
            //dtpDataNota.CustomFormat = modelocompra.DataNota.ToString(); ;//aqui coloco a data da tabela no datatimepicker
            //txtPrecoNota.Text = modelocompra.PrecoNota.ToString();
            //txtCodFornecedor.Text = modelocompra.FornecedorId.ToString();
            //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //if (txtCodFornecedor.Text != "")
            //{
            //    BLLFornecedor bll = new BLLFornecedor(cx);
            //    ModeloFornecedor modelofornecedor = bll.CarregaModeloFornecedor(Convert.ToInt32(modelocompra.FornecedorId));
            //    txtNomeFornecedor.Text = modelofornecedor.NomeFantasia;
            //}
            //else
            //{
            //    MessageBox.Show("Houve algum problema na hora de buscar os dados do fornecedor. Contate o suporte técnico", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //txtObservacao.Text = modelocompra.Observacao;
            //if (modelocompra.Status == 'A')
            //{
            //    lbStatus.Text = SituacaoCompra.Aberto.ToString().ToUpper();
            //    lbStatus.ForeColor = Color.Blue;
            //}
            //else if (modelocompra.Status == 'F')
            //{
            //    lbStatus.Text = SituacaoCompra.Faturado.ToString().ToUpper();
            //    lbStatus.ForeColor = Color.Green;
            //}
            //else
            //{
            //    lbStatus.Text = SituacaoCompra.Cancelado.ToString().ToUpper();
            //    lbStatus.ForeColor = Color.Red;
            //}
            ////-------------------fim tabela compra--------------------------------------

            ////carrega campos da tabela compraitens
            //dgvItens.Columns.Clear();
            //BLLCompraItens bllitens = new BLLCompraItens(cx);
            //DataTable itens = bllitens.Localizar(Convert.ToInt32(txtID.Text));
            //dgvItens.DataSource = itens;
            //this.AtualizaCabecalhoGridItens();
        }

        //--------------------BUSCAPORCODIGO---------------------------------------------------------
        //--------------------BOTAOPESQUISAR---------------------------------------------------------
        public void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtCodFornecedor.Text));
                if (modelo.FornecedorId <= 0)
                {
                    txtCodFornecedor.Clear();
                    txtNomeFornecedor.Clear();
                }
                else
                {
                    txtNomeFornecedor.Text = modelo.NomeFantasia;
                }

            }
            catch
            {
                txtCodFornecedor.Clear();
                txtNomeFornecedor.Clear();
            }
            lbCodFornecedor.ForeColor = Color.Black;
        }

        private void btPesqFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtCodFornecedor.Text = f.id.ToString();
                txtCodFornecedor_Leave(sender, e);
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtCodProduto.Text));
                if (modelo.ProdutoID <= 0)
                {
                    txtCodProduto.Clear();
                    txtNomeProduto.Clear();
                    txtPrecoCusto.Text = "0,00";
                    txtPorcCusto.Text = "0";
                    txtPrecoAvista.Text = "0,00";
                    txtPorcAvista.Text = "0";
                    txtPrecoPrazo.Text = "0,00";
                    txtEstqAtual.Text = "0,00";
                }
                else
                {
                    txtNomeProduto.Text = modelo.Nome.ToString();
                    txtPrecoCusto.Text = modelo.PrecoCusto.ToString();
                    txtPorcCusto.Text = modelo.PorcentagemCusto.ToString();
                    txtPrecoAvista.Text = modelo.PrecoAvista.ToString();
                    txtPorcAvista.Text = modelo.PorcentagemAvista.ToString();
                    txtPrecoPrazo.Text = modelo.PrecoPrazo.ToString();
                    txtEstqAtual.Text = modelo.EstoqueAtual.ToString();
                }

            }
            catch
            {
                txtCodProduto.Clear();
                txtNomeProduto.Clear();
                txtPrecoCusto.Text = "0,00";
                txtPorcCusto.Text = "0";
                txtPrecoAvista.Text = "0,00";
                txtPorcAvista.Text = "0";
                txtPrecoPrazo.Text = "0,00";
                txtEstqAtual.Text = "0,00";
            }
        }

        private void btPesqProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtCodProduto.Text = f.id.ToString();
                txtCodProduto_Leave(sender, e);
            }
        }

        //--------------------CAMPO CODIDO SOMENTE NUMEROS--------------------------------------------
        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodFornecedor_KeyPress(sender, e);
        }

        //--------------------CAMPO VALORES NUMEROS E VIRGULAS----------------------------------------
        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPorcCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPorcAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtEstqAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtQtdFracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtQtdNova_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        //--------------------SELECIONA TODO O CAMPO QNDO CLICADO-------------------------------------
        private void txtQtdNova_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectionStart = 0;
            ((TextBox)sender).SelectAll();
        }

        private void txtQtdFracao_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtEstqAtual_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtPrecoPrazo_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtPorcAvista_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtPrecoAvista_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtPorcCusto_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtPrecoCusto_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtCodProduto_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtCodFornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        //--------------------VALIDAÇÃO E CALCULO DE PRECOS E PORCENTAGENS---------------------------
        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoCusto.Text == "")
                {
                    txtPrecoCusto.Text = "0,00";
                }
                else
                {
                    double custo = Convert.ToDouble(txtPrecoCusto.Text);
                    txtPrecoCusto.Text = custo.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPorcCusto_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                double custo = Convert.ToDouble(txtPrecoCusto.Text);
                double porcCusto = Convert.ToDouble(txtPorcCusto.Text);
                if ((porcCusto == 0) || (txtPorcCusto.TextLength <= 0))
                {
                    txtPrecoAvista.Text = custo.ToString("N2");
                }
                else
                {
                    txtPrecoAvista.Text = bll.CalculaPorPorcentagem(custo, porcCusto).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecoAvista_Leave(object sender, EventArgs e)
        {
            if (txtPrecoAvista.Text == String.Empty)
            {
                txtPrecoAvista.Text = txtPrecoCusto.Text;
            }
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            double avista = Convert.ToDouble(txtPrecoAvista.Text);
            double custo = Convert.ToDouble(txtPrecoCusto.Text);
            txtPrecoAvista.Text = avista.ToString("N2");
            try
            {
                if (avista != 0)
                {
                    if (custo != 0)
                    {
                        txtPorcCusto.Text = bll.CalculaRegraDeTresPorcentagem(custo, avista).ToString("N2");
                    }
                    else
                    {
                        txtPorcCusto.Text = "0";
                    }
                }
                else
                {
                    txtPrecoAvista.Text = txtPrecoCusto.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPorcAvista_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                double avista = Convert.ToDouble(txtPrecoAvista.Text);
                double porcAvista = Convert.ToDouble(txtPorcAvista.Text);
                if ((porcAvista == 0) || (txtPorcAvista.TextLength <= 0))
                {
                    txtPrecoPrazo.Text = avista.ToString("N2");
                }
                else
                {
                    txtPrecoPrazo.Text = bll.CalculaPorPorcentagem(avista, porcAvista).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecoPrazo_Leave(object sender, EventArgs e)
        {
            if (txtPrecoPrazo.Text == String.Empty)
            {
                txtPrecoPrazo.Text = txtPrecoAvista.Text;
            }
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            double prazo = Convert.ToDouble(txtPrecoPrazo.Text);
            double avista = Convert.ToDouble(txtPrecoAvista.Text);
            txtPrecoPrazo.Text = prazo.ToString("N2");
            try
            {
                if (prazo != 0)
                {
                    if (avista != 0)
                    {
                        txtPorcAvista.Text = bll.CalculaRegraDeTresPorcentagem(avista, prazo).ToString("N2");
                    }
                    else
                    {
                        txtPorcAvista.Text = "0";
                    }
                }
                else
                {
                    txtPrecoPrazo.Text = txtPrecoAvista.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--------------------BOTAO ZERAR ESTOQUE----------------------------------------------------
        private void brZerarEstoque_Click(object sender, EventArgs e)
        {
            txtEstqAtual.Text = "0";
        }

        //--------------------CAMPO CODIDO SOMENTE NUMEROS-------------------------------------------
        private void txtNumNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodFornecedor_KeyPress(sender, e);
        }

        //--------------------CAMPO VALORES NUMEROS E VIRGULAS----------------------------------------
        private void txtPrecoNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoNota_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoNota.Text == "")
                {
                    txtPrecoNota.Text = "0,00";
                }
                else
                {
                    decimal preconota = Convert.ToDecimal(txtPrecoNota.Text);
                    txtPrecoNota.Text = preconota.ToString("N2");
                    if (cbQtdParcelas.Text == "0")
                    {
                        txtPrecoParcela.Text = preconota.ToString("N2");
                    }
                    else
                    {
                        int qtdparc = Convert.ToInt32(cbQtdParcelas.Text);
                        decimal resultado = preconota / qtdparc;
                        txtPrecoParcela.Text = resultado.ToString("N2");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lbPrecoNota.ForeColor = Color.Black;
        }

        //--------------------CAMPO SELECIONA PAGAMENTO E MOSTRA QTD DE PARCELAS----------------------
        private void cbPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ModeloFormaPagamento modelo = new ModeloFormaPagamento();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFormaPagamento bll = new BLLFormaPagamento(cx);

                int idpagamento = Convert.ToInt32(cbPagamento.SelectedValue);
                var recebe = bll.CarregaModeloFormaPagamento(idpagamento);

                if (recebe.QtdParcelas == 0)
                {
                    cbQtdParcelas.DataSource = null;
                    cbQtdParcelas.Items.Add("1");
                    cbQtdParcelas.SelectedIndex = 0;
                    cbQtdParcelas.Enabled = false;
                    dtpDataInicioPagamento.Enabled = false;
                }
                else
                {
                    cbQtdParcelas.DataSource = null;
                    cbQtdParcelas.Enabled = true;
                    dtpDataInicioPagamento.Enabled = true;
                    cbQtdParcelas.DataSource = Enumerable.Range(1, recebe.QtdParcelas).ToList();
                }
            }
            catch
            {

            }
        }

        //--------------------DATAS-------------------------------------------------------------------
        private void dtpDataNota_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDataNota.Format = DateTimePickerFormat.Custom;
                dtpDataNota.CustomFormat = "dd/MM/yyyy";
                if (dtpDataNota.CustomFormat == " ")
                {
                    dtpDataNota.Text = System.DateTime.Now.ToShortDateString();
                }
                else
                {
                    DateTime data = Convert.ToDateTime(dtpDataNota.Text);
                    if (data > System.DateTime.Now)
                    {
                        MessageBox.Show("Data inválida para compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpDataNota.Format = DateTimePickerFormat.Custom;
                        dtpDataNota.CustomFormat = " ";
                    }
                }
            }
            catch (Exception)
            {
                dtpDataNota.Text = System.DateTime.Now.ToShortDateString();
            }

        }

        private void dtpDataInicioPagamento_ValueChanged(object sender, EventArgs e)
        {
            //this.dtpDataInicioPagamento.MaxDate = DateTime.Today.AddDays(-1);
            //this.dtpDataInicioPagamento.MinDate = DateTimePicker.MinimumDateTime;
            try
            {
                //dtpDataInicioPagamento.Format = DateTimePickerFormat.Custom;
                //dtpDataInicioPagamento.CustomFormat = "dd/MM/yyyy";
                DateTime data = Convert.ToDateTime(dtpDataInicioPagamento.Text);
                DateTime dataatual = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                if (data < dataatual)
                {
                    MessageBox.Show("Data inválida para pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //dtpDataInicioPagamento.Format = DateTimePickerFormat.Custom;
                    //dtpDataInicioPagamento.CustomFormat = " ";
                    dtpDataInicioPagamento.Text = System.DateTime.Now.ToShortDateString();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //--------------------SELECIONA TODO O CAMPO QNDO CLICADO-------------------------------------
        //--------------------CAMPO VALORES NUMEROS E VIRGULAS----------------------------------------
        private void txtPrecoParcela_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoParcela.Text == "")
                {
                    txtPrecoParcela.Text = "0,00";
                }
                else
                {
                    double custo = Convert.ToDouble(txtPrecoParcela.Text);
                    txtPrecoParcela.Text = custo.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecoParcela_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void txtPrecoParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoNota_MouseClick(object sender, MouseEventArgs e)
        {
            txtQtdNova_MouseClick(sender, e);
        }

        private void dtpDataNota_Leave(object sender, EventArgs e)
        {
            dtpDataNota_ValueChanged(sender, e);
        }

        private void dtpDataInicioPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtpDataInicioPagamento_ValueChanged(sender, e);
        }

        //--------------------VARIAVEIS GRIDITENS-----------------------------------------------------


        public double totalItens = 0;
        public double totalQtd = 0;

        //--------------------SOMA VALORES COLUNAS---------------------------------
        private void SomaColunas()
        {
            decimal tcusto = 0;
            decimal tavista = 0;
            decimal tprazo = 0;
            foreach (DataGridViewRow col in dgvItens.Rows)
            {
                tcusto += Convert.ToDecimal(col.Cells[2].Value);
                tavista += Convert.ToDecimal(col.Cells[4].Value);
                tprazo += Convert.ToDecimal(col.Cells[6].Value);
            }
            txtTotalCusto.Text = tcusto.ToString("N2");
            txtTotalAvista.Text = tavista.ToString("N2");
            txtTotalPrazo.Text = tprazo.ToString("N2");
            txtTotalItens.Text = dgvItens.Rows.Count.ToString();
        }

        //--------------------SOMA VALORES E ITENS E ADICIONA NO GRID---------------------------------
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCodProduto.Text != "") && (txtQtdNova.Text != "") && (txtPrecoCusto.Text != "") && (txtPrecoAvista.Text != "") && (txtPrecoPrazo.Text != ""))
                {
                    Double totalLocalCusto = Convert.ToDouble(txtQtdNova.Text) * Convert.ToDouble(txtPrecoCusto.Text);
                    Double totalLocalAvista = Convert.ToDouble(txtQtdNova.Text) * Convert.ToDouble(txtPrecoAvista.Text);
                    Double totalLocalPrazo = Convert.ToDouble(txtQtdNova.Text) * Convert.ToDouble(txtPrecoPrazo.Text);

                    this.totalQtd = Convert.ToDouble(txtEstqAtual.Text) + Convert.ToDouble(txtQtdNova.Text);
                    String[] i = new String[] {
                       txtCodProduto.Text,
                       txtNomeProduto.Text,
                       txtPrecoCusto.Text,
                       txtPorcCusto.Text,
                       txtPrecoAvista.Text,
                       txtPorcAvista.Text,
                       txtPrecoPrazo.Text,
                       txtEstqAtual.Text,
                       txtQtdNova.Text,
                       totalQtd.ToString()
                    };
                    this.dgvItens.Rows.Add(i);

                    txtCodProduto.Clear();
                    txtNomeProduto.Clear();
                    txtPrecoCusto.Text = "0,00";
                    txtPorcCusto.Text = "0";
                    txtPrecoAvista.Text = "0,00";
                    txtPorcAvista.Text = "0";
                    txtPrecoPrazo.Text = "0,00";
                    txtEstqAtual.Text = "0";
                    txtQtdNova.Text = "0";

                    this.SomaColunas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //--------------------SUBTRAI VALORES E ITENS E REMOVE NO GRID--------------------------------
        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dgvItens.Rows.Remove(dgvItens.CurrentRow);
                txtTotalCusto.Clear();
                txtTotalAvista.Clear();
                txtTotalPrazo.Clear();
                this.SomaColunas();

            }
        }

        //--------------------DIVIDE TOTAL DA COMPRA PELA QTD DEFINIDA NO COMBO-----------------------
        private void cbQtdParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

            int qtdp = Convert.ToInt32(cbQtdParcelas.SelectedItem);
            decimal totalnota = Convert.ToDecimal(txtPrecoNota.Text);

            if (qtdp != 0)
            {
                decimal precoparcela = totalnota / qtdp;
                txtPrecoParcela.Text = precoparcela.ToString("N2");
            }
            else
            {
                txtPrecoParcela.Text = totalnota.ToString("N2");
            }

        }

        //--------------------GERAR PARCELAS----------------------------------------------------------
        private void btGerarParcela_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodFornecedor.Text == "")
                {
                    MessageBox.Show("Informe um código válido para o Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbCodFornecedor.ForeColor = Color.Red;
                    //lbCodFornecedor.Font = new Font(lbCodFornecedor.Font, FontStyle.Bold);
                    return;
                }
                else
                {
                    lbCodFornecedor.ForeColor = Color.Black;
                }
                if (Convert.ToDecimal(txtPrecoNota.Text) <= 0)
                {
                    MessageBox.Show("Informe um valor válido para o preço da nota", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbPrecoNota.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    lbPrecoNota.ForeColor = Color.Black;
                }
                dgvParcelas.Rows.Clear();

                int parcelas = Convert.ToInt32(cbQtdParcelas.Text);
                Decimal preconota = Convert.ToDecimal(txtPrecoNota.Text);
                Decimal precoparcela = Convert.ToDecimal(txtPrecoParcela.Text);
                Decimal dif = preconota - (precoparcela * parcelas);

                DateTime dt = new DateTime();
                dt = dtpDataInicioPagamento.Value;
                string nomepagamento = cbPagamento.Text;
                var dia = dt.Day;
                for (int i = 1; i <= parcelas; i++)
                {
                    if (dif < 0)
                    {
                        precoparcela = precoparcela + dif;
                        dif = 0;
                    }
                    else if (dif > 0)
                    {
                        precoparcela = precoparcela + dif;
                        dif = 0;
                    }
                    else
                    {
                        precoparcela = Convert.ToDecimal(txtPrecoParcela.Text);
                        dif = 0;
                    }

                    String[] k = new String[] { i.ToString(), precoparcela.ToString(), dt.ToShortDateString(), nomepagamento };
                    this.dgvParcelas.Rows.Add(k);
                    if (dt.Month != 12)
                    {
                        var ano = dt.Year;
                        var mes = dt.Month + 1;

                        var ultimodiames = DateTime.DaysInMonth(ano, mes);
                        if (ultimodiames < dia)
                        {
                            dt = new DateTime(ano, mes, ultimodiames);

                        }
                        else
                        {
                            dt = new DateTime(ano, mes, dia);
                        }
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dia);
                    }

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Verifique os campos da tela de venda");
                MessageBox.Show(ex.ToString());
            }

        }

        //--------------------BOTAO PARA REMOVER TODAS AS PARCELAS DO GRID----------------------------
        private void btRemoverParcela_Click(object sender, EventArgs e)
        {
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
        }

        //--------------------BLOQUEIA EDIÇÃO DAS CELULAS DO DATAGRIDVIEW-----------------------------
        private void dgvParcelas_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn dc in dgvParcelas.Columns)
            {
                if (dc.Index.Equals(0))
                {
                    dc.ReadOnly = true;
                }
                else
                {
                    dc.ReadOnly = false;
                }
            }
        }

        //--------------------SALVA DADOS DA COMPRAS, ITENS, PARCELAS EM SUAS TABELAS-----------------
        private void btSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                ModeloCompra modelocompra = new ModeloCompra();
                modelocompra.DataCadastro = txtDataCadastro.Text;
                if (txtNumNota.Text != "")
                {
                    modelocompra.NumNota = Convert.ToInt32(txtNumNota.Text);
                }
                else
                {
                    modelocompra.NumNota = 0;
                }
                modelocompra.DataNota = dtpDataNota.Value;
                modelocompra.PrecoNota = Convert.ToDecimal(txtPrecoNota.Text);
                if (lbStatus.Text == "ABERTO")
                {
                    modelocompra.Status = Convert.ToChar("A");
                }
                else if (lbStatus.Text == "FATURADO")
                {
                    modelocompra.Status = Convert.ToChar("F");
                }
                else if (lbStatus.Text == "CANCELADO")
                {
                    modelocompra.Status = Convert.ToChar("C");
                }
                if (txtCodFornecedor.Text != "")
                {
                    modelocompra.FornecedorId = Convert.ToInt32(txtCodFornecedor.Text);
                }
                else
                {
                    modelocompra.FornecedorId = 1;
                }
                modelocompra.Observacao = txtObservacao.Text;
                BLLCompra bllcompra = new BLLCompra(cx);

                ModeloCompraItens modelocompraitens = new ModeloCompraItens();
                BLLCompraItens bllcompraitens = new BLLCompraItens(cx);

                ModeloCompraPagamento modelocomprapagamento = new ModeloCompraPagamento();
                BLLCompraPagamento bllcomprapagamento = new BLLCompraPagamento(cx);

                if (txtID.Text == "")
                {
                    //incluir

                    //cadastra dados da tabela compra
                    int idcompra = bllcompra.Incluir(modelocompra);

                    //cadastra od itens(produtos, valores, estoque) na tabela de compra itens
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        modelocompraitens.CompraItensId = i + 1;
                        modelocompraitens.CompraId = idcompra;
                        modelocompraitens.ProdutoId = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        modelocompraitens.PrecoCusto = Convert.ToDecimal(dgvItens.Rows[i].Cells[2].Value);
                        modelocompraitens.PorcentagemCusto = Convert.ToDecimal(dgvItens.Rows[i].Cells[3].Value);
                        modelocompraitens.PrecoAvista = Convert.ToDecimal(dgvItens.Rows[i].Cells[4].Value);
                        modelocompraitens.PorcentagemAvista = Convert.ToDecimal(dgvItens.Rows[i].Cells[5].Value);
                        modelocompraitens.PrecoPrazo = Convert.ToDecimal(dgvItens.Rows[i].Cells[6].Value);
                        modelocompraitens.EstAtual = Convert.ToDecimal(dgvItens.Rows[i].Cells[7].Value);
                        modelocompraitens.EstNovo = Convert.ToDecimal(dgvItens.Rows[i].Cells[8].Value);
                        modelocompraitens.EstTotal = Convert.ToDecimal(dgvItens.Rows[i].Cells[9].Value);
                        modelocompraitens.TotalItens = Convert.ToInt32(txtTotalItens.Text);
                        modelocompraitens.TotalCusto = Convert.ToDecimal(txtTotalCusto.Text);
                        modelocompraitens.TotalAvista = Convert.ToDecimal(txtTotalAvista.Text);
                        modelocompraitens.TotalPrazo = Convert.ToDecimal(txtTotalPrazo.Text);
                        bllcompraitens.Incluir(modelocompraitens);
                        //tenho que criar uma trigger ou classe com função para alterar o estoque e valores modificados aqui na tabela produtos

                    }

                    //cadastra as parcelas(divididas ou não) na tabela de compra pagamento
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        modelocomprapagamento.CompraPagamentoId = i + 1;
                        modelocomprapagamento.CompraId = idcompra;
                        modelocomprapagamento.PrecoParcela = Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value);
                        modelocomprapagamento.DataInicioPagamento = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        modelocomprapagamento.FormaPagamentoId = Convert.ToInt32(cbPagamento.SelectedValue);
                        bllcomprapagamento.Incluir(modelocomprapagamento);
                    }
                }
                else
                {
                    //Alterar

                    //Itens
                    modelocompra.CompraId = Int32.Parse(txtID.Text);
                    bllcompra.Alterar(modelocompra);
                    bllcompraitens.ExcluirTodosItens(Convert.ToInt32(modelocompra.CompraId));

                    //cadastrar itens da OS
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        //modelocompraitens.CompraItensId = i + 1;
                        //modelocompraitens.IdOS = modeloOS.IdOS;
                        //modelocompraitens.IdServico = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        //modelocompraitens.Detalhes = dgvItens.Rows[i].Cells[2].Value.ToString();
                        bllcompraitens.Incluir(modelocompraitens);
                    }

                    //Pagamentos
                    modelocompra.CompraId = Int32.Parse(txtID.Text);
                    bllcompra.Alterar(modelocompra);
                    bllcomprapagamento.ExcluirTodosItens(Convert.ToInt32(modelocompra.CompraId));

                    //cadastrar pagamentos da OS
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        //modelocomprapagamento.CompraItensId = i + 1;
                        //modelocomprapagamento.IdOS = modeloOS.IdOS;
                        //modelocomprapagamento.IdServico = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        //modelocomprapagamento.Detalhes = dgvItens.Rows[i].Cells[2].Value.ToString();
                        bllcomprapagamento.Incluir(modelocomprapagamento);
                    }

                    MessageBox.Show("Cadastro Alterado com sucesso!!!");
                    this.Close();

                }
                this.LimpaTela();
                cx.TerminarTransacao();
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cx.CancelaTransacao();
                cx.Desconectar();
            }

        }

        //--------------------FUNCAO PARA LIMPAR OS CAMPOS--------------------------------------------
        public void LimpaTela()
        {
            txtID.Clear();
            txtNumNota.Clear();
            dtpDataNota.Text = System.DateTime.Now.ToShortDateString();
            txtPrecoNota.Text = "0,00";
            txtCodFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtPrecoCusto.Text = "0,00";
            txtPorcCusto.Text = "0";
            txtPrecoAvista.Text = "0,00";
            txtPorcAvista.Text = "0";
            txtPrecoPrazo.Text = "0,00";
            txtEstqAtual.Text = "0";
            txtQtdNova.Text = "0";
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            txtTotalItens.Text = "0";
            txtTotalCusto.Text = "0,00";
            txtTotalAvista.Text = "0,00";
            txtTotalPrazo.Text = "0,00";
            cbPagamento.SelectedIndex = 0;
            cbQtdParcelas.Text = "1";
            dtpDataInicioPagamento.Text = System.DateTime.Now.ToShortDateString();
            txtPrecoParcela.Text = "0,00";
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
            txtObservacao.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbStatus.Text == "ABERTO")
                {
                    DialogResult resultado = MessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                        this.Close();
                }
                else if ((lbStatus.Text == "FATURADO")|| (lbStatus.Text == "CANCELADO"))
                {
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);
            }
        }
    }
}
