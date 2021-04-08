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

        public frmCadastroContaPagar()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            lbStatus.Text = Convert.ToString(SituacaoAPagar.Aberto).ToUpper();
            lbStatus.ForeColor = Color.White;
            chbUnica.Checked = true;
            cbTipoPessoa.SelectedIndex = 0;
            this.carregaFormaPagamento();
            this.carregaTipoGasto();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbUnica_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUnica.Checked)
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

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoPessoa.SelectedIndex == 0)
            {
                lbNome.Text = "Cliente:";
                txtCod.Clear();
                txtNomeEmpresa.Clear();
            }
            else if(cbTipoPessoa.SelectedIndex == 1)
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

        private void txtQtdParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQtdParcelas_Leave(object sender, EventArgs e)
        {
            if(txtQtdParcelas.Text == "")
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
            }else if((qtd == 0)||(qtd == 1))
            {
                txtQtdParcelas.Text = "0";
                txtQtdParcelas.ReadOnly = true;
                chbUnica.Checked = true;
                txtValor.Select();
            }
        }

        private void dtpVencimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataEmissao = Convert.ToDateTime(dtpEmissão.Text);
            DateTime dataVencimento = Convert.ToDateTime(dtpVencimento.Text);
            if (dataVencimento < dataEmissao)
            {
                MessageBox.Show("Data de vencimento não pode ser menor que a data de emissão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {
            try
            {
                if(cbTipoPessoa.SelectedIndex == 0)
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
                else if(cbTipoPessoa.SelectedIndex == 1)
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
            chbUnica.Checked = true;
            txtQtdParcelas.Text = "0";
            cbFormaPagamento.SelectedIndex = 0;
            cbTipoPessoa.SelectedIndex = 0;
            txtObs.Clear();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                ModeloContaPagar modelo = new ModeloContaPagar();
                
                if (txtNumDoc.Text != "")
                {
                    modelo.NumDoc = Convert.ToInt32(txtNumDoc.Text);
                }
                else
                {
                    modelo.NumDoc = 0;
                }
                modelo.Descricao = txtNome.Text;
                if(txtCod.Text != "")
                {
                    modelo.PessoaID = Convert.ToInt32(txtCod.Text);
                }
                else
                {
                    modelo.PessoaID = 1;
                }
                modelo.Valor = Convert.ToDecimal(txtValor.Text);
                modelo.Vencimento = dtpVencimento.Value;
                modelo.Emissão = dtpEmissão.Value;
                modelo.DataCadastro = txtDataCadastro.Text;
                modelo.TipoGastoID = Convert.ToInt32(cbTipoGasto.SelectedValue);
                if (lbStatus.Text == "ABERTO")
                {
                    modelo.Status = Convert.ToChar("A");
                }
                else if (lbStatus.Text == "PAGO")
                {
                    modelo.Status = Convert.ToChar("P");
                }
                else if (lbStatus.Text == "CANCELADO")
                {
                    modelo.Status = Convert.ToChar("C");
                }
                if (chbUnica.Checked)
                {
                    modelo.Unica = Convert.ToChar("S");
                }
                else
                {
                    modelo.Unica = Convert.ToChar("N");
                }
                modelo.QtdParcelas = Convert.ToInt32(txtQtdParcelas.Text);
                modelo.FormaPagamentoID = Convert.ToInt32(cbFormaPagamento.SelectedValue);
                modelo.TipoPessoa = cbTipoPessoa.Text;
                modelo.Observacao = txtObs.Text;

                BLLContasPagar bll = new BLLContasPagar(cx);

                if (txtID.Text == "")
                {
                    //incluir

                    //cadastra dados da tabela compra
                    int id = bll.Incluir(modelo);
                    this.Close();
                }
                else
                {
                    //Alterar

                    //Itens
                    modelo.ContaPagarID = Int32.Parse(txtID.Text);
                    bll.Alterar(modelo);

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

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                if(txtValor.Text == "") 
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

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQtdParcelas_KeyPress(sender, e);
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQtdParcelas_KeyPress(sender, e);
        }
    }
}
