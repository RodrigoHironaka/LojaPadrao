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
    public class DALDepartamento
    {
        private DALConexao conexao;

        public DALDepartamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloDepartamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into departamento(nome, status) values (@nome, @status);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.DepartamentoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloDepartamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update departamento set nome=@nome, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.DepartamentoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from departamento where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from departamento where nome like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select id, nome, status from departamento where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from departamento where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='I'", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, status from departamento order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from departamento where status='A' order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, status from departamento where status='I' order by id", conexao.StringConexao);
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

        public ModeloDepartamento CarregaModeloDepartamento(int codigo)
        {
            ModeloDepartamento modelo = new ModeloDepartamento();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from departamento where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.DepartamentoId = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
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
            cmd.CommandText = "Select max(id) from departamento";
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

            ModeloDepartamento modelo = CarregaModeloDepartamento(Convert.ToInt32(ultimoId));
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select id, nome, status" +
                    " from departamento " +
                    " where id = " + ultimoId +
                    " order by id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //LOCALIZA ULTIMO(S) PARA MOSTRAR NO GRID APOS ALTERAR--------------------------------------------------------
        public DataTable LocalizarUltimoItemAlterar(Int64 idAlterado)
        {
            var ultimoId = idAlterado; ;

            ModeloDepartamento modelo = CarregaModeloDepartamento(Convert.ToInt32(ultimoId));
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select id, nome, status" +
                    " from departamento " +
                    " where id = " + ultimoId +
                    " order by id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
