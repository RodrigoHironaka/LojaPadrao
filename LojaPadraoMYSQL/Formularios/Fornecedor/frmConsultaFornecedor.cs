﻿using BLL;
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
    public partial class frmConsultaFornecedor : Form
    {
        public void AtualizaCabecalhoGridItens()
        {
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "VENDEDOR";
            dgvDados.Columns[2].HeaderText = "NOME FANTASIA";
            dgvDados.Columns[3].HeaderText = "RAZÃO SOCIAL";
            dgvDados.Columns[4].HeaderText = "IE";
            dgvDados.Columns[5].HeaderText = "CNPJ";
            dgvDados.Columns[6].HeaderText = "ENDEREÇO";
            dgvDados.Columns[7].HeaderText = "Nº";
            dgvDados.Columns[8].HeaderText = "COMPLEMENTO";
            dgvDados.Columns[9].HeaderText = "BAIRRO";
            dgvDados.Columns[10].HeaderText = "CEP";
            dgvDados.Columns[11].Visible = false; ;
            dgvDados.Columns[12].HeaderText = "EMAIL";
            dgvDados.Columns[13].HeaderText = "TELEFONE";
            dgvDados.Columns[14].HeaderText = "CELULAR";
            dgvDados.Columns[15].HeaderText = "CELULAR2";
            dgvDados.Columns[16].Visible = false;
            dgvDados.Columns[17].HeaderText = "CADASTRO";
            dgvDados.Columns[18].HeaderText = "SIT";
            dgvDados.Columns[19].Visible = false;
        }
        public int id = 0;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            this.AtualizaCabecalhoGridItens();
        }

        public frmConsultaFornecedor(bool selecao)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            cbStatus.SelectedIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            dgvDados.Select();
            this.AtualizaCabecalhoGridItens();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            this.Opacity = 0;
            f.ShowDialog();
            this.Opacity = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            cbStatus.SelectedIndex = 1;
        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(id);
                frmCadastroFornecedor f = new frmCadastroFornecedor(modelo);
                this.Opacity = 0;
                f.ShowDialog();
                this.Opacity = 1;
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
                        BLLFornecedor bll = new BLLFornecedor(cx);
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
            pFiltro.Visible = true;
            if (cbStatus.SelectedIndex == 1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
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

        private void frmConsultaFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void frmConsultaFornecedor_KeyUp(object sender, KeyEventArgs e)
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
