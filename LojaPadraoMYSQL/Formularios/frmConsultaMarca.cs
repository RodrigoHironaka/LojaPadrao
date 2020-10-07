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
    public partial class frmConsultaMarca : Form
    {
        public int id = 0;
        public frmConsultaMarca()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
        }

        public frmConsultaMarca(bool selecao)
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMarca bll = new BLLMarca(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            dgvDados.Select();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroMarca f = new frmCadastroMarca();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMarca bll = new BLLMarca(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            cbStatus.SelectedIndex = 1;
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMarca bll = new BLLMarca(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloMarca modelo = bll.CarregaModeloMarca(id);
                frmCadastroMarca f = new frmCadastroMarca(modelo);
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
                        BLLMarca bll = new BLLMarca(cx);
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
                BLLMarca bll = new BLLMarca(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
            }
        }

        private void frmConsultaMarca_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMarca bll = new BLLMarca(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                dgvDados.DataSource = bll.CarregaGrid();
            }
        }
    }
}
