using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            cmd.CommandText = "insert into compraitens(idCompra, idProduto, estAtual, estNovo, estTotal, precoCusto, porcentagemCusto, precoAvista, porcentagemAvista, precoPrazo)"+
                " values (@idCompra, @idProduto, @estAtual, @estNovo, @estTotal, @precoCusto, @porcentagemCusto, @precoAvista, @porcentagemAvista, @precoPrazo);";
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idProduto", modelo.ProdutoId);
            cmd.Parameters.AddWithValue("@estAtual", modelo.EstAtual);
            cmd.Parameters.AddWithValue("@estNovo", modelo.EstNovo);
            cmd.Parameters.AddWithValue("@estTotal", modelo.EstTotal);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.ExecuteNonQuery();        
        }

        public void Alterar(ModeloCompraItens modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update compraitens set estAtual=@estAtual, estNovo=@estNovo, estTotal=@estTotal, precoCusto=@precoCusto, porcentagemCusto=@porcentagemCusto, precoAvista=@precoAvista, porcentagemAvista=@porcentagemAvista, precoPrazo=@precoPrazo" +
                " where id=@codigo and idCompra=@idCompra and idProduto=@idProduto;";
            cmd.Parameters.AddWithValue("@idCompra", modelo.CompraId);
            cmd.Parameters.AddWithValue("@idProduto", modelo.ProdutoId);
            cmd.Parameters.AddWithValue("@estAtual", modelo.EstAtual);
            cmd.Parameters.AddWithValue("@estNovo", modelo.EstNovo);
            cmd.Parameters.AddWithValue("@estTotal", modelo.EstTotal);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
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
            cmd.CommandText = "delete from compraitens where idCompra = @idCompra";
            cmd.Parameters.AddWithValue("@idCompra", codigo);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int codcompra)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select ci.id, ci.idProduto, p.nome, ci.precoCusto, ci.porcentagemCusto, ci.precoAvista, ci.porcentagemAvista, ci.precoPrazo, ci.estAtual, ci.estNovo, ci.estTotal from compraitens ci inner join produto p on(ci.idProduto = p.id) where ci.idCompra = " + codcompra.ToString(), conexao.StringConexao);
           // MySqlDataAdapter da = new MySqlDataAdapter("select* from compraitens where ci.idCompra = " + codcompra.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //public ModeloCompraItens CarregaModeloCompraItens( int codigo)
        //{
        //    ModeloCompraItens modelo = new ModeloCompraItens();
        //    ModeloCompra modelocompra = new ModeloCompra();
        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.Connection = conexao.ObjetoConexao;
        //    cmd.CommandText = "select totalItens,totalCusto, totalAvista, totalPrazo from compraitens where idCompra = @idCompra";           
        //    cmd.Parameters.AddWithValue("@idCompra", modelocompra.CompraId);
          
        //    conexao.Conectar();
        //    MySqlDataReader registro = cmd.ExecuteReader();
        //    if (registro.HasRows)
        //    {
        //        registro.Read();
        //        modelo.CompraItensId = codigo;
        //        modelo.TotalItens = Convert.ToInt32(registro["totalItens"]);
        //        modelo.TotalCusto = Convert.ToDecimal(registro["totalCusto"]);
        //        modelo.TotalAvista = Convert.ToDecimal(registro["totalAvista"]);
        //        modelo.TotalPrazo = Convert.ToDecimal(registro["totalPrazo"]);
        //    }
        //    registro.Close();
        //    conexao.Desconectar();
        //    return modelo;
        //}


    }
}
