using LojaPadraoMYSQL.Formularios.Configuracoes.ConfigBD;
using LojaPadraoMYSQL.Formularios.FormBotoes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(@"C:\Users\Hironaka\Google Drive\Projetos\DESKTOP\LojaPadrao\LojaPadraoMYSQL\bin\Debug\ConfigBD.ini"))
            {
                Application.Run(new frmPrincipal());
            }
            else
            {
                frmConfigBD f = new frmConfigBD();
                f.WindowState = FormWindowState.Normal;
                f.ShowDialog();
                Application.Run(new frmPrincipal());
            }
                
        }
    }
}
