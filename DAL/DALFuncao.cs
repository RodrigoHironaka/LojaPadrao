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
    public class DALFuncao
    {
        private DALConexao conexao;

        public DALFuncao(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFuncao modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into funcao(nome, descricao, status) values (@nome, @descricao, @status);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.FuncaoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFuncao modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update funcao set nome=@nome, descricao=@descricao, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.FuncaoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from funcao where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcao where nome like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcao where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcao where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='I'", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, descricao, status from funcao order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, descricao, status from funcao where status='A' order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, descricao, status from funcao where status='I' order by id", conexao.StringConexao);
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

        public ModeloFuncao CarregaModeloFuncao(int codigo)
        {
            ModeloFuncao modelo = new ModeloFuncao();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from funcao where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FuncaoId = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
