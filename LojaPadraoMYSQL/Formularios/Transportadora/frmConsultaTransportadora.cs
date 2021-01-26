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

namespace LojaPadraoMYSQL.Formularios.Transportadora
{
    public partial class frmConsultaTransportadora : Form
    {
        public void AtualizaCabecalhoGridItens()
        {
            dgvDados.Columns[0].HeaderText = "Cod";
            dgvDados.Columns[1].HeaderText = "Responsável";
            dgvDados.Columns[2].HeaderText = "Nome Fantasia";
            dgvDados.Columns[3].HeaderText = "Razão Social";
            dgvDados.Columns[4].HeaderText = "IE";
            dgvDados.Columns[5].HeaderText = "CNPJ";
            dgvDados.Columns[6].HeaderText = "Endereço";
            dgvDados.Columns[7].HeaderText = "Nº";
            dgvDados.Columns[8].HeaderText = "Complemento";
            dgvDados.Columns[9].HeaderText = "Bairro";
            dgvDados.Columns[10].HeaderText = "CEP";
            dgvDados.Columns[11].Visible = false;
            dgvDados.Columns[12].HeaderText = "E-mail";
            dgvDados.Columns[13].HeaderText = "Telefone";
            dgvDados.Columns[14].HeaderText = "Celular";
            dgvDados.Columns[15].HeaderText = "Celular2";
            dgvDados.Columns[16].Visible = false;
            dgvDados.Columns[17].HeaderText = "Cadastro";
            dgvDados.Columns[18].HeaderText = "Sit";
            dgvDados.Columns[19].Visible = false;
        }
        public int id = 0;

        public frmConsultaTransportadora()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            this.AtualizaCabecalhoGridItens();
        }

        public frmConsultaTransportadora(bool selecao)
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransportadora bll = new BLLTransportadora(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            dgvDados.Select();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroTransportadora f = new frmCadastroTransportadora();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransportadora bll = new BLLTransportadora(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            cbStatus.SelectedIndex = 1;
            
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransportadora bll = new BLLTransportadora(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloTransportadora modelo = bll.CarregaModeloTransportadora(id);
                frmCadastroTransportadora f = new frmCadastroTransportadora(modelo);
                f.ShowDialog();
                f.Dispose();
                dgvDados.DataSource = bll.CarregaGridAtivo();
                cbStatus.SelectedIndex = 1;

            }
        }

        private void btExc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult d = MessageBox.Show("Deseja excluir o Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLTransportadora bll = new BLLTransportadora(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDados.DataSource = bll.CarregaGridAtivo();
                        cbStatus.SelectedIndex = 1;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo usado em outro local");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransportadora bll = new BLLTransportadora(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransportadora bll = new BLLTransportadora(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransportadora bll = new BLLTransportadora(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransportadora bll = new BLLTransportadora(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransportadora bll = new BLLTransportadora(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransportadora bll = new BLLTransportadora(cx);
                dgvDados.DataSource = bll.CarregaGrid();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaTransportadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyValue.Equals(27)) //ESC
            {
                btSair_Click(sender, e);
            }
        }

        private void frmConsultaTransportadora_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btAdd_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btEdt_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btExc_Click(sender, e);
            }
        }
    }
}
