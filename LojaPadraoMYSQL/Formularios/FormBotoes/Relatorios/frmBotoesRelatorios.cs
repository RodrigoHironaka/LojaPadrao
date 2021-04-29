using LojaPadraoMYSQL.Formularios.FormBotoes.Relatorios.Financeiro;
using LojaPadraoMYSQL.Formularios.FormBotoes.Relatorios.Geral;
using LojaPadraoMYSQL.Formularios.FormBotoes.Relatorios.PessoasEmpresas;
using LojaPadraoMYSQL.Formularios.FormBotoes.Relatorios.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.FormBotoes.Relatorios
{
    public partial class frmBotoesRelatorios : Form
    {
        public frmBotoesRelatorios()
        {
            InitializeComponent();
        }

        private void btPessoasEmpresas_Click(object sender, EventArgs e)
        {
            frmPessoasEmpresasRelatorio f = new frmPessoasEmpresasRelatorio();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            frmProdutosRelatorios f = new frmProdutosRelatorios();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btGeral_Click(object sender, EventArgs e)
        {
            frmGeralRelatorio f = new frmGeralRelatorio();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            frmFinanceiroRelatorios f = new frmFinanceiroRelatorios();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }
    }
}
