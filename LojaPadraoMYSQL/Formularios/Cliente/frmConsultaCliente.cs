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
        public void AtualizaCabecalhoGridDados()
        {
            dgvDados.Columns[0].HeaderText = "Cod";
            dgvDados.Columns[1].HeaderText = "Nome Fantasia";
            dgvDados.Columns[2].HeaderText = "Razão Social";
            dgvDados.Columns[3].HeaderText = "RG/IE";
            dgvDados.Columns[4].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[5].HeaderText = "Pessoa";
            dgvDados.Columns[6].HeaderText = "Endereço";
            dgvDados.Columns[7].HeaderText = "Nº";
            dgvDados.Columns[8].HeaderText = "Complemento";
            dgvDados.Columns[9].HeaderText = "Bairro";
            dgvDados.Columns[10].HeaderText = "CEP";
            dgvDados.Columns[11].HeaderText = "Nascimento";
            dgvDados.Columns[12].Visible = false;
            dgvDados.Columns[13].HeaderText = "Email";
            dgvDados.Columns[14].HeaderText = "Telefone";
            dgvDados.Columns[15].HeaderText = "Celular";
            dgvDados.Columns[16].HeaderText = "Celular2";
            dgvDados.Columns[17].Visible = false;
            dgvDados.Columns[18].HeaderText = "Data Cadastro";
            dgvDados.Columns[19].HeaderText = "Sit";
            dgvDados.Columns[20].Visible = false;
        }
        public int id = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            cbFiltroTipo.SelectedIndex = 1;
            pFiltro.Visible = false;
            this.AtualizaCabecalhoGridDados();
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
            pFiltro.Visible = true;
            if (txtPesquisa.Text == "")
            {
                this.cbStatus_SelectedIndexChanged(sender, e);
                this.cbFiltroTipo_SelectedIndexChanged(sender, e);
            }
            else
            {
                if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 0))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();

                }
                else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 0))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();
                }
                else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 1))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarAtivoFisica(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();
                }
                else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 2))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarAtivoJuridica(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();
                }
                else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 1))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarInativoFisica(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();
                }
                else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 2))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarInativoJuridica(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();
                }
                else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 0))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
                    this.AtualizaCabecalhoGridDados();
                }
            } 
           
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //BLLCliente bll = new BLLCliente(cx);
            //dgvDados.DataSource = bll.CarregaGridAtivoFisica();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoFisica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoFisica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoJuridica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoJuridica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridFisica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridJuridica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGrid();
                this.AtualizaCabecalhoGridDados();
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
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativo(); 
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoFisica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoFisica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 1) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridAtivoJuridica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 2) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridInativoJuridica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 1))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridFisica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 2))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGridJuridica();
                this.AtualizaCabecalhoGridDados();
            }
            else if ((cbStatus.SelectedIndex == 0) && (cbFiltroTipo.SelectedIndex == 0))
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvDados.DataSource = bll.CarregaGrid();
                this.AtualizaCabecalhoGridDados();
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

        private void frmConsultaCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void frmConsultaCliente_KeyUp(object sender, KeyEventArgs e)
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

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }
    }
}
