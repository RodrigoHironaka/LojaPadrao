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

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmCadastroCompra : Form
    {
        public frmCadastroCompra()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            lbStatus.Text = Convert.ToString(SituacaoCompra.Aberto).ToUpper();
        }

        private void tpageDadosPrincipais_Click(object sender, EventArgs e)
        {

        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
            monthCal.Visible = true;
        }

        private void monthCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDataNota.Text = Convert.ToString(monthCal.SelectionStart.Date.ToShortDateString());
            DateTime datanasc = Convert.ToDateTime(txtDataNota.Text);
            if (datanasc > System.DateTime.Now)
            {
                MessageBox.Show("Data inválida para compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDataNota.Text = "";
            }
            monthCal.Visible = false;
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
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

        private void brZerarEstoque_Click(object sender, EventArgs e)
        {
            txtEstqAtual.Text = "0";
        }

        private void txtNumNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodFornecedor_KeyPress(sender, e);
        }

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
                    double preconota = Convert.ToDouble(txtPrecoNota.Text);
                    txtPrecoNota.Text = preconota.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void monthCal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
