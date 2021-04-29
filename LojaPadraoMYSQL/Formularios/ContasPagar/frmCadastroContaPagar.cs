using BLL;
using DAL;
using Modelos;
using Modelos.ObejtoValor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.ContasPagar
{
    public partial class frmCadastroContaPagar : Form
    {
        //--------------------CARREGA FORM---------------------------------------------------------
        public void IniciaComForm()
        {
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            lbStatus.Text = Convert.ToString(SituacaoAPagar.Pendente).ToUpper();
            lbStatus.ForeColor = Color.White;
            cbTipoPessoa.SelectedIndex = 0;
            cbPeriodo.SelectedIndex = 0;
            this.carregaFormaPagamento();
            this.carregaTipoGasto();
            

        }

        //--------------------CARREGACOMBO---------------------------------------------------------
        private void carregaFormaPagamento()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            cbFormaPagamento.DataSource = bll.CarregaComboFormaPagamento();
            cbFormaPagamento.DisplayMember = "nome";
            cbFormaPagamento.ValueMember = "id";

        }

        private void carregaTipoGasto()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            cbTipoGasto.DataSource = bll.CarregaComboTipoGasto();
            cbTipoGasto.DisplayMember = "nome";
            cbTipoGasto.ValueMember = "id";

        }

        //--------------------INICIALIZA FORM------------------------------------------------------
        public frmCadastroContaPagar()
        {
            InitializeComponent();
            this.IniciaComForm();
        }

        //--------------------SAIR-----------------------------------------------------------------
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------CAMPO PARA DEFINIR SE É CLIENTE OU FORNECEDOR------------------------
        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                lbNome.Text = "Cliente:";
                txtCod.Clear();
                txtNomeEmpresa.Clear();
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                lbNome.Text = "Fornecedor:";
                txtCod.Clear();
                txtNomeEmpresa.Clear();
            }
            else
            {
                MessageBox.Show("Escolha uma tipo de pessoa para continuar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //--------------------SOMENTE NUMERO-------------------------------------------------------
        private void txtQtdParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQtdParcelas_KeyPress(sender, e);
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQtdParcelas_KeyPress(sender, e);
        }

        //--------------------VERIFICAR SE QTD É MUITO ALTA OU SE É 0 OU 1-------------------------
        private void txtQtdParcelas_Leave(object sender, EventArgs e)
        {
            if (txtQtdParcelas.Text == "")
            {
                txtQtdParcelas.Text = "0";
            }
            int qtd = Convert.ToInt32(txtQtdParcelas.Text);
            if (qtd >= 50)
            {
                DialogResult d = MessageBox.Show("A quantidade de parcelas é muito alta. Deseja continuar assim mesmo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "No")
                {
                    txtQtdParcelas.Select();
                    return;
                }
            }
            else if ((qtd == 0) || (qtd == 1))
            {
                txtQtdParcelas.Text = "0";
                txtQtdParcelas.ReadOnly = true;
                cbPeriodo.SelectedIndex = 0;
                txtValor.Select();
            }
        }

        //--------------------IMPEDE DE COLOCAR DATA DE VENCIMENTO MENOR QUE DATA DE EMISSÃO-------
        private void dtpVencimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataEmissao = Convert.ToDateTime(dtpEmissão.Text);
            DateTime dataVencimento = Convert.ToDateTime(dtpVencimento.Text);
            if (dataVencimento < dataEmissao)
            {
                MessageBox.Show("Data de vencimento não pode ser menor que a data de emissão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //--------------------BUSCA POR CODIGO DO CLIENTE OU FORNECEDOR----------------------------
        public void txtCod_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cbTipoPessoa.SelectedIndex == 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    ModeloCliente modelocliente = bll.CarregaModeloCliente(Convert.ToInt32(txtCod.Text));
                    if (modelocliente.ClienteId <= 0)
                    {
                        txtCod.Clear();
                        txtNomeEmpresa.Clear();
                    }
                    else
                    {
                        txtNomeEmpresa.Text = modelocliente.NomeFantasia;
                    }
                }
                else if (cbTipoPessoa.SelectedIndex == 1)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    ModeloFornecedor modelofornecedor = bll.CarregaModeloFornecedor(Convert.ToInt32(txtCod.Text));
                    if (modelofornecedor.FornecedorId <= 0)
                    {
                        txtCod.Clear();
                        txtNomeEmpresa.Clear();
                    }
                    else
                    {
                        txtNomeEmpresa.Text = modelofornecedor.NomeFantasia;
                    }
                }
            }
            catch
            {
                txtCod.Clear();
                txtNomeEmpresa.Clear();
            }
        }

        //--------------------ABRE FORM CLIENTE OU FORNCEDOR PARA SELECIONAR-----------------------
        private void btPesqFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipoPessoa.SelectedIndex == 0)
                {
                    frmConsultaCliente f = new frmConsultaCliente(true);
                    f.ShowDialog();
                    if (f.id != 0)
                    {
                        txtCod.Text = f.id.ToString();
                        txtCod_Leave(sender, e);
                    }
                }
                else if (cbTipoPessoa.SelectedIndex == 1)
                {
                    frmConsultaFornecedor f = new frmConsultaFornecedor(true);
                    f.ShowDialog();
                    if (f.id != 0)
                    {
                        txtCod.Text = f.id.ToString();
                        txtCod_Leave(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                txtCod.Clear();
                txtNome.Clear();
            }
        }

        //--------------------LIMPA TELA-----------------------------------------------------------
        public void LimpaTela()
        {
            txtID.Clear();
            txtNumDoc.Clear();
            txtNome.Clear();
            txtCod.Text = "0,00";
            txtNomeEmpresa.Clear();
            txtValor.Clear();
            dtpVencimento.Text = System.DateTime.Now.ToShortDateString();
            dtpEmissão.Text = System.DateTime.Now.ToShortDateString();
            txtDataCadastro.Clear();
            cbTipoGasto.SelectedIndex = 0;
            lbStatus.Text = "Aberto";
            cbPeriodo.SelectedIndex = 0;
            txtQtdParcelas.Text = "0";
            cbFormaPagamento.SelectedIndex = 0;
            cbTipoPessoa.SelectedIndex = 0;
            txtObs.Clear();
        }

        //--------------------CARREGA DADOS DIGITADOS NO FORM PARA CLASSE MODELO-------------------
        public ModeloContaPagar CarregaDadosFormParaModelo()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            var IdInterno = bll.GeraIdInterno();
            ModeloContaPagar modelo = new ModeloContaPagar();
            //veriifca se numero do documento esta em branco e preenche com zero se ele estiver
            if (txtNumDoc.Text != "")
            {
                modelo.NumDoc = Convert.ToInt32(txtNumDoc.Text);
            }
            else
            {
                modelo.NumDoc = IdInterno;
            }
            //veriifca se id cliente/fornecedor esta em branco e preenche com 1 se ele estiver
            if (txtCod.Text != "")
            {
                modelo.PessoaID = Convert.ToInt32(txtCod.Text);
            }
            else
            {
                modelo.PessoaID = 1;
            }
            modelo.Descricao = txtNome.Text;
            modelo.Valor = Convert.ToDecimal(txtValor.Text);
            modelo.Total = Convert.ToDecimal(txtValor.Text);
            modelo.Vencimento = dtpVencimento.Value;
            modelo.Emissão = dtpEmissão.Value;
            modelo.DataCadastro = txtDataCadastro.Text;
            modelo.TipoGastoID = Convert.ToInt32(cbTipoGasto.SelectedValue);
            modelo.Status = lbStatus.Text;
            modelo.Periodo = cbPeriodo.SelectedItem.ToString();
            modelo.QtdParcelas = Convert.ToInt32(txtQtdParcelas.Text);
            modelo.FormaPagamentoID = Convert.ToInt32(cbFormaPagamento.SelectedValue);
            modelo.TipoPessoa = cbTipoPessoa.Text;
            modelo.Observacao = txtObs.Text;
            modelo.IdInterno = IdInterno;
            return modelo;
        }

        //--------------------ANTES DE INCLUIR ELE FAZ ALGUMA VERIFICAÇÕES-------------------------
        public void VerificaAntesIncluir()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasPagar bll = new BLLContasPagar(cx);
            ModeloContaPagar modelo = this.CarregaDadosFormParaModelo();
            
            try
            {
                int qtd = modelo.QtdParcelas;

                if (qtd == 0)
                {
                    //cadastra dados da tabela contapagar apenas 1 vez
                    bll.Incluir(modelo);
                    this.Close();
                }
                else
                {
                    if (modelo.Descricao == "")//faço essa verificaçao fora do BLL pq ele salva descrição somente com 1/3 por exemplo
                    {
                        MessageBox.Show("A descrição deve ser prenchida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Select();
                        return;
                    }
                    else
                    {
                        //cadastra a qtd definida
                        int periodo = cbPeriodo.SelectedIndex;
                        decimal valor = modelo.Valor;
                        string des = modelo.Descricao;
                        var descricao = " ";

                        for (int i = 1; i <= qtd; i++)
                        {
                            descricao = des + " " + i + "/" + qtd;
                            modelo.Descricao = descricao;
                            if (periodo == 1)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int dias = Convert.ToInt32(PeriodoDias.Diario);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddDays(dias);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 2)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int dias = Convert.ToInt32(PeriodoDias.Semanal);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddDays(dias);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 3)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int dias = Convert.ToInt32(PeriodoDias.Quinzenal);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddDays(dias);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 4)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int meses = Convert.ToInt32(PeriodoMes.Mensal);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddMonths(meses);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 5)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int meses = Convert.ToInt32(PeriodoMes.Bimestral);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddMonths(meses);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 6)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int meses = Convert.ToInt32(PeriodoMes.Timestral);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddMonths(meses);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 7)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    int meses = Convert.ToInt32(PeriodoMes.Semestral);
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddMonths(meses);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }

                            }
                            else if (periodo == 8)
                            {
                                if (i == 1)
                                {
                                    modelo.Vencimento = dtpVencimento.Value;
                                    var valorComDiferenca = bll.CalculoComDiferenca(valor, qtd);
                                    modelo.Valor = valorComDiferenca;
                                    bll.Incluir(modelo);
                                }
                                else
                                {
                                    modelo.Vencimento = dtpVencimento.Value = dtpVencimento.Value.AddYears(1);
                                    var valorSemDiferenca = bll.CalculoSemDiferenca(valor, qtd);
                                    modelo.Valor = valorSemDiferenca;
                                    bll.Incluir(modelo);
                                }
                            }
                        }
                        
                    }
                }
                this.LimpaTela();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }

        //--------------------SALVAR INCLUIR OU ALTERAR--------------------------------------------
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                //incluir
                this.VerificaAntesIncluir();
                
            }
            else
            {
                //Alterar
            }

        }

        //--------------------VERIFICA SE VALOR ESTA EM BRANCO E DEFINI DUAS CASA DEPOIS DA VIRGULA
        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text == "")
                {
                    txtValor.Text = "0,00";
                    cbFormaPagamento.Select();
                }
                else
                {
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    txtValor.Text = valor.ToString("N2");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //--------------------SOMENTE NUMERO E VIRGULA---------------------------------------------
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        //--------------------VERIFICA TIPO DE PERIODO SELECIONADO---------------------------------
        private void cbPeriodo_Leave(object sender, EventArgs e)
        {
            if (cbPeriodo.SelectedIndex == 0)
            {
                txtQtdParcelas.Text = "0";
                txtQtdParcelas.ReadOnly = true;

            }
            else
            {
                txtQtdParcelas.Clear();
                txtQtdParcelas.ReadOnly = false;
                txtQtdParcelas.Select();
            }
        }
    }
}
