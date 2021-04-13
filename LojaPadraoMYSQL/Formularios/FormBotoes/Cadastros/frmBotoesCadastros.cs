using LojaPadraoMYSQL.Formularios.Colaborador;
using LojaPadraoMYSQL.Formularios.TipoGasto;
using LojaPadraoMYSQL.Formularios.Transportadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.FormBotoes
{
    public partial class frmBotoesCadastros : Form
    {
        public frmBotoesCadastros()
        {
            InitializeComponent();
        }

        private void btCidades_Click(object sender, EventArgs e)
        {
            frmConsultaCidade f = new frmConsultaCidade();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btColaboradores_Click(object sender, EventArgs e)
        {
            frmConsultaColaborador f = new frmConsultaColaborador();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btFuncoes_Click(object sender, EventArgs e)
        {
            frmConsultaFuncao f = new frmConsultaFuncao();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
            
        }

        private void btDepartamento_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamento f = new frmConsultaDepartamento();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btGrupos_Click(object sender, EventArgs e)
        {
            frmConsultaGrupo f = new frmConsultaGrupo();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btSubGrupo_Click(object sender, EventArgs e)
        {
            frmConsultaSubGrupo f = new frmConsultaSubGrupo();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btMarcas_Click(object sender, EventArgs e)
        {
            frmConsultaMarca f = new frmConsultaMarca();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btTransportadoras_Click(object sender, EventArgs e)
        {
            frmConsultaTransportadora f = new frmConsultaTransportadora();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btFormasPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento f = new frmConsultaFormaPagamento();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btTiposGasto_Click(object sender, EventArgs e)
        {
            frmConsulta f = new frmConsulta();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btUnidades_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }
    }
}
