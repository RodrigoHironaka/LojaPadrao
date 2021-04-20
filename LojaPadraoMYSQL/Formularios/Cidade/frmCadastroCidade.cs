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
    public partial class frmCadastroCidade : Form
    {
        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            cbUf.SelectedIndex = 24;
            chkAtivo.Checked = true;
        }

        public frmCadastroCidade()
        {
            InitializeComponent();
            cbUf.SelectedIndex = 24;
            
        }

        public frmCadastroCidade(ModeloCidade modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.CidadeId);
            txtNome.Text = modelo.Nome;
            cbUf.Text = modelo.UF.ToString();
            if (modelo.Status.Equals('A'))
                chkAtivo.Checked = true;
            else if (modelo.Status.Equals('I'))
                chkAtivo.Checked = false;
           
        }

       
        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCidade bll = new BLLCidade(cx);
                ModeloCidade modelo = new ModeloCidade();
                modelo.Nome = txtNome.Text;
                modelo.UF = cbUf.Text;
                if (chkAtivo.Checked)
                {
                    modelo.Status = Convert.ToChar("A");
                }
                else
                {
                    modelo.Status = Convert.ToChar("I");
                }

                if (txtID.Text == "")
                {
                    bll.Incluir(modelo);
                    this.LimpaTela();
                }
                else
                {
                    modelo.CidadeId = int.Parse(txtID.Text);
                    bll.Alterar(modelo);
                }
                this.Close();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);
            }
        }

        private void frmCadastroCidade_KeyDown(object sender, KeyEventArgs e)
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

        private void frmCadastroCidade_Load(object sender, EventArgs e)
        {

        }
    }
}
