using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmConsultaCompra : Form
    {
        public frmConsultaCompra()
        {
            InitializeComponent();
            pFiltro.Visible = false;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvDados.DataSource = bll.LocalizarTodos();
            dgvDados.Select();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCompra f = new frmCadastroCompra();
            f.ShowDialog();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvDados.DataSource = bll.LocalizarTodos();
            dgvDados.Select();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            pFiltro.Visible = true;
            
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }
    }
}
