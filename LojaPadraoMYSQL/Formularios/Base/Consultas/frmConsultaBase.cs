using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.Base.Consultas
{
    public partial class frmConsultaBase : Form
    {
        public int id = 0; //VARIAVEL USADA PARA RECEBER O ID NO BOTAO EDITAR
        public frmConsultaBase()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1; //SEMPRE INICIA COM A OPÇÃO "ATIVO"
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEdt_Click(object sender, EventArgs e)
        {

        }

        private void btExc_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
