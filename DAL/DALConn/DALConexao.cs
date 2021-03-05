using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private MySqlConnection _conexao;
        private MySqlTransaction _transaction;

        public DALConexao(String dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public MySqlTransaction ObjetoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }

        //pegar o objeto de conexao (_conexao) e iniciar a transacao (o caminho ate o banco)
        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }

        //finaliza uma transacao, efetiva as transaçoes no banco de vez (gravado)
        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }

        // desfaz tudo oq foi feito durante um cadastro, se os itens ja foram colocados no banco ele retira de la caso o usuraio cancele a transacao.
        public void CancelaTransacao()
        {
            this._transaction.Rollback();
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public MySqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
