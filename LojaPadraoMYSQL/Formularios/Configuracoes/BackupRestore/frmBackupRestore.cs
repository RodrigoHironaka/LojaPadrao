
using DAL;
using Ferramentas.Backup;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.Configuracoes.BackupRestore
{
    public partial class frmBackupRestore : Form
    {
        public void GerarArquivoBackup()
        {
            if (txtCaminho.Text == string.Empty) 
            { 
                MessageBox.Show("Caminho é obrigatorio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //cria o arquivo
                    StreamWriter arquivo = new StreamWriter("CaminhoBk.ini", false);
                    arquivo.WriteLine(txtCaminho.Text);
                    if (rbBackup.Checked)
                    {
                        arquivo.WriteLine("Backup");
                    }
                    else if (rbRestore.Checked)
                    {
                        arquivo.WriteLine("Restore");
                    }
                    arquivo.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public frmBackupRestore()
        {
            InitializeComponent();
        }
       
        private void btRealizar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (rbBackup.Checked == true)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    string c = txtCaminho.Text.Replace("\"", "\\");
                    BackupBD bk = new BackupBD(cx);
                    bk.GerarBackup(c);
                    MessageBox.Show("BACKUP REALIZADO COM SUCESSO!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else if(rbRestore.Checked == true)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    string c = txtCaminho.Text.Replace("\"", "\\");
                    BackupBD bk = new BackupBD(cx);
                    bk.RestaurarBackup(c);
                    MessageBox.Show("RESTAURAÇÃO REALIZADA COM SUCESSO!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Voce deve deifinir a finalidade BACKUP ou RESTORE.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            if (rbBackup.Checked == true)
            {
                using (FolderBrowserDialog caminho = new FolderBrowserDialog())
                {
                    DialogResult res = caminho.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        txtCaminho.Text = caminho.SelectedPath;
                        this.GerarArquivoBackup();
                    }
                }
            }
            else
            {
                using (OpenFileDialog caminho = new OpenFileDialog())
                {
                    DialogResult res = caminho.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        txtCaminho.Text = caminho.FileName;
                        this.GerarArquivoBackup();
                    }
                }
            }
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Nunca deixe de realizar o backup!\n\rEle é uma segurança para seus dados.\r\nDeseja realmente sair?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d.ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void rbBackup_CheckedChanged(object sender, EventArgs e)
        {
            txtCaminho.Clear();
        }

        private void rbRestore_CheckedChanged(object sender, EventArgs e)
        {
            txtCaminho.Clear();
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\_Projetos\DESKTOP\LojaPadrao\LojaPadraoMYSQL\bin\Debug\CaminhoBk.ini"))
                {
                    StreamReader arquivo = new StreamReader("CaminhoBk.ini");
                    txtCaminho.Text = arquivo.ReadLine();
                    if (arquivo.ReadLine() == "Backup")
                    {
                        rbBackup.Checked = true;
                    }
                    else
                    {
                        rbRestore.Checked = true;
                    }
                    arquivo.Close();
                }
                else
                {
                    rbBackup.Checked = true;
                    //txtCaminho.Text = "C:\_Projetos\DESKTOP\LojaPadrao\BD\BACKUP";
                }
            }
            catch (Exception erro)// erro sistema
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}

