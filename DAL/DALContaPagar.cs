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
        //CONEXAO E CONSTRUTOR-----------------------------------------------------------------
        private DALConexao conexao;
        public DALContaPagar(DALConexao cx)
        {
            this.conexao = cx;
        }

        //CRUD PADRAO-------------------------------------------------------------------------
        public int Incluir(ModeloContaPagar modelo)
        {
            int idcompra = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into contapagar(idInterno, dataCadastro, idTipoGasto, qtdParcelas, valor, total, idFormaPagamento, nome, emissao, vencimento, numDoc, tipoPessoa, idPessoa, observacao, periodo, status) values (@idInterno, @dataCadastro, @idTipoGasto, @qtdParcelas, @valor, @total, @idFormaPagamento, @nome, @emissao, @vencimento, @numDoc, @tipoPessoa, @idPessoa, @observacao, @periodo, @status);";
            cmd.Parameters.AddWithValue("@idInterno", modelo.IdInterno);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@idTipoGasto", modelo.TipoGastoID);
            cmd.Parameters.AddWithValue("@qtdParcelas", modelo.QtdParcelas);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@total", modelo.Total);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoID);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@emissao", modelo.Emissão);
            cmd.Parameters.AddWithValue("@vencimento", modelo.Vencimento);
            cmd.Parameters.AddWithValue("@numDoc", modelo.NumDoc);
            cmd.Parameters.AddWithValue("@tipoPessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@idPessoa", modelo.PessoaID);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@periodo", modelo.Periodo);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select max(id) from contapagar";
            idcompra = Convert.ToInt32(cmd.ExecuteScalar());
            return idcompra;
        }

        public void Alterar(ModeloContaPagar modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update contapagar set idInterno=@idInterno,dataCadastro=@dataCadastro, idTipoGasto=@idTipoGasto, qtdParcelas=@qtdParcelas, valor=@valor, total=@total, idFormaPagamento=@idFormaPagamento, nome=@nome, emissao=@emissao, vencimento=@vencimento, numDoc=@numDoc, tipoPessoa=@tipoPessoa, idPessoa=@idPessoa, observacao=@observacao, periodo=@periodo, status=@status where id=@id;";
            cmd.Parameters.AddWithValue("@idInterno", modelo.IdInterno);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@idTipoGasto", modelo.TipoGastoID);
            cmd.Parameters.AddWithValue("@qtdParcelas", modelo.QtdParcelas);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@total", modelo.Total);
            cmd.Parameters.AddWithValue("@idFormaPagamento", modelo.FormaPagamentoID);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@emissao", modelo.Emissão);
            cmd.Parameters.AddWithValue("@vencimento", modelo.Vencimento);
            cmd.Parameters.AddWithValue("@numDoc", modelo.NumDoc);
            cmd.Parameters.AddWithValue("@tipoPessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@idPessoa", modelo.PessoaID);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@periodo", modelo.Periodo);
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

        //OPÇÕES DE LOCALIZAR E CARREGAR GRID--------------------------------------------------
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, cp.numDoc, cp.nome, cp.tipoPessoa, f.nomefantasia, cp.valor, cp.vencimento, cp.emissao, cp.dataCadastro, tg.nome, cp.status" +
                " from contapagar cp" +
                " inner join tipogasto tg on(cp.idTipoGasto = tg.id) " +
                " inner join fornecedor f on(cp.idPessoa = f.id) " +
                " order by cp.id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarCliente()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, cp.numDoc, cp.nome, cp.tipoPessoa, c.nomefantasia, cp.valor, cp.vencimento, cp.emissao, cp.dataCadastro, tg.nome, cp.status" +
                " from contapagar cp" +
                " inner join tipogasto tg on(cp.idTipoGasto = tg.id) " +
                " inner join cliente c on(cp.idPessoa = c.id) " +
                " where cp.tipoPessoa = 'CLIENTE' " +
                " group by cp.id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarFornecedor()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, cp.numDoc, cp.nome, cp.tipoPessoa, f.nomefantasia, cp.valor, cp.vencimento, cp.emissao, cp.dataCadastro, tg.nome, cp.status" +
                " from contapagar cp" +
                " inner join tipogasto tg on(cp.idTipoGasto = tg.id) " +
                " inner join fornecedor f on(cp.idPessoa = f.id) " +
                " where cp.tipoPessoa = 'FORNECEDOR' " +
                " group by cp.id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //MELHORAR PESQUISA DO CONTASPAGAR
        public DataTable LocalizarTodos(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select cp.id, cp.numDoc, cp.nome, cp.tipoPessoa, f.nomefantasia, cp.valor, cp.vencimento, cp.emissao, cp.dataCadastro, tg.nome, cp.status" +
                " from contapagar cp" +
                " inner join tipogasto tg on(cp.idTipoGasto = tg.id) " +
                " inner join fornecedor f on(cp.idPessoa = f.id) " +
                " where cp.id like '%" + valor + "%' or cp.nome like '%" + valor + "%' or cp.numDoc like '%" + valor + "%' or f.nomefantasia like '%" + valor + "%' or cp.valor like '%" + valor + "%' or tg.nome like '%" + valor + "%' or cp.status like '%" + valor + "%'" +
                " group by cp.id ", conexao.StringConexao);
            
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

        //CARREGAR DADOS DA TABELA PARA O FORM-------------------------------------------------
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
                modelo.ContaPagarID = Convert.ToInt64(registro["id"]);
                modelo.IdInterno = Convert.ToInt64(registro["idInterno"]);
                modelo.DataCadastro = Convert.ToString(registro["dataCadastro"]);
                modelo.TipoGastoID = Convert.ToInt32(registro["idTipoGasto"]);
                modelo.QtdParcelas = Convert.ToInt32(registro["qtdParcelas"]);
                modelo.Valor = Convert.ToDecimal(registro["valor"]);
                modelo.Total = Convert.ToDecimal(registro["total"]);
                modelo.FormaPagamentoID = Convert.ToInt32(registro["idFormaPagamento"]);
                modelo.Descricao = Convert.ToString(registro["nome"]);
                modelo.Emissão = Convert.ToDateTime(registro["emissao"]);
                modelo.Vencimento = Convert.ToDateTime(registro["vencimento"]);
                modelo.NumDoc = Convert.ToInt64(registro["numDoc"]);
                modelo.TipoPessoa = Convert.ToString(registro["tipoPessoa"]);
                modelo.PessoaID = Convert.ToInt32(registro["idPessoa"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.Periodo = Convert.ToString(registro["periodo"]);
                modelo.Status = Convert.ToString(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
        
        //CARREGAR COMBOS----------------------------------------------------------------------
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

        //CONTAR LINHAS DE UMA TABELA NO BANCO-------------------------------------------------
        public int ContaLinhasTabela()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select count(*) from contapagar";
            conexao.Conectar();
            int total = Convert.ToInt32(cmd.ExecuteNonQuery());
            conexao.Desconectar();
            return total;
        }

        //VERIFICAR ULTIMO ID INSERIDO NA TABELA DO BANCO--------------------------------------
        public string VerificaUltimoIdInserido()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select max(id) from contapagar";
            conexao.Conectar();
            string id = Convert.ToString(cmd.ExecuteScalar());
            conexao.Desconectar();
            return id;
        }

        //CALCULA DIFERENCA NA DIVISAO---------------------------------------------------------
        public decimal CalculoComDiferenca(decimal valortotal, int qtdparcelas)
        {
            decimal resultado = valortotal / qtdparcelas;
            decimal valorparcela = Math.Round(resultado, 2);
            decimal resultadodif = valortotal - (valorparcela * qtdparcelas);
            decimal dif = Math.Round(resultadodif, 2);
            decimal resComDif = 0;
            if (dif < 0)
            {
                resComDif = valorparcela + dif;
                return resComDif;
                
            }
            else if (dif > 0)
            {
                resComDif = valorparcela + dif;
                return resComDif;
            }
            else
            {
                resComDif = Math.Round(resultado, 2);
                return valorparcela;
            }
            //return resComDif;
        }

        //CALCULA DIFERENCA NA DIVISAO---------------------------------------------------------
        public decimal CalculoSemDiferenca(decimal valortotal, int qtdparcelas)
        {
            decimal resultado = valortotal / qtdparcelas;
            decimal valorparcela = Math.Round(resultado, 2);            
            return valorparcela;
        }

        //VERIFICAR ULTIMO ID INTERNO INSERIDO NA TABELA DO BANCO------------------------------
        public string VerificaUltimoIdInternoInserido()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select max(idInterno) from contapagar";
            conexao.Conectar();
            string id = Convert.ToString(cmd.ExecuteScalar());
            conexao.Desconectar();
            return id;
        }

        //GERA UMA SEQUENCIA DE NUMERO NA ORDEM PELO ID INTERNO--------------------------------
        public int GeraIdInterno()
        {
            int idinterno;
           
            var ultimoId = VerificaUltimoIdInternoInserido();
            if (ultimoId == "")
            {
                idinterno = 1;
                return idinterno;
            }
            else
            {
                idinterno = (Convert.ToInt32(ultimoId)+1);
                return idinterno;
            }
        }

        
    }


}
