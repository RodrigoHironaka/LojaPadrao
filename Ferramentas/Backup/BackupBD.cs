using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Backup
{
    public class BackupBD
    {
        private DALConexao conexao;

        public BackupBD(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void GerarBackup(string caminho)
        {
            try
            {
                string data = System.DateTime.Now.ToShortDateString().Replace("/","");
                string hora = System.DateTime.Now.ToLongTimeString().Replace(":","");
                string caminhoSalvar = caminho+"\\Loja"+data+"_"+hora+".sql";
                MySqlCommand cmd = new MySqlCommand();
                using (MySqlBackup bk = new MySqlBackup(cmd))
                {
                    cmd.Connection = conexao.ObjetoConexao;
                    conexao.Conectar();
                    bk.ExportToFile(caminhoSalvar);
                    conexao.Desconectar();
                }
            }
            catch (Exception)
            {
                throw new Exception("Houve um erro ao realizar o backup! Contate o suporte técnico");
            }
        }

        public void RestaurarBackup(string caminho)
        {
            try
            {
                //string caminhoSalvar = caminho + "\\Loja" + data + "_" + hora + ".sql";
                MySqlCommand cmd = new MySqlCommand();
                using (MySqlBackup bk = new MySqlBackup(cmd))
                {
                    cmd.Connection = conexao.ObjetoConexao;
                    conexao.Conectar();
                    bk.ImportFromFile(caminho);
                    conexao.Desconectar();
                }
            }
            catch (Exception)
            {
                throw new Exception("Houve um erro ao realizar o backup! Contate o suporte técnico");
            }
        }
    }
}

