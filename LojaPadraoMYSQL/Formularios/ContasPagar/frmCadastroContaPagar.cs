using BLL;
using DAL;
using Modelos;
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
        public frmCadastroContaPagar()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            chbUnica.Checked = true;
            cbTipoPessoa.SelectedIndex = 0;
            
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
    }
}
