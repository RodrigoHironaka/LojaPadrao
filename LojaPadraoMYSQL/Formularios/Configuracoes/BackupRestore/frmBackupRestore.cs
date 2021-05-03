
using DAL;
using Ferramentas.Backup;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.Configuracoes.BackupRestore
{
    public partial class frmBackupRestore : Form
    {

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
                    }
                }
            }
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Nunca deixe de realizar o backup!\n\rEle é uma segurança para seus dados.\r\nDeseja realmente sair?.", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d.ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void rbBackup_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbRestore_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

