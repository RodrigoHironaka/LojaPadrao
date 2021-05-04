using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALCidade
    {
        private DALConexao conexao;

        public DALCidade(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCidade modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into cidade(nome, uf, status) values (@nome, @uf, @status);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@uf", modelo.UF);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.CidadeId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCidade modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cidade set nome=@nome, uf=@uf, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@uf", modelo.UF);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.CidadeId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from cidade where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from cidade order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from cidade where (nome like '%" + valor + "%' or (id like '%" + valor + "%'))", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from cidade where status='A' and (nome like '%" + valor + "%' or (id like '%" + valor + "%'))", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from cidade where status='I' and (nome like '%" + valor + "%' or (id like '%" + valor + "%'))", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable CarregarGrid()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter("select id as Cod, nome as Nome, uf as UF, status as Sit from cidade order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable CarregarGridAtivo()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter("select id as Cod, nome as Nome, uf as UF, status as Sit from cidade where status='A' order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable CarregarGridInativo()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter("select id as Cod, nome as Nome, uf as UF, status as Sit from cidade where status='I' order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public ModeloCidade CarregaModeloCidade(int codigo)
        {
            ModeloCidade modelo = new ModeloCidade();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cidade where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CidadeId = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.UF = Convert.ToString(registro["uf"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        //VERIFICAR ULTIMO ID INSERIDO NA TABELA DO BANCO--------------------------------------
        public Int64 VerificaUltimoIdInserido()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select max(id) from cidade";
            conexao.Conectar();
            var resultadobusca = cmd.ExecuteScalar();
            Int64 id = 0;
            if (resultadobusca != DBNull.Value)
            {
                id = Convert.ToInt64(resultadobusca);
            }
            conexao.Desconectar();
            return id;
        }
        //LOCALIZA ULTIMO(S) PARA MOSTRAR NO GRID APOS INSERIR --------------------------------------------------------
        public DataTable LocalizarUltimoItemInserido()
        {
            var ultimoId = VerificaUltimoIdInserido();

            ModeloCidade modelo = CarregaModeloCidade(Convert.ToInt32(ultimoId));
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select id, nome, uf, status" +
                    " from cidade " +
                    " where id = " + ultimoId +
                    " order by id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //LOCALIZA ULTIMO(S) PARA MOSTRAR NO GRID APOS ALTERAR--------------------------------------------------------
        public DataTable LocalizarUltimoItemAlterar(Int64 idAlterado)
        {
            var ultimoId = idAlterado; 

            ModeloCidade modelo = CarregaModeloCidade(Convert.ToInt32(ultimoId));
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select id, nome, uf, status" +
                    " from cidade " +
                    " where id = " + ultimoId +
                    " order by id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
