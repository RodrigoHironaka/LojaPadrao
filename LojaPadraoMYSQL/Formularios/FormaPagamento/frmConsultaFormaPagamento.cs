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
    public partial class frmConsultaFormaPagamento : Form
    {
        public int id = 0;

        public void AtualizaCabecalhoGridDados()
        {
            dgvDados.Columns[0].HeaderText = "COD";
            dgvDados.Columns[1].HeaderText = "NOME";
            dgvDados.Columns[2].HeaderText = "Nº PARC";
            dgvDados.Columns[3].HeaderText = "DIAS VENC";
            dgvDados.Columns[4].HeaderText = "SIT";
        }

        public frmConsultaFormaPagamento()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroFormaPagamento f = new frmCadastroFormaPagamento();
            this.Opacity = 0;
            f.ShowDialog();
            this.Opacity = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFormaPagamento bll = new BLLFormaPagamento(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            this.AtualizaCabecalhoGridDados();

        }

        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFormaPagamento bll = new BLLFormaPagamento(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModeloFormaPagamento modelo = bll.CarregaModeloFormaPagamento(id);
                frmCadastroFormaPagamento f = new frmCadastroFormaPagamento(modelo);
                this.Opacity = 0;
                f.ShowDialog();
                this.Opacity = 1;
                f.Dispose();
                dgvDados.DataSource = bll.CarregaGridAtivo();
                this.AtualizaCabecalhoGridDados();

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
                        BLLFormaPagamento bll = new BLLFormaPagamento(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDados.DataSource = bll.CarregaGridAtivo();
                        this.AtualizaCabecalhoGridDados();

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
            if (rbAtivos.Checked)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFormaPagamento bll = new BLLFormaPagamento(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
                this.AtualizaCabecalhoGridDados();
            }
            else if (rbInativos.Checked)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFormaPagamento bll = new BLLFormaPagamento(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
                this.AtualizaCabecalhoGridDados();
            }
            else if (rbTodos.Checked)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFormaPagamento bll = new BLLFormaPagamento(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
                this.AtualizaCabecalhoGridDados();
            }
        }

        private void frmConsultaFormaPagamento_Load(object sender, EventArgs e)
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

        private void frmConsultaFormaPagamento_KeyDown(object sender, KeyEventArgs e)
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

        private void frmConsultaFormaPagamento_KeyUp(object sender, KeyEventArgs e)
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
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFormaPagamento bll = new BLLFormaPagamento(cx);
            dgvDados.DataSource = bll.CarregaGrid();
        }

        private void rbAtivos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFormaPagamento bll = new BLLFormaPagamento(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
        }

        private void rbInativos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFormaPagamento bll = new BLLFormaPagamento(cx);
            dgvDados.DataSource = bll.CarregaGridInativo();
        }
    }
}
