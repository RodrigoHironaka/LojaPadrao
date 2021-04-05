using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.ContasPagar
{
    public partial class frmConsultaContaPagar : Form
    {
        public frmConsultaContaPagar()
        {
            InitializeComponent();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            pFiltro.Visible = true;
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroContaPagar f = new frmCadastroContaPagar();
            f.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
