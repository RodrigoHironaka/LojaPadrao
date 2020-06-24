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
    public partial class frmConsultaCliente : Form
    {
        public int id = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            cbFiltroTipo.SelectedIndex = 1;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            cbStatus.SelectedIndex = 1;
            cbFiltroTipo.SelectedIndex = 1;
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloCliente modelo = bll.CarregaModeloCliente(id);
                frmCadastroCliente f = new frmCadastroCliente(modelo);
                f.ShowDialog();
                f.Dispose();
                dgvDados.DataSource = bll.CarregaGridAtivo();
                cbStatus.SelectedIndex = 1;
                cbFiltroTipo.SelectedIndex = 1;
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
                        BLLCliente bll = new BLLCliente(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDados.DataSource = bll.CarregaGridAtivo();
                        cbStatus.SelectedIndex = 1;
                        cbFiltroTipo.SelectedIndex = 1;
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

            if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 0))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
            }
            else if ((cbStatus.SelectedIndex == 2)&&(cbFiltroTipo.SelectedIndex == 0))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 1))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.LocalizarAtivoFisica(txtPesquisa.Text);
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 2))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.LocalizarAtivoJuridica(txtPesquisa.Text);
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 1))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.LocalizarInativoFisica(txtPesquisa.Text);
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 2))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.LocalizarInativoJuridica(txtPesquisa.Text);
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 0))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
            }
            
            if (txtPesquisa.Text == "")
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoFisica();
            }
           
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.CarregaGridAtivoFisica();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoFisica();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoFisica();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoJuridica();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoJuridica();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridFisica();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridJuridica();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGrid();
            }
        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoFisica();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoFisica();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoJuridica();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoJuridica();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridFisica();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridJuridica();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGrid();
            }
        }
    }
}
