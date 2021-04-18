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
            f.TopLevel = false;
            Parent.Controls.Add(f);
            this.Visible = false;
            f.Show();
            this.Visible = true;
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.TopLevel = false;
            Parent.Controls.Add(f);
           
            f.Show();
            
            
        }

        private void btColaboradores_Click(object sender, EventArgs e)
        {
            frmConsultaColaborador f = new frmConsultaColaborador();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btFuncoes_Click(object sender, EventArgs e)
        {
            frmConsultaFuncao f = new frmConsultaFuncao();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();

        }

        private void btDepartamento_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamento f = new frmConsultaDepartamento();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btGrupos_Click(object sender, EventArgs e)
        {
            frmConsultaGrupo f = new frmConsultaGrupo();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btSubGrupo_Click(object sender, EventArgs e)
        {
            frmConsultaSubGrupo f = new frmConsultaSubGrupo();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btMarcas_Click(object sender, EventArgs e)
        {
            frmConsultaMarca f = new frmConsultaMarca();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btTransportadoras_Click(object sender, EventArgs e)
        {
            frmConsultaTransportadora f = new frmConsultaTransportadora();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btFormasPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento f = new frmConsultaFormaPagamento();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show(); 
        }

        private void btTiposGasto_Click(object sender, EventArgs e)
        {
            frmConsulta f = new frmConsulta();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btUnidades_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }
    }
}
