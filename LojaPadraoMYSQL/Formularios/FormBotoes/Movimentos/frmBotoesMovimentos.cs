using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.FormBotoes.Movimentos
{
    public partial class frmBotoesMovimentos : Form
    {
        public frmBotoesMovimentos()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCompra_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
        }
    }
}
