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
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "NOME";
            dgvDados.Columns[2].HeaderText = "RAZÃO";
            dgvDados.Columns[3].HeaderText = "RG/IE";
            dgvDados.Columns[4].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[5].HeaderText = "PESSOA";
            dgvDados.Columns[6].HeaderText = "ENDEREÇO";
            dgvDados.Columns[7].HeaderText = "Nº";
            dgvDados.Columns[8].HeaderText = "COMPLEMENTO";
            dgvDados.Columns[9].HeaderText = "BAIRRO";
            dgvDados.Columns[10].HeaderText = "CEP";
            dgvDados.Columns[11].HeaderText = "NASCIMENTO";
            dgvDados.Columns[12].Visible = false;
            dgvDados.Columns[13].HeaderText = "EMAIL";
            dgvDados.Columns[14].HeaderText = "TELEFONE";
            dgvDados.Columns[15].HeaderText = "CELULAR";
            dgvDados.Columns[16].HeaderText = "CELULAR2";
            dgvDados.Columns[17].Visible = false;
            dgvDados.Columns[18].HeaderText = "CADASTRO";
            dgvDados.Columns[19].HeaderText = "SITUAÇÃO";
            dgvDados.Columns[20].Visible = false;
        }

        public void FiltroLocalizarDepoisIncluir(Int64 ultimoidInserido)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            Int64 id = bll.VerificaUltimoIdInserido();
            //Int64 ultimoId = Convert.ToInt64(ultimoidInserido);
            if (id != 0)
            {
                if (id == ultimoidInserido)
                {
                    dgvDados.DataSource = null;
                    pInfo.Visible = true;
                    //lbInfo.Visible = true;
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
            BLLCliente bll = new BLLCliente(cx);

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
            rbFisica.Checked = true;
            dtpInicio.Value = System.DateTime.Now;
            dtpFinal.Value = System.DateTime.Now;
            pFiltro.Visible = false;
            txtPesquisa.Clear();
        }

        public void LimpaFiltroSemFechar()
        {
            rbAtivos.Checked = true;
            rbFisica.Checked = true;
            dtpInicio.Value = System.DateTime.Now;
            dtpFinal.Value = System.DateTime.Now;
           
        }

       

        public int id = 0;

        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        public frmConsultaCliente(bool selecao)
        {
            InitializeComponent();
            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            dgvDados.Select();
            this.AtualizaCabecalhoGridDados();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            pInfo.Visible = false;
            pFiltro.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            var ultimoidinserido = bll.VerificaUltimoIdInserido();
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            this.FiltroLocalizarDepoisIncluir(ultimoidinserido);
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            pInfo.Visible = false;
            pFiltro.Visible = false;
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
                this.FiltroLocalizarDepoisAlterar(id);
            }
        }

        private void btExc_Click(object sender, EventArgs e)
        {
            pInfo.Visible = false;
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
                        BLLCliente bll = new BLLCliente(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDados.DataSource = null;
                        
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
            if (txtPesquisa.Text == string.Empty)
            {
                dgvDados.DataSource = null;
                pInfo.Visible = true;
            }
            else
            {
                pInfo.Visible = false;
                if ((rbTodos.Checked) && (rbTodosTipo.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbAtivos.Checked) && (rbFisica.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarAtivoFisica(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);

                }
                else if ((rbInativos.Checked) && (rbFisica.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarInativoFisica(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbTodos.Checked) && (rbFisica.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarFisica(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbAtivos.Checked) && (rbJuridica.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarAtivoJuridica(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbInativos.Checked) && (rbJuridica.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarInativoJuridica(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbTodos.Checked) && (rbJuridica.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarJuridica(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbAtivos.Checked) && (rbTodosTipo.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }
                else if ((rbInativos.Checked) && (rbTodosTipo.Checked))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
                    int linhas = dgvDados.Rows.Count;
                    this.VerificaBuscaGrid(linhas);
                }

            } 
           
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
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

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btLimpaFiltro_Click(object sender, EventArgs e)
        {
            this.LimpaFiltroSemFechar();
        }

        private void btFecharPanelFiltro_Click(object sender, EventArgs e)
        {
            this.LimpaFiltro();
        }

        private void dgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgvDados.Rows[e.RowIndex];
            if(row.Cells["status"].Value.ToString() == "I")
            {
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
                row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            }
        }
    }
}
