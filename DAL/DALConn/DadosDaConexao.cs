using System;
using System.IO;

namespace DAL
{
    public class DadosDaConexao
    {
        //public static string[] Teste()
        //{
        //    string[] con;
        //    if (File.Exists(@"C:\_Projetos\DESKTOP\LojaPadrao\LojaPadraoMYSQL\bin\Debug\ConfigBD.ini"))
        //    {
        //        con = File.ReadAllLines("ConfigBD.ini");
        //        return con;
        //    }
        //    else
        //    {
        //        return con = null;
        //    }
                      
        //}
        public static String[] conexao = File.ReadAllLines("ConfigBD.ini");

        public static String servidor = conexao[0];
        public static String banco = conexao[1];
        public static String id = conexao[2];
        public static String senha = conexao[3];
        public static String StringDeConexao
        {
            get
            {
                return "server=" + servidor + "; database=" + banco + "; Uid=" + id + ";Pwd=" + senha;
            }
        }
    }
}
