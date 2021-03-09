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
    }
}
