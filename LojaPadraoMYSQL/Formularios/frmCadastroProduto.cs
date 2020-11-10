using BLL;
using DAL;
using Ferramentas.Mascaras;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmCadastroProduto : Form
    {
        //----------------------------CARREGA COMBOBOX UNIDADE DE MEDIDA-------------------------------
        private void carregaUN()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            cnbUN.DataSource = bll.CarregaComboUN();
            cnbUN.ValueMember = "id";
            cnbUN.DisplayMember = "sigla";
        }

        //----------------------------CONVERSAO DE IMAGENS--------------------------------------------
        //Converte imagem um Byte[] array
        public byte[] ConverterEmByte(System.Drawing.Image imagem)
        {
            MemoryStream ms = new MemoryStream();
            imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        //Converte byte[] array para imagem
        public Image ConverterImagem(byte[] foto)
        {
            MemoryStream ms = new MemoryStream(foto);
            Image retornaImagem = Image.FromStream(ms);
            return retornaImagem;
        }

        //------------------------FUNCAO LIMPA OS CAMPOS DIGITADOS-------------------------------------
        public void LimpaTela()
        {
            txtNumSerie.Clear();
            cbTipoProduto.SelectedIndex = 0;
            txtNome.Clear();
            txtApelido.Clear();
            cnbUN.SelectedValue = 1;
            txtCodGrupo.Clear();
            txtNomeGrupo.Clear();
            txtCodSubGrupo.Clear();
            txtNomeSubGrupo.Clear();
            txtCodFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtCodMarca.Clear();
            txtNomeMarca.Clear();
            txtPrecoCusto.Text = "0,00";
            txtPorcCusto.Text = "0";
            txtPrecoAvista.Text = "0,00";
            txtPorcAvista.Text = "0";
            txtPrecoPrazo.Text = "0,00";
            txtPorcDesconto.Text = "0";
            txtPrecoDesconto.Text = "0,00";
            txtEstqAtual.Text = "0,00";
            txtEstqMax.Text = "0,00";
            txtEstqMin.Text = "0,00";
            txtObservacao.Clear();
            pbFoto.Image = null;
        }

        //------------------------VARIAVEIS------------------------------------------------------------
        public string nome = "";

        //----------------------------INICIALIZA FORMULARIO PARA NOVO CADASTRO-------------------------
        public frmCadastroProduto()
        {
            InitializeComponent();
            this.carregaUN();

            cbTipoProduto.SelectedIndex = 0;
            cbTipoProduto.Focus();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();


        }

        //----------------------------CARREGA DADOS PARA ALTERAR---------------------------------------
        public frmCadastroProduto(ModeloProduto modelo)
        {
            InitializeComponent();
            this.carregaUN();

            txtID.Text = Convert.ToString(modelo.ProdutoID);
            txtNumSerie.Text = Convert.ToString(modelo.NumSerie);
            cbTipoProduto.Text = modelo.TipoProduto;
            txtDataCadastro.Text = modelo.DataCadastro;
            txtNome.Text = modelo.Nome;
            txtApelido.Text = modelo.Apelido;
            cnbUN.SelectedValue = modelo.UNID.ToString();
            if (txtCodGrupo.Text != "")
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLGrupo bll = new BLLGrupo(cx);
                ModeloGrupo modelogrupo = bll.CarregaModeloGrupo(Convert.ToInt32(txtCodGrupo.Text));
                txtNomeGrupo.Text = modelogrupo.Nome;
            }
            else
            {
                txtCodGrupo.Clear();
                txtNomeGrupo.Clear();
            }
            if (txtCodSubGrupo.Text != "")
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                ModeloSubGrupo modelosubgrupo = bll.CarregaModeloSubGrupo(Convert.ToInt32(txtCodSubGrupo.Text));
                txtNomeSubGrupo.Text = modelosubgrupo.Nome;
            }
            else
            {
                txtCodSubGrupo.Clear();
                txtNomeSubGrupo.Clear();
            }
            if (txtCodFornecedor.Text != "")
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modeloFornecedor = bll.CarregaModeloFornecedor(Convert.ToInt32(txtCodFornecedor.Text));
                txtNomeFornecedor.Text = modeloFornecedor.NomeVendedor;
            }
            else
            {
                txtCodFornecedor.Clear();
                txtNomeFornecedor.Clear();
            }
            if (txtCodMarca.Text != "")
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                ModeloMarca modeloMarca = bll.CarregaModeloMarca(Convert.ToInt32(txtCodMarca.Text));
                txtNomeMarca.Text = modeloMarca.Nome;
            }
            else
            {
                txtCodMarca.Clear();
                txtNomeMarca.Clear();
            }
            txtPrecoCusto.Text = modelo.PrecoCusto.ToString();
            txtPorcCusto.Text = modelo.PorcentagemCusto.ToString();
            txtPrecoAvista.Text = modelo.PrecoAvista.ToString();
            txtPorcAvista.Text = modelo.PorcentagemAvista.ToString();
            txtPrecoPrazo.Text = modelo.PrecoPrazo.ToString();
            txtPorcDesconto.Text = modelo.PorcentagemDesconto.ToString();
            txtPrecoDesconto.Text = modelo.PrecoDesconto.ToString();
            txtEstqAtual.Text = modelo.EstoqueAtual.ToString();
            txtEstqMax.Text = modelo.EstoqueMax.ToString();
            txtEstqMin.Text = modelo.EstoqueMin.ToString();
            if (modelo.ControlarEstoque.Equals('S'))
                chbAtivo.Checked = true;
            else if (modelo.Status.Equals('N'))
                chbAtivo.Checked = false;
            txtObservacao.Text = modelo.Observacao;
            if (modelo.Foto != null)
            {
                pbFoto.Image = ConverterImagem(modelo.Foto);
            }
            else
            {
                pbFoto.Image = null;
            }
            if (modelo.Status.Equals('A'))
                chbAtivo.Checked = true;
            else if (modelo.Status.Equals('I'))
                chbAtivo.Checked = false;
        }

        //----------------------------SALVA PRODUTO----------------------------------------------------
        private void btSalvar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //    BLLProduto bll = new BLLProduto(cx);
            //    ModeloProduto modelo = new ModeloProduto();
            //    modelo.NomeFantasia = txtNomeFantasia.Text;
            //    modelo.RazaoSocial = txtRazaoSocial.Text;
            //    modelo.RGIE = mskRgIe.Text;
            //    modelo.TipoPessoa = cbTipoPessoa.Text;
            //    modelo.Endereco = txtEndereco.Text;
            //    modelo.Numero = txtNumero.Text;
            //    modelo.Complemento = txtComplemento.Text;
            //    modelo.Bairro = txtBairro.Text;
            //    modelo.DataNasc = mskDataNasc.Text;
            //    modelo.CidadeId = Convert.ToInt32(txtIdCidade.Text);
            //    modelo.Email = txtEmail.Text;
            //    modelo.Telefone = mskTelefone.Text;
            //    modelo.Celular = mskTelefone.Text;
            //    modelo.Celular2 = mskCelular2.Text;
            //    modelo.Observacao = txtObservacao.Text;
            //    modelo.DataCadastro = txtDataCadastro.Text;
            //    if (pbFoto.Image != null)
            //    {
            //        modelo.Foto = ConverterEmByte(pbFoto.Image);
            //    }
            //    else
            //    {
            //        modelo.Foto = null;
            //    }

            //    if (chbAtivo.Checked == true)
            //        modelo.Status = Convert.ToChar("A");
            //    else if (chbAtivo.Checked == false)
            //        modelo.Status = Convert.ToChar("I");

            //    if (txtID.Text == "")
            //    {
            //        modelo.CarregaImagem(this.foto);
            //        bll.Incluir(modelo);
            //        this.Close();
            //    }
            //    else
            //    {
            //        modelo.ClienteId = Int32.Parse(txtID.Text);
            //        if (this.foto == "Foto Original")
            //        {
            //            ModeloCliente mt = bll.CarregaModeloCliente(modelo.ClienteId);
            //            modelo.Foto = mt.Foto;
            //        }
            //        else
            //        {
            //            modelo.CarregaImagem(this.foto);
            //        }
            //        bll.Alterar(modelo);
            //        MessageBox.Show("Cadastro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //    this.LimpaTela();
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
        }

        //----------------------------BUSCA POR CODIGO--------------------------------------------------
        //----------------------------BOTAO PARA BUSCAR NO FORMULARIO ESPECIFICO------------------------
        private void txtCodGrupo_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLGrupo bll = new BLLGrupo(cx);
                ModeloGrupo modelo = bll.CarregaModeloGrupo(Convert.ToInt32(txtCodGrupo.Text));
                if (modelo.GrupoId <= 0)
                {
                    txtCodGrupo.Clear();
                    txtNomeGrupo.Clear();
                }
                else
                {
                    txtNomeGrupo.Text = modelo.Nome;
                }

            }
            catch
            {
                txtCodGrupo.Clear();
                txtNomeGrupo.Clear();
            }
        }

        private void btnPesqGrupo_Click(object sender, EventArgs e)
        {
            frmConsultaGrupo f = new frmConsultaGrupo(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtCodGrupo.Text = f.id.ToString();
                txtCodGrupo_Leave(sender, e);
            }
        }

        private void txtCodSubGrupo_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubGrupo bll = new BLLSubGrupo(cx);
                ModeloSubGrupo modelo = bll.CarregaModeloSubGrupo(Convert.ToInt32(txtCodSubGrupo.Text));
                if (modelo.SubGrupoId <= 0)
                {
                    txtCodSubGrupo.Clear();
                    txtNomeSubGrupo.Clear();
                }
                else
                {
                    txtNomeSubGrupo.Text = modelo.Nome;
                }

            }
            catch
            {
                txtCodSubGrupo.Clear();
                txtNomeSubGrupo.Clear();
            }
        }

        private void btnPesqSubGrupo_Click(object sender, EventArgs e)
        {
            frmConsultaSubGrupo f = new frmConsultaSubGrupo(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtCodSubGrupo.Text = f.id.ToString();
                txtCodSubGrupo_Leave(sender, e);
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtCodFornecedor.Text));
                if (modelo.FornecedorId <= 0)
                {
                    txtCodFornecedor.Clear();
                    txtNomeFornecedor.Clear();
                }
                else
                {
                    txtNomeFornecedor.Text = modelo.NomeFantasia;
                }

            }
            catch
            {
                txtCodFornecedor.Clear();
                txtNomeFornecedor.Clear();
            }
        }

        private void btnPesqFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtCodFornecedor.Text = f.id.ToString();
                txtCodFornecedor_Leave(sender, e);
            }
        }

        private void txtCodMarca_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMarca bll = new BLLMarca(cx);
                ModeloMarca modelo = bll.CarregaModeloMarca(Convert.ToInt32(txtCodMarca.Text));
                if (modelo.MarcaId <= 0)
                {
                    txtCodMarca.Clear();
                    txtNomeMarca.Clear();
                }
                else
                {
                    txtNomeMarca.Text = modelo.Nome;
                }

            }
            catch
            {
                txtCodMarca.Clear();
                txtNomeMarca.Clear();
            }
        }

        private void btnPesqMarca_Click(object sender, EventArgs e)
        {
            frmConsultaMarca f = new frmConsultaMarca(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtCodMarca.Text = f.id.ToString();
                txtCodMarca_Leave(sender, e);
            }
        }


        //----------------------------DIGITA APENAS NUMEROS E VIRGULAS NOS CAMPOS------------------------
        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtPorcCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);

        }

        private void txtPorcAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPorcDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtPrecoDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtEstqAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtEstqMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }

        private void txtEstqMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecoCusto_KeyPress(sender, e);
        }


        //----------------------------SELECIONA TODO O TEXTO QNDO O FOCO ESTA NELE----------------------
        //----------------------------CONVERTE EM MOEDA-------------------------------------------------
        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            //Moeda.ConversaoMoeda(ref txtPrecoCusto);           
        }

        private void txtPrecoCusto_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectionStart = 0;
            ((TextBox)sender).SelectAll();
        }

        private void txtPrecoAvista_TextChanged(object sender, EventArgs e)
        {
            //Moeda.ConversaoMoeda(ref txtPrecoAvista);
        }

        private void txtPrecoAvista_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtPrecoPrazo_TextChanged(object sender, EventArgs e)
        {
            //Moeda.ConversaoMoeda(ref txtPrecoPrazo);
        }

        private void txtPrecoPrazo_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtPrecoDesconto_TextChanged(object sender, EventArgs e)
        {
            //Moeda.ConversaoMoeda(ref txtPrecoDesconto);
        }


        //----------------------------SELECIONA TODO O TEXTO QNDO O FOCO ESTA NELE-----------------------------
        private void txtPrecoDesconto_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtPorcCusto_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtPorcAvista_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtPorcDesconto_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtEstqAtual_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtEstqMax_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }

        private void txtEstqMin_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecoCusto_MouseClick(sender, e);
        }


        //----------------------------DIGITA APENAS NUMEROS NO CAMPO CODIGO----------------------------------
        private void txtCodGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodSubGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodGrupo_KeyPress(sender, e);
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodGrupo_KeyPress(sender, e);
        }

        private void txtCodMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodGrupo_KeyPress(sender, e);
        }


        //----------------------------BOTOES ADICIONAR E REMOVER FOTOS---------------------------------------
        public string foto = "";
        private void btAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btRemFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        //----------------------------BOTÃO PARA VERIFICAR SE CONTROLA OU NÃO----------------------------------
        private void chbControlarEstq_CheckedChanged(object sender, EventArgs e)
        {
            if (chbControlarEstq.Checked)
            {
                txtEstqAtual.Enabled = true;
                txtEstqMax.Enabled = true;
                txtEstqMin.Enabled = true;
            }
            else
            {
                txtEstqAtual.Clear();
                txtEstqMax.Clear();
                txtEstqMin.Clear();
                txtEstqAtual.Enabled = false;
                txtEstqMax.Enabled = false;
                txtEstqMin.Enabled = false;
            }
        }


        //----------------------------BOTÃO GERA NUM DE SERIE REFERENTE AO CODIDO DO PRODUTO-------------------
        private void btnGeraNumSerie_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtID.Text == "")
                {
                    MessageBox.Show("Voce deve salvar o produto antes de gerar o Numero de Serie!!!");
                }
                else
                {
                    var id = txtID.Text;
                    txtNumSerie.Text = (id.PadLeft(13, '0'));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //----------------------------OPÇÕES DE CALCULOS COM PORCENTAGENS E VALORES----------------------------
        private void txtPorcCusto_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                double custo = Convert.ToDouble(txtPrecoCusto.Text);
                double porcCusto = Convert.ToDouble(txtPorcCusto.Text);
                if ((porcCusto == 0) || (txtPorcCusto.TextLength <= 0))
                {
                    txtPrecoAvista.Text = custo.ToString("N2");
                }
                else
                {
                    txtPrecoAvista.Text = bll.CalculaPorPorcentagem(custo, porcCusto).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecoAvista_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoAvista.Text == String.Empty)
                { 
                    txtPrecoAvista.Text = txtPrecoCusto.Text;
                }

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                double avista = Convert.ToDouble(txtPrecoAvista.Text);
                double custo = Convert.ToDouble(txtPrecoCusto.Text);
                if(avista == 0)
                {
                    txtPrecoAvista.Text = custo.ToString("N2");
                   
                }
                else
                {
                    if (custo != 0)
                    {
                        txtPorcCusto.Text = bll.CalculaRegraDeTresPorcentagem(custo, avista).ToString("N2");
                    }
                    else
                    {
                        txtPorcCusto.Text = "0";
                    }
                }
                txtPrecoAvista.Text = avista.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtPorcAvista_Leave(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            double avista = Convert.ToDouble(txtPrecoAvista.Text);
            double porcAvista = Convert.ToDouble(txtPorcAvista.Text);
            txtPrecoPrazo.Text = bll.CalculaPorPorcentagem(avista, porcAvista).ToString("N2");
        }

        private void txtPrecoPrazo_Leave(object sender, EventArgs e)
        {

        }

        private void txtPorcDesconto_Leave(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            double avista = Convert.ToDouble(txtPrecoAvista.Text);
            double porcDesconto = Convert.ToDouble(txtPorcDesconto.Text);
            txtPrecoDesconto.Text = bll.CalculaPorPorcentagemDesconto(avista, porcDesconto).ToString("N2");
        }

        private void txtPrecoDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoDesconto.Text == "")
                {
                    txtPrecoDesconto.Text = "0,00";
                }
                else
                {
                    double desconto = Convert.ToDouble(txtPrecoDesconto.Text);
                    txtPrecoDesconto.Text = desconto.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoCusto.Text == "")
                {
                    txtPrecoCusto.Text = "0,00";
                }
                else
                {
                    double custo = Convert.ToDouble(txtPrecoCusto.Text);
                    txtPrecoCusto.Text = custo.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
