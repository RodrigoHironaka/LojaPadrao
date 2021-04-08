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
    public class DALContaPagar
    {
        private DALConexao conexao;
        public DALContaPagar(DALConexao cx)
        {
            this.conexao = cx;
        }
        public int Incluir(ModeloContaPagar modelo)
        {
            int idcompra = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into contapagar(dataCadastro, idTipoGasto, unica, qtdParcelas, valor, idFormaPagamento, nome, emissao, vencimento, numDoc, tipoPessoa, idPessoa, observacao, status) values (@dataCadastro, @idTipoGasto, @unica, @qtdParcelas, @valor, @idFormaPagamento, @nome, @emissao, @vencimento, @numDoc, @tipoPessoa, @idPessoa, @observacao, @status);";
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@idTipoGasto", modelo.TipoGastoID);
            cmd.Parameters.AddWithValue("@unica", modelo.Unica);
            cmd.Parameters.AddWithValue("@qtdParcelas", modelo.QtdParcelas);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoID);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@emissao", modelo.Emissão);
            cmd.Parameters.AddWithValue("@vencimento", modelo.Vencimento);
            cmd.Parameters.AddWithValue("@numDoc", modelo.NumDoc);
            cmd.Parameters.AddWithValue("@tipoPessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@idPessoa", modelo.PessoaID);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select max(id) from compra";
            idcompra = Convert.ToInt32(cmd.ExecuteScalar());
            return idcompra;
        }

        public void Alterar(ModeloContaPagar modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update contapagar set dataCadastro=@dataCadastro, idTipoGasto=@idTipoGasto, unica=@unica, qtdParcelas=@qtdParcelas, valor=@valor, idFormaPagamento=@idFormaPagamento, nome=@nome, emissao=@emissao, vencimento=@vencimento, numDoc=@numDoc, tipoPessoa=@tipoPessoa, idPessoa=@idPessoa, observacao=@observacao, status=@status where id=@id;";
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@idTipoGasto", modelo.TipoGastoID);
            cmd.Parameters.AddWithValue("@unica", modelo.Unica);
            cmd.Parameters.AddWithValue("@qtdParcelas", modelo.QtdParcelas);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoID);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@emissao", modelo.Emissão);
            cmd.Parameters.AddWithValue("@vencimento", modelo.Vencimento);
            cmd.Parameters.AddWithValue("@numDoc", modelo.NumDoc);
            cmd.Parameters.AddWithValue("@tipoPessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@idPessoa", modelo.PessoaID);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@id", modelo.ContaPagarID);
            cmd.ExecuteNonQuery();

        }

        public void Excluir(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compra where id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public DataTable LocalizarCliente()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select tipoPessoa from contapagar";
            //var tipo = cmd.ExecuteScalar();
            if (cmd.CommandText == "CLIENTE")
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, cp.numDoc, cp.nome, c.nomefantasia, cp.valor, cp.vencimento, cp.emissao, cp.dataCadastro, tg.nome, cp.status" +
                    " from contapagar cp" +
                    " inner join tipogasto tg on(cp.idTipoGasto = tg.id) " +
                    //" inner join formapagamento fp on(cp.idFormaPagamento = fp.id) " +
                    " inner join cliente c on(cp.idPessoa = c.id) " +
                    //" inner join fornecedor f on(cp.idPessoa = f.id) " +
                    " order by cp.id ", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            else if (cmd.CommandText == "FORNECEDOR")
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, cp.numDoc, cp.nome, f.nomefantasia, cp.valor, cp.vencimento, cp.emissao, cp.dataCadastro, tg.nome, cp.status" +
                    " from contapagar cp" +
                    " inner join tipogasto tg on(cp.idTipoGasto = tg.id) " +
                    //" inner join formapagamento fp on(cp.idFormaPagamento = fp.id) " +
                    //" inner join cliente c on(cp.idPessoa = c.id) " +
                    " inner join fornecedor f on(cp.idPessoa = f.id) " +
                    " order by cp.id ", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
           
        }

        //MELHORAR PESQUISA DO CONTASPAGAR
        public DataTable LocalizarTodos(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from contapagar where idPessoa like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarAbertos(String valor) //corrigir select
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from contapagar where idPessoa like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPagos(String valor) //corrigir select
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from contapagar where idPessoa like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarCancelados(String valor) //corrigir select
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from contapagar where idPessoa like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloContaPagar CarregaModeloContaPagar(int id)
        {
            ModeloContaPagar modelo = new ModeloContaPagar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from contapagar where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ContaPagarID = Convert.ToInt32(registro["id"]);
                modelo.DataCadastro = Convert.ToString(registro["dataCadastro"]);
                modelo.TipoGastoID = Convert.ToInt32(registro["idTipoGasto"]);
                modelo.Unica = Convert.ToChar(registro["unica"]);
                modelo.QtdParcelas = Convert.ToInt32(registro["qtdParcelas"]);
                modelo.Valor = Convert.ToDecimal(registro["valor"]);
                modelo.FormaPagamentoID = Convert.ToInt32(registro["idFormaPagamento"]);
                modelo.Descricao = Convert.ToString(registro["nome"]);
                modelo.Emissão = Convert.ToDateTime(registro["emissao"]);
                modelo.Vencimento = Convert.ToDateTime(registro["vencimento"]);
                modelo.NumDoc = Convert.ToInt64(registro["numDoc"]);
                modelo.TipoPessoa = Convert.ToString(registro["tipoPessoa"]);
                modelo.PessoaID = Convert.ToInt32(registro["idPessoa"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
        public Boolean Cancelar(int id)
        {
            Boolean retorno = true;
            //Atualizar o status do contas a pagar
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            try
            {
                cmd.Transaction = this.conexao.ObjetoTransacao;
                cmd.CommandText = "update contapagar set status= 'C'" +
                    "where id=@id;";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch
            {
                conexao.CancelaTransacao();
                conexao.Desconectar();
                retorno = false;
            }
            return retorno;
        }

        public DataTable CarregaComboFormaPagamento()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id, nome FROM formapagamento where status = 'A' and qtdparcelas > 0 ORDER BY nome", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public DataTable CarregaComboTipoGasto()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id, nome FROM tipogasto where status = 'A' ORDER BY nome", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
