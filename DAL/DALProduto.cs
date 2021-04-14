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
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into produto(" +
                "numSerie,tipoProduto,dataCadastro,nome,apelido,idUN,idGrupo,idSubGrupo,idFornecedor,idMarca,precoCusto,porcentagemCusto," +
                "precoAvista,porcentagemAvista,precoPrazo,porcentagemDesconto,precoDesconto,estoqueAtual,estoqueMax,estoqueMin," +
                "controleEstoque,observacao,foto,status)" +
                " values (" +
                "@numSerie,@tipoProduto,@dataCadastro,@nome,@apelido,@idUN,@idGrupo,@idSubGrupo,@idFornecedor,@idMarca,@precoCusto," +
                "@porcentagemCusto,@precoAvista,@porcentagemAvista,@precoPrazo,@porcentagemDesconto,@precoDesconto,@estoqueAtual," +
                "@estoqueMax,@estoqueMin,@controleEstoque,@observacao,@foto,@status);";
            cmd.Parameters.AddWithValue("@numSerie", modelo.NumSerie);
            cmd.Parameters.AddWithValue("@tipoProduto", modelo.TipoProduto);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@idUN", modelo.UNID);
            cmd.Parameters.AddWithValue("@idGrupo", modelo.GrupoID);
            cmd.Parameters.AddWithValue("@idSubGrupo", modelo.SubGruooID);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@idMarca", modelo.MarcaID);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.Parameters.AddWithValue("@porcentagemDesconto", modelo.PorcentagemDesconto);
            cmd.Parameters.AddWithValue("@precoDesconto", modelo.PrecoDesconto);
            cmd.Parameters.AddWithValue("@estoqueAtual", modelo.EstoqueAtual);
            cmd.Parameters.AddWithValue("@estoqueMax", modelo.EstoqueMax);
            cmd.Parameters.AddWithValue("@estoqueMin", modelo.EstoqueMin);
            cmd.Parameters.AddWithValue("@controleEstoque", modelo.ControlarEstoque);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.Add("@foto", MySqlDbType.LongBlob);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Foto;
            }
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.ProdutoID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update produto set numSerie=@numSerie,tipoProduto=@tipoProduto,nome=@nome,apelido=@apelido,idUN=@idUN,idGrupo=@idGrupo,idSubGrupo=@idSubGrupo,idFornecedor=@idFornecedor,idMarca=@idMarca,precoCusto=@precoCusto,porcentagemCusto=@porcentagemCusto,precoAvista=@precoAvista,porcentagemAvista=@porcentagemAvista,precoPrazo=@precoPrazo,porcentagemDesconto=@porcentagemDesconto,precoDesconto=@precoDesconto,estoqueAtual=@estoqueAtual,estoqueMax=@estoqueMax,estoqueMin=@estoqueMin,controleEstoque=@controleEstoque,observacao=@observacao,foto=@foto,status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@numSerie", modelo.NumSerie);
            cmd.Parameters.AddWithValue("@tipoProduto", modelo.TipoProduto);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@idUN", modelo.UNID);
            cmd.Parameters.AddWithValue("@idGrupo", modelo.GrupoID);
            cmd.Parameters.AddWithValue("@idSubGrupo", modelo.SubGruooID);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@idMarca", modelo.MarcaID);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.Parameters.AddWithValue("@porcentagemDesconto", modelo.PorcentagemDesconto);
            cmd.Parameters.AddWithValue("@precoDesconto", modelo.PrecoDesconto);
            cmd.Parameters.AddWithValue("@estoqueAtual", modelo.EstoqueAtual);
            cmd.Parameters.AddWithValue("@estoqueMax", modelo.EstoqueMax);
            cmd.Parameters.AddWithValue("@estoqueMin", modelo.EstoqueMin);
            cmd.Parameters.AddWithValue("@controleEstoque", modelo.ControlarEstoque);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.Add("@foto", MySqlDbType.LongBlob);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Foto;
            }
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.ProdutoID);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from produto where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from produto where nome like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from produto where (nome like '%" + valor + "%' or (id like '%" + valor + "%') and status='A')", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from produto where (nome like '%" + valor + "%' or (id like '%" + valor + "%') and status='I')", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from produto order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from produto where status='A' order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from produto where status='I' order by id", conexao.StringConexao);
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

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProdutoID = Convert.ToInt32(registro["id"]);
                modelo.NumSerie = Convert.ToString(registro["numSerie"]);
                modelo.TipoProduto = Convert.ToString(registro["tipoProduto"]);
                modelo.DataCadastro = Convert.ToString(registro["dataCadastro"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Apelido = Convert.ToString(registro["apelido"]);
                modelo.UNID = Convert.ToInt32(registro["idUN"]);
                modelo.GrupoID = Convert.ToInt32(registro["idGrupo"]);
                modelo.SubGruooID = Convert.ToInt32(registro["idSubGrupo"]);
                modelo.FornecedorID = Convert.ToInt32(registro["idFornecedor"]);
                modelo.MarcaID = Convert.ToInt32(registro["idMarca"]);
                modelo.PrecoCusto = Convert.ToDecimal(registro["precoCusto"]);
                modelo.PorcentagemCusto = Convert.ToDecimal(registro["porcentagemCusto"]);
                modelo.PrecoAvista = Convert.ToDecimal(registro["precoAvista"]);
                modelo.PorcentagemAvista = Convert.ToDecimal(registro["porcentagemAvista"]);
                modelo.PrecoPrazo = Convert.ToDecimal(registro["precoPrazo"]);
                modelo.PorcentagemDesconto = Convert.ToDecimal(registro["porcentagemDesconto"]);
                modelo.PrecoDesconto = Convert.ToDecimal(registro["precoDesconto"]);
                modelo.EstoqueAtual = Convert.ToDecimal(registro["estoqueAtual"]);
                modelo.EstoqueMax = Convert.ToDecimal(registro["estoqueMax"]);
                modelo.EstoqueMin = Convert.ToDecimal(registro["estoqueMin"]);
                modelo.ControlarEstoque = Convert.ToChar(registro["controleEstoque"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
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

        public DataTable CarregaComboUN()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id, sigla FROM unidademedida where status = 'A' ORDER BY sigla", conexao.StringConexao);
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

        public double CalculaPorPorcentagem(double valor, double porcentagem)
        {
            double resultado = (valor * (porcentagem / 100) + valor);
            return resultado;
        }

        public double CalculaRegraDeTresPorcentagem(double valor, double valor2)
        {
            double res = valor2 - valor;
            double porcentagem = (100 * res) / valor;
            return porcentagem;
        }

        public double CalculaPorPorcentagemDesconto(double valor, double porcentagem)
        {
            double resultado = valor * (porcentagem / 100);
            return resultado;
        }

        public double CalculaRegraDeTresPorcentagemDesconto(double valor, double valor2)
        {
            double porcentagem = (100 * valor2) / valor;
            return porcentagem;

        }

        public void CarregaVariasImagens()
        {
            /*
             //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\macoratti\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivos.Text += arquivo + "#";
                    // cria um PictureBox
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 100;
                        pb.Width = 100;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pb);

                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                        "Mensagem : " + ex.Message + "\n\n" +
                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(arquivo.LastIndexOf('\\'))
                                         + ". Você pode não ter permissão para ler o arquivo , ou " +
                                         " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            */
           
        }

    }
}
