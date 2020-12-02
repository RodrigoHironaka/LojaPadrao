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
    public class DALCompra
    {
        private DALConexao conexao;
        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCompra modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into compra(dataCadastro, numNota, dataNota, precoNota, idFornecedor, observacao, status) values (@dataCadastro, @numNota, @dataNota, @precoNota, @idFornecedor, @observacao, @status);";
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@numNota", modelo.NumNota);
            cmd.Parameters.AddWithValue("@dataNota", modelo.DataNota);
            cmd.Parameters.AddWithValue("@precoNota", modelo.PrecoNota);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorId);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.CompraId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCompra modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update compra set dataCadastro=@dataCadastro, numNota=@numNota, dataNota=@dataNota, precoNota=@precoNota, idFornecedor=@idFornecedor, observacao=@observacao, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@numNota", modelo.NumNota);
            cmd.Parameters.AddWithValue("@dataNota", modelo.DataNota);
            cmd.Parameters.AddWithValue("@precoNota", modelo.PrecoNota);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorId);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from compra where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from compra where idFornecedor like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from compra where (idFornecedor like '%" + valor + "%' or (id like '%" + valor + "%')) and status='A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from compra where (idFornecedor like '%" + valor + "%' or (id like '%" + valor + "%')) and status='I'", conexao.StringConexao);
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
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter("select id, dataCadastro, numNota, dataNota, precoNota, idFornecedor, observacao, status from compra order by id", conexao.StringConexao);
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
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter("select dataCadastro, numNota, dataNota, precoNota, idFornecedor, observacao, status from compra where status='A' order by id", conexao.StringConexao);
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
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter("select dataCadastro, numNota, dataNota, precoNota, idFornecedor, observacao, status from compra where status='I' order by id", conexao.StringConexao);
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

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from compra where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CompraId = Convert.ToInt32(registro["id"]);
                modelo.DataCadastro = Convert.ToString(registro["dataCadastro"]);
                modelo.NumNota = Convert.ToInt32(registro["numNota"]);
                modelo.DataNota = Convert.ToDateTime(registro["dataNota"]);
                modelo.PrecoNota = Convert.ToDecimal(registro["precoNota"]);
                modelo.FornecedorId = Convert.ToInt32(registro["idFornecedor"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}

