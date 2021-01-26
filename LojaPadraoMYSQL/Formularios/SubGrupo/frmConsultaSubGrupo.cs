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
    public partial class frmConsultaSubGrupo : Form
    {
        public void AtualizaCabecalhoGridDados()
        {
            dgvDados.Columns[0].HeaderText = "Cod";
            dgvDados.Columns[1].HeaderText = "Sub-Grupo";
            dgvDados.Columns[2].HeaderText = "Grupo";
            dgvDados.Columns[3].HeaderText = "Sit";
        }
        public int id = 0;
        public frmConsultaSubGrupo()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            this.AtualizaCabecalhoGridDados();
        }

        public frmConsultaSubGrupo(bool selecao)
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubGrupo bll = new BLLSubGrupo(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            dgvDados.Select();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroSubGrupo f = new frmCadastroSubGrupo();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubGrupo bll = new BLLSubGrupo(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            cbStatus.SelectedIndex = 1;
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubGrupo bll = new BLLSubGrupo(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloSubGrupo modelo = bll.CarregaModeloSubGrupo(id);
                frmCadastroSubGrupo f = new frmCadastroSubGrupo(modelo);
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
                        BLLSubGrupo bll = new BLLSubGrupo(cx);
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
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
            }
        }

        private void frmConsultaSubGrupo_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubGrupo bll = new BLLSubGrupo(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
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

        private void frmConsultaSubGrupo_KeyDown(object sender, KeyEventArgs e)
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

        private void frmConsultaSubGrupo_KeyUp(object sender, KeyEventArgs e)
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
