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
    public partial class frmCadastroCompra : Form
    {
        public frmCadastroCompra()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
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
    }
}
