using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCompraPagamento
    {
        private DALConexao conexao;
        public DALCompraPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCompraPagamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into comprapagamento(idCompra, idFormaPagamento, dataInicioPagamento, precoParcela)" +
                " values (@idCompra, @idFormaPagamento, @dataInicioPagamento, @precoParcela);";
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoId);
            cmd.Parameters.AddWithValue("@dataInicioPagamento", modelo.DataInicioPagamento);
            cmd.Parameters.AddWithValue("@precoParcela", modelo.PrecoParcela);
            cmd.ExecuteNonQuery();
        }

        public void Alterar(ModeloCompraPagamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update comprapagamento set idCompra=@idCompra, idFormaPagamento=@idFormaPagamento, dataInicioPagamento=@dataInicioPagamento, precoParcela=@precoParcela;";
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoId);
            cmd.Parameters.AddWithValue("@dataInicioPagamento", modelo.DataInicioPagamento);
            cmd.Parameters.AddWithValue("@precoParcela", modelo.PrecoParcela);
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraPagamentoId);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ModeloCompraPagamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from comprapagamento where id = @codigo and idCompra=@idCompra and idFormaPagamento=@idFormaPagamento;";
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraPagamentoId);
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoId);
            cmd.ExecuteNonQuery();
        }

        public void ExcluirTodosItens(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from comprapagamento where id = @codigo";
            cmd.Parameters.AddWithValue("@id", codigo);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int codcompra)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, fp.id, fp.nome, cp.dataInicioPagamento, cp.precoParcela from comprapagamento cp inner join formapagamento fp on(cp.idFormaPagamento = fp.id) where cp.idCompra = "
                + codcompra.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCompraPagamento CarregaModeloCompraPagamento(int codigo, int idCompra, int idFormaPagamento)
        {
            ModeloCompraPagamento modelo = new ModeloCompraPagamento();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from comprapagamento where id = @codigo and idCompra=@idCompra and idProduto=@idProduto";
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraPagamentoId);
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoId);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CompraPagamentoId = codigo;
                modelo.CompraId = idCompra;
                modelo.FormaPagamentoId = idFormaPagamento;
                modelo.DataInicioPagamento = Convert.ToDateTime(registro["dataInicioParcela"]);
                modelo.PrecoParcela = Convert.ToDecimal(registro["precoParcela"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}

