using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Ferramentas;
using Ferramentas.Backup;
using MySqlException = MySql.Data.MySqlClient.MySqlException;

namespace LojaPadraoMYSQL.Formularios.Configuracoes.ConfigBD
{
    public partial class frmConfigBD : Form
    {
        public frmConfigBD()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            lbResposta.Visible = false;
            if((txtServidor.Text == string.Empty)||(txtBanco.Text == string.Empty) || (txtUid.Text == string.Empty) || (txtSenha.Text == string.Empty))
            {
                MessageBox.Show("Todos os campos devem estar preenchidos!\n\rPor favor verifique os campos!\r\n", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ////cria o arquivo
                    Config c = new Config();
                    c.CriaArquivoConfigBD(txtServidor.Text, txtBanco.Text, txtUid.Text, txtSenha.Text, rbServidor.Checked, rbTerminal.Checked);
                    c.TestarConfigBD(txtServidor.Text, txtBanco.Text, txtUid.Text, txtSenha.Text);
                   
                    lbResposta.Visible = true;
                    lbResposta.Text = "CONEXÃO BEM SUCEDIDA!";
                    lbResposta.ForeColor = Color.White;
                }
                catch (MySqlException errob)// erro de banco
                {
                    lbResposta.Visible = true;
                    lbResposta.Text = "ERRO AO CONECTAR!";
                    lbResposta.ForeColor = Color.Coral;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void frmConfigBD_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\_Projetos\DESKTOP\LojaPadrao\LojaPadraoMYSQL\bin\Debug\ConfigBD.ini"))
                {
                    String[] conexao = File.ReadAllLines("ConfigBD.ini");
                    txtServidor.Text = conexao[0];
                    txtBanco.Text = conexao[1];
                    txtUid.Text = conexao[2];
                    txtSenha.Text = conexao[3];
                    if (conexao[4] == "S")
                    {
                        rbServidor.Checked = true;
                    }
                    else
                    {
                        rbTerminal.Checked = true;
                    }
                }
                else
                {
                    txtServidor.Clear();
                    txtBanco.Clear();
                    txtUid.Clear();
                    txtSenha.Clear();
                    rbTerminal.Checked = true;
                }
                    

            }
            catch (Exception erro)// erro sistema
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if(lbResposta.Text == "ERRO AO CONECTAR!")
            {
               DialogResult d = MessageBox.Show("Sua conexão esta com falha, se sair agora você terá problemas para utilizar o sistema!\n\rDeseja Realmente sair?\r\n","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               if(d == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
