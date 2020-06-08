using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DALGrupo
    {
        private DALConexao conexao;

        public DALGrupo(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloGrupo modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into grupo(nome, status) values (@nome, @status);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.GrupoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloGrupo modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update grupo set nome=@nome, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.GrupoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from grupo where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from grupo where nome like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from grupo where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from grupo where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='I'", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, status from grupo order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, status from grupo where status='A' order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, status from grupo where status='I' order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public ModeloGrupo CarregaModeloGrupo(int codigo)
        {
            ModeloGrupo modelo = new ModeloGrupo();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from grupo where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.GrupoId = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
