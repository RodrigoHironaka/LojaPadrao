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
    public partial class frmCadastroMarca : Form
    {
        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            chkAtivo.Checked = true;
        }

        public frmCadastroMarca()
        {
            InitializeComponent();
        }

        public frmCadastroMarca(ModeloMarca modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.MarcaId);
            txtNome.Text = modelo.Nome;
            txtModelo.Text = modelo.Modelo;
            txtAno.Text = Convert.ToString(modelo.Ano);
            if(txtAno.Text == "0")
            {
                txtAno.Text = "";
            }
            if (modelo.Status.Equals('A'))
                chkAtivo.Checked = true;
            else if (modelo.Status.Equals('I'))
                chkAtivo.Checked = false;
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca dal = new BLLMarca(cx);
                ModeloMarca modelo = new ModeloMarca();
                modelo.Nome = txtNome.Text;
                modelo.Modelo = Convert.ToString(txtModelo.Text);
                if(txtAno.Text == "")
                {
                    modelo.Ano = 0;
                }
                else
                {
                    modelo.Ano = Convert.ToInt32(txtAno.Text);
                }
                
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
                    dal.Incluir(modelo);
                    this.LimpaTela();
                }
                else
                {
                    modelo.MarcaId = int.Parse(txtID.Text);
                    dal.Alterar(modelo);
                }
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmCadastroMarca_KeyDown(object sender, KeyEventArgs e)
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
    }
}
