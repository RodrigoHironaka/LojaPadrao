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
    public class DALSubGrupo
    {
        private DALConexao conexao;

        public DALSubGrupo(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubGrupo modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into subgrupo(nome, idgrupo, status) values (@nome, @idgrupo, @status);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@idgrupo", modelo.GrupoId);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.SubGrupoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloSubGrupo modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update subgrupo set nome=@nome, idgrupo=@idgrupo, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@idgrupo", modelo.GrupoId);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.SubGrupoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from subgrupo where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select sb.id, sb.nome, g.nome as Grupo, sb.status from subgrupo sb inner join grupo g on sb.idgrupo=g.id where sb.nome like '%" + valor + "%' or sb.id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select sb.id, sb.nome, g.nome as Grupo, sb.status from subgrupo sb inner join grupo g on sb.idgrupo=g.id where (sb.nome like '%" + valor + "%' or (sb.id like '%" + valor + "%')) and sb.status='A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select sb.id, sb.nome, g.nome as Grupo, sb.status from subgrupo sb inner join grupo g on sb.idgrupo=g.id where (sb.nome like '%" + valor + "%' or (sb.id like '%" + valor + "%')) and sb.status='I'", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select sb.id, sb.nome, g.nome, sb.`status` from subgrupo sb" +
                    " inner join grupo g on sb.idgrupo = g.id" +
                    " order by sb.id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select sb.id, sb.nome, g.nome as Grupo, sb.`status` from subgrupo sb INNER JOIN grupo g on sb.idgrupo = g.id" +
                    " where sb.status='A' order by sb.id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select sb.id, sb.nome, g.nome as Grupo, sb.`status` from subgrupo sb INNER JOIN grupo g on sb.idgrupo = g.id" +
                    " where sb.status='I' order by sb.id", conexao.StringConexao);
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

        public ModeloSubGrupo CarregaModeloSubGrupo(int codigo)
        {
            ModeloSubGrupo modelo = new ModeloSubGrupo();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subgrupo where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SubGrupoId = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.GrupoId = Convert.ToInt32(registro["idgrupo"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public DataTable CarregaComboGrupo()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id, nome FROM grupo where status = 'A' ORDER BY nome", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
