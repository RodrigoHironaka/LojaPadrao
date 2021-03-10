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

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void btCidades_Click(object sender, EventArgs e)
        {
            frmConsultaCidade f = new frmConsultaCidade();
            f.ShowDialog();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
        }

        private void btColaboradores_Click(object sender, EventArgs e)
        {
            frmConsultaColaborador f = new frmConsultaColaborador();
            f.ShowDialog();
        }

        private void btFuncoes_Click(object sender, EventArgs e)
        {
            frmConsultaFuncao f = new frmConsultaFuncao();
            f.ShowDialog();
        }

        private void btDepartamento_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamento f = new frmConsultaDepartamento();
            f.ShowDialog();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
        }

        private void btGrupos_Click(object sender, EventArgs e)
        {
            frmConsultaGrupo f = new frmConsultaGrupo();
            f.ShowDialog();
        }

        private void btSubGrupo_Click(object sender, EventArgs e)
        {
            frmConsultaSubGrupo f = new frmConsultaSubGrupo();
            f.ShowDialog();
        }

        private void btMarcas_Click(object sender, EventArgs e)
        {
            frmConsultaMarca f = new frmConsultaMarca();
            f.ShowDialog();
        }

        private void btTransportadoras_Click(object sender, EventArgs e)
        {
            frmConsultaTransportadora f = new frmConsultaTransportadora();
            f.ShowDialog();
        }

        private void btFormasPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento f = new frmConsultaFormaPagamento();
            f.ShowDialog();
        }

        private void btTiposGasto_Click(object sender, EventArgs e)
        {
            frmConsulta f = new frmConsulta();
            f.ShowDialog();
        }

        private void btUnidades_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
        }
    }
}
