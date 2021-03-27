using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.ContasPagar
{
    public partial class frmCadastroContaPagar : Form
    {
        public frmCadastroContaPagar()
        {
            InitializeComponent();
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
