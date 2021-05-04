using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Backup
{
    public class Config
    {
        public void CriaArquivoConfigBD(string servidor, string banco, string uid, string senha, bool s, bool t)
        {
            ////cria o arquivo
            StreamWriter arquivo = new StreamWriter("ConfigBD.ini", false);
            arquivo.WriteLine(servidor);
            arquivo.WriteLine(banco);
            arquivo.WriteLine(uid);
            arquivo.WriteLine(senha);
            if (s == true)
            {
                arquivo.WriteLine("S");
            }
            else if (t == true)
            {
                arquivo.WriteLine("T");
            }
            arquivo.Close();
        }

        public void TestarConfigBD(string servidor, string banco, string uid, string senha)
        {
            ////Testa o conexao
            DadosDaConexao.servidor = servidor;
            DadosDaConexao.banco = banco;
            DadosDaConexao.id = uid;
            DadosDaConexao.senha = senha;
            //Testar Conexao
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = DadosDaConexao.StringDeConexao;
            conexao.Open();
            conexao.Close();
        }
    }
}
