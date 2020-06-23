using BLL;
using DAL;
using Modelos;
using System;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmCadastroUsuario : Form
    {
        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            cbTipo.SelectedIndex = 0;
            chkAtivo.Checked = true;
        }
        public frmCadastroUsuario()
        {
            InitializeComponent();
            cbTipo.SelectedIndex = 0;
        }

        public frmCadastroUsuario(ModeloUsuario modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.UsuarioId);
            txtNome.Text = modelo.Nome;
            txtSenha.Text = modelo.Senha;
            txtConfirmaSenha.Text = modelo.ConfirmaSenha;
            cbTipo.Text = modelo.Tipo;
            if (modelo.Status.Equals('A'))
                chkAtivo.Checked = true;
            else if (modelo.Status.Equals('I'))
                chkAtivo.Checked = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario dal = new BLLUsuario(cx);
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.Nome = txtNome.Text;
                modelo.Senha = txtSenha.Text;
                modelo.ConfirmaSenha = txtConfirmaSenha.Text;
                modelo.Tipo = cbTipo.Text;
                if (chkAtivo.Checked)
                {
                    modelo.Status = Convert.ToChar("A");
                }
                else
                {
                    modelo.Status = Convert.ToChar("I");
                }

                if (txtID.Text == "")
                {
                    if(txtSenha.Text == txtConfirmaSenha.Text)
                    {
                        dal.Incluir(modelo);
                        this.LimpaTela();
                    }
                    else
                    {
                        MessageBox.Show("A Confirmação da Senha deve ser igual a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                }
                else
                {
                    modelo.UsuarioId = int.Parse(txtID.Text);
                    dal.Alterar(modelo);
                }
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);
            }
        }

        private void btAlterarSenha_Click(object sender, EventArgs e)
        {
            frmSenhaAdm f = new frmSenhaAdm();
            f.ShowDialog();
        }
    }
}
