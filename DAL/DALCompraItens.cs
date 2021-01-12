using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DAL
{
    public class DALCompraItens
    {
        private DALConexao conexao;
        public DALCompraItens(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCompraItens modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into compraitens(idCompra, idProduto, qtdNova, precoCusto, porcentagemCusto, precoAvista, porcentagemAvista, precoPrazo, totalItens, totalCusto, totalAvista, totalPrazo)"+
                " values (@idCompra, @idProduto, @qtdNova, @precoCusto, @porcentagemCusto, @precoAvista, @porcentagemAvista, @precoPrazo, @totalItens, @totalCusto, @totalAvista, @totalPrazo);";
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idProduto", modelo.ProdutoId);
            cmd.Parameters.AddWithValue("@qtdNova", modelo.QtdNova);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.Parameters.AddWithValue("@totalItens", modelo.TotalItens);
            cmd.Parameters.AddWithValue("@totalCusto", modelo.TotalCusto);
            cmd.Parameters.AddWithValue("@totalAvista", modelo.TotalAvista);
            cmd.Parameters.AddWithValue("@totalPrazo", modelo.TotalPrazo);
            cmd.ExecuteNonQuery();        
        }

        public void Alterar(ModeloCompraItens modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update compraitens set qtdNova=@qtdNova, precoCusto=@precoCusto, porcentagemCusto=@porcentagemCusto, precoAvista=@precoAvista, porcentagemAvista=@porcentagemAvista, precoPrazo=@precoPrazo"+
                " where id=@codigo and idCompra=@idCompra and idProduto=@idProduto;";
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idProduto", modelo.ProdutoId);
            cmd.Parameters.AddWithValue("@qtdNova", modelo.QtdNova);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.Parameters.AddWithValue("@totalItens", modelo.TotalItens);
            cmd.Parameters.AddWithValue("@totalCusto", modelo.TotalCusto);
            cmd.Parameters.AddWithValue("@totalAvista", modelo.TotalAvista);
            cmd.Parameters.AddWithValue("@totalPrazo", modelo.TotalPrazo);
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraItensId);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ModeloCompraItens modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compraitens where id = @codigo and idCompra=@idCompra and idProduto=@idProduto;";
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraItensId);
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idProduto", modelo.ProdutoId);
            cmd.ExecuteNonQuery();
        }

        public void ExcluirTodosItens(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compraitens where id = @codigo";
            cmd.Parameters.AddWithValue("@id", codigo);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int codcompra)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select ci.idCompra, ci.id, ci.idProduto, p.nome, ci.qtdNova, ci.valorCusto, ci.porcentagemCusto, ci.valorAvista; ci.porcentagemAvista, ci.valorPrazo from compraitens ci inner join produto p on(ci.idProduto = p.id) where ci.idCompra = "
                + codcompra.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCompraItens CarregaModeloCompraItens(int codigo, int idCompra, int idProduto)
        {
            ModeloCompraItens modelo = new ModeloCompraItens();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from compraitens where id = @codigo and idCompra=@idCompra and idProduto=@idProduto";
            cmd.Parameters.AddWithValue("@codigo", modelo.CompraItensId);
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idProduto", modelo.ProdutoId);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CompraItensId = codigo;
                modelo.CompraId = idCompra;
                modelo.ProdutoId = idProduto;
                modelo.QtdNova = Convert.ToDecimal(registro["qtdNova"]);
                modelo.PrecoCusto = Convert.ToDecimal(registro["precoCusto"]);
                modelo.PorcentagemCusto = Convert.ToDecimal(registro["porcentagemCusto"]);
                modelo.PrecoAvista = Convert.ToDecimal(registro["precoAvista"]);
                modelo.PorcentagemAvista = Convert.ToDecimal(registro["porcentagemAvista"]);
                modelo.PrecoPrazo = Convert.ToDecimal(registro["precoPrazo"]);
                modelo.TotalItens = Convert.ToInt32(registro["totalItens"]);
                modelo.TotalCusto = Convert.ToDecimal(registro["totalCusto"]);
                modelo.TotalAvista = Convert.ToDecimal(registro["totalAvista"]);
                modelo.TotalPrazo = Convert.ToDecimal(registro["totalPrazo"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
