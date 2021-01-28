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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            frmBotoesCadastros f = new frmBotoesCadastros();
            f.TopLevel = false;
            pFormInfo.Controls.Add(f);
            f.Show();
            
        }
    }
}
