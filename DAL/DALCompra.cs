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
        public int Incluir(ModeloCompra modelo)
        {
            int idcompra = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into compra(dataCadastro, numNota, dataNota, precoNota, idFornecedor, observacao, status) values (@dataCadastro, @numNota, @dataNota, @precoNota, @idFornecedor, @observacao, @status);";
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@numNota", modelo.NumNota);
            cmd.Parameters.AddWithValue("@dataNota", modelo.DataNota);
            cmd.Parameters.AddWithValue("@precoNota", modelo.PrecoNota);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorId);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select max(id) from compra";
            idcompra = Convert.ToInt32(cmd.ExecuteScalar());
            return idcompra;
        }

        public void Alterar(ModeloCompra modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update compra set dataCadastro=@dataCadastro, numNota=@numNota, dataNota=@dataNota, precoNota=@precoNota, idFornecedor=@idFornecedor, observacao=@observacao, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@numNota", modelo.NumNota);
            cmd.Parameters.AddWithValue("@dataNota", modelo.DataNota);
            cmd.Parameters.AddWithValue("@precoNota", modelo.PrecoNota);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorId);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraId);
            cmd.ExecuteNonQuery();

        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compra where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();
        }

        public DataTable LocalizarTodos()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select c.id as Cod,c.dataCadastro as Cadastro, c.NumNota as Nota, c.dataNota as Emissão, c.precoNota as ValorNota, c.idFornecedor as CodF, f.nomeFantasia as Fornecedor, f.nomeVendedor as Vendedor, c.`status` as Sit from compra c inner join fornecedor f on(c.idFornecedor = f.id) order by c.id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //MELHORAR PESQUISA DA COMPRA
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from compra where idFornecedor like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
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

