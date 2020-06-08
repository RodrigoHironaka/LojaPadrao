using System;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = "localhost";
        public static String banco = "loja";
        public static String id = "root";
        public static String senha = "#PADAxrFZ9";
        public static String StringDeConexao
        {
            get
            {
                return "server=" + servidor + "; database=" + banco + "; Uid=" + id + ";Pwd=" + senha;
            }
        }
    }
}
