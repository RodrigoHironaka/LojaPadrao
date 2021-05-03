using DAL;
using Ferramentas.Backup;
using LojaPadraoMYSQL.Formularios.Configuracoes.BackupRestore;
using LojaPadraoMYSQL.Formularios.Configuracoes.ConfigBD;
using System;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios.FormBotoes.Configuracoes
{
    public partial class frmBotoesConfig : Form
    {
        public frmBotoesConfig()
        {
            InitializeComponent();
        }

        private void frmBotoesConfig_Load(object sender, EventArgs e)
        {

        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            frmBackupRestore f = new frmBackupRestore();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }

        private void btBD_Click(object sender, EventArgs e)
        {
            frmConfigBD f = new frmConfigBD();
            f.TopLevel = false;
            Parent.Controls.Add(f);
            f.Show();
        }
    }
}
