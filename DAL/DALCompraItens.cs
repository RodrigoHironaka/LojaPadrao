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
            cmd.CommandText = "insert into compraitens(idCompra, idProduto, estAtual, estNovo, estTotal, precoCusto, porcentagemCusto, precoAvista, porcentagemAvista, precoPrazo, totalItens, totalCusto, totalAvista, totalPrazo)"+
                " values (@idCompra, @idProduto, @estAtual, @estNovo, @estTotal, @precoCusto, @porcentagemCusto, @precoAvista, @porcentagemAvista, @precoPrazo, @totalItens, @totalCusto, @totalAvista, @totalPrazo);";
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
            MySqlDataAdapter da = new MySqlDataAdapter("select ci.id, ci.idProduto, p.nome, ci.precoCusto, ci.porcentagemCusto, ci.precoAvista, ci.porcentagemAvista, ci.precoPrazo, ci.estAtual, ci.estNovo, ci.estTotal from compraitens ci inner join produto p on(ci.idProduto = p.id) where ci.idCompra = " + codcompra.ToString(), conexao.StringConexao);
           // MySqlDataAdapter da = new MySqlDataAdapter("select* from compraitens where ci.idCompra = " + codcompra.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCompraItens CarregaModeloCompraItens( int codigo, int idCompra, int idProduto)
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
                modelo.EstAtual = Convert.ToDecimal(registro["estAtual"]);
                modelo.EstNovo = Convert.ToDecimal(registro["estNovo"]);
                modelo.EstTotal = Convert.ToDecimal(registro["estTotal"]);
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

        //public void CarregaGridItensCompra(int idCompra)
        //{
        //    List<ModeloCompraItens> itens = new List<ModeloCompraItens>();
        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.Connection = conexao.ObjetoConexao;
        //    cmd.CommandText = "select ci.idCompra, ci.id, ci.idProduto, p.nome, ci.precoCusto, ci.porcentagemCusto, ci.precoAvista, ci.porcentagemAvista, ci.precoPrazo, ci.estAtual, ci.estNovo, ci.estTotal from compraitens ci inner join produto p on(ci.idProduto = p.id) where ci.idCompra = " + idCompra.ToString();
        //    using(MySqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                itens.Add(new ModeloCompraItens
        //                {
        //                    ProdutoId = reader.GetInt32(0),
                            
        //                });
        //            }
        //        }
        //    }

           
        //}

        //public List<ModeloCompraItens> CarregaGridItensCompra(MySqlDataReader reader)
        //{
        //    var lista = new List<ModeloCompraItens>();
        //    while (reader.Read())
        //    {
        //        var modelocompraitens = new ModeloCompraItens();
        //        modelocompraitens.ProdutoId = Convert.ToInt32(reader["idproduto"].ToString());
        //        modelocompraitens.EstAtual = Convert.ToDecimal(reader["estAtual"].ToString());
        //        modelocompraitens.EstNovo = Convert.ToDecimal(reader["estNovo"].ToString());
        //        modelocompraitens.EstTotal = Convert.ToDecimal(reader["estTotal"].ToString());
        //        modelocompraitens.PrecoCusto = Convert.ToDecimal(reader["precoCusto"].ToString());
        //        modelocompraitens.PorcentagemCusto = Convert.ToDecimal(reader["porcentagemCusto"].ToString());
        //        modelocompraitens.PrecoAvista = Convert.ToDecimal(reader["precoAvista"].ToString());
        //        modelocompraitens.PorcentagemAvista = Convert.ToDecimal(reader["porcentagemAvista"].ToString());
        //        modelocompraitens.PrecoPrazo = Convert.ToDecimal(reader["precoPrazo"].ToString());
        //        lista.Add(modelocompraitens);
        //    }
        //    return lista;
        //}
    }
}
