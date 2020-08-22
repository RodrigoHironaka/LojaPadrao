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
    public class DALFornecedor
    {
        private DALConexao conexao;
        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFornecedor modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into fornecedor(nomeVendedor, nomeFantasia,razaoSocial,ie,cnpj,endereco,numero,complemento,bairro,cep,idCidade,email,telefone,celular,celular2,observacao,dataCadastro,status, foto)" +
                " values (@nomeVendedor, @nomeFantasia,@razaoSocial,@ie,@cnpj,@endereco,@numero,@complemento,@bairro,@cep,@idCidade,@email,@telefone,@celular,@celular2,@observacao,@dataCadastro,@status,@foto);";
            cmd.Parameters.AddWithValue("@nomeVendedor", modelo.NomeVendedor);
            cmd.Parameters.AddWithValue("@nomeFantasia", modelo.NomeFantasia);
            cmd.Parameters.AddWithValue("@razaoSocial", modelo.RazaoSocial);
            cmd.Parameters.AddWithValue("@ie", modelo.IE);
            cmd.Parameters.AddWithValue("@cnpj", modelo.CNPJ);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@numero", modelo.Numero);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@cep", modelo.CEP);
            cmd.Parameters.AddWithValue("@idCidade", modelo.CidadeId);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@celular2", modelo.Celular2);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.Add("@foto", MySqlDbType.LongBlob);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Foto;
            }
            conexao.Conectar();
            modelo.CidadeId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update fornecedor set nomeVendedor=@nomeVendedor, nomeFantasia=@nomeFantasia,razaoSocial=@razaoSocial,ie=@ie,cnpj=@cnpj,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cep=@cep,idCidade=@idCidade,email=@email,telefone=@telefone,celular=@celular,celular2=@celular2,observacao=@observacao,dataCadastro=@dataCadastro,status=@status, foto=@foto where id=@codigo;";
            cmd.Parameters.AddWithValue("@nomeVendedor", modelo.NomeVendedor);
            cmd.Parameters.AddWithValue("@nomeFantasia", modelo.NomeFantasia);
            cmd.Parameters.AddWithValue("@razaoSocial", modelo.RazaoSocial);
            cmd.Parameters.AddWithValue("@ie", modelo.IE);
            cmd.Parameters.AddWithValue("@cnpj", modelo.CNPJ);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@numero", modelo.Numero);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@cep", modelo.CEP);
            cmd.Parameters.AddWithValue("@idCidade", modelo.CidadeId);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@celular2", modelo.Celular2);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.Add("@foto", MySqlDbType.LongBlob);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Foto;
            }
            cmd.Parameters.AddWithValue("@codigo", modelo.FornecedorId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from fornecedor where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from fornecedor where nomeFantasia like '%" + valor + "%' or id like '%" + valor + "%' or nomeVendedor like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from fornecedor where (nomeFantasia like '%" + valor + "%' or (id like '%" + valor + "%') or (nomeVendedor like '%" + valor + "%') and status='A')", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from fornecedor where (nomefantasia like '%" + valor + "%' or (id like '%" + valor + "%') or (nomeVendedor like '%" + valor + "%') and status='I')", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCidade LocalizarPorNomeCidade(String nome)
        {
            ModeloCidade modelo = new ModeloCidade();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select id from cidade where nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CidadeId = Convert.ToInt32(registro["id"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public DataTable CarregarGrid()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from fornecedor order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from fornecedor where status='A' order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from fornecedor where status='I' order by id", conexao.StringConexao);
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

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FornecedorId = Convert.ToInt32(registro["id"]);
                modelo.NomeVendedor = Convert.ToString(registro["nomeVendedor"]);
                modelo.NomeFantasia = Convert.ToString(registro["nomeFantasia"]);
                modelo.RazaoSocial = Convert.ToString(registro["razaoSocial"]);
                modelo.IE = Convert.ToString(registro["ie"]);
                modelo.CNPJ = Convert.ToString(registro["cnpj"]);
                modelo.Endereco = Convert.ToString(registro["endereco"]);
                modelo.Numero = Convert.ToString(registro["numero"]);
                modelo.Complemento = Convert.ToString(registro["complemento"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.CEP = Convert.ToString(registro["cep"]);
                modelo.CidadeId = Convert.ToInt32(registro["idCidade"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Celular = Convert.ToString(registro["celular"]);
                modelo.Celular2 = Convert.ToString(registro["celular2"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.DataCadastro = Convert.ToString(registro["dataCadastro"]);
                modelo.Status = Convert.ToChar(registro["status"]);
                try
                {
                    modelo.Foto = (byte[])registro["foto"];
                }
                catch { }
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
