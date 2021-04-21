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
    public partial class frmConsultaDepartamento : Form
    {
        public void AtualizaCabecalhoGridDados()
        {
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "NOME";
            dgvDados.Columns[2].HeaderText = "SIT";
        }

        public void FiltroLocalizarDepoisIncluir(Int64 ultimoidInserido)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            Int64 id = bll.VerificaUltimoIdInserido();
            if (id != 0)
            {
                if (id == ultimoidInserido)
                {
                    dgvDados.DataSource = null;
                    pInfo.Visible = true;
                    txtPesquisa.Select();
                }
                else
                {
                    dgvDados.DataSource = bll.LocalizarUltimoItemInserido();
                    this.AtualizaCabecalhoGridDados();
                }
            }

        }

        public void FiltroLocalizarDepoisAlterar(Int64 idAlterado)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            if (idAlterado != 0)
            {
                dgvDados.DataSource = bll.LocalizarUltimoItemAlterar(idAlterado);
                this.AtualizaCabecalhoGridDados();
            }
        }

        public void VerificaBuscaGrid(int linhas)
        {
            if (linhas == 0)
            {
                dgvDados.DataSource = null;
                pInfo.Visible = true;
                lbInfo.Visible = true;
            }
            else
            {
                this.AtualizaCabecalhoGridDados();
            }
        }

        public void LimpaFiltro()
        {
            rbAtivos.Checked = true;
            pFiltro.Visible = false;
            txtPesquisa.Clear();
        }

        public int id = 0;
        
        public frmConsultaDepartamento()
        {
            InitializeComponent();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            pInfo.Visible = false;
            this.LimpaFiltro();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            var ultimoidinserido = bll.VerificaUltimoIdInserido();
            frmCadastroDepartamento f = new frmCadastroDepartamento();
            f.ShowDialog();
            this.FiltroLocalizarDepoisIncluir(ultimoidinserido);
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            pFiltro.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloDepartamento modelo = bll.CarregaModeloDepartamento(id);
                frmCadastroDepartamento f = new frmCadastroDepartamento(modelo);
                f.ShowDialog();
                f.Dispose();
                this.FiltroLocalizarDepoisAlterar(id);
            }
        }

        private void btExc_Click(object sender, EventArgs e)
        {
            pFiltro.Visible = false;
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
                        BLLDepartamento bll = new BLLDepartamento(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDados.DataSource = null;
                        pInfo.Visible = true;
                        //this.AtualizaCabecalhoGridDados();
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
            pInfo.Visible = false;
            if(txtPesquisa.Text == string.Empty)
            {
                dgvDados.DataSource = null;
                pInfo.Visible = true;
            }
            else
            {
                pInfo.Visible = false;
                if (rbAtivos.Checked)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLDepartamento bll = new BLLDepartamento(cx);
                    dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                    
                }
                else if (rbInativos.Checked)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLDepartamento bll = new BLLDepartamento(cx);
                    dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if (rbTodos.Checked)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLDepartamento bll = new BLLDepartamento(cx);
                    dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
            }
            
        }

        private void frmConsultaDepartamento_Load(object sender, EventArgs e)
        {
            
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

        private void frmConsultaDepartamento_KeyDown(object sender, KeyEventArgs e)
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

        private void frmConsultaDepartamento_KeyUp(object sender, KeyEventArgs e)
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

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            pInfo.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            dgvDados.DataSource = bll.CarregaGrid();
            this.AtualizaCabecalhoGridDados();
        }

        private void rbAtivos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            pInfo.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            this.AtualizaCabecalhoGridDados();
        }

        private void rbInativos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            pInfo.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            dgvDados.DataSource = bll.CarregaGridInativo();
            this.AtualizaCabecalhoGridDados();
        }
    }
}
