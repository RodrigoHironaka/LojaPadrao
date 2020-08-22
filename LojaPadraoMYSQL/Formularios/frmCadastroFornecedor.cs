using BLL;
using DAL;
using Ferramentas;
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
using static Ferramentas.ValidaCEP;

namespace LojaPadraoMYSQL.Formularios
{

    public partial class frmCadastroFornecedor : Form
    {
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

        //---------------------------------------------------------------------
        public string foto = "";

        public string nome = "";
        public frmCadastroFornecedor()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
        }

        public frmCadastroFornecedor(ModeloFornecedor modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.FornecedorId);
            txtNomeVendedor.Text = modelo.NomeVendedor;
            txtNomeFantasia.Text = modelo.NomeFantasia;
            txtRazaoSocial.Text = modelo.RazaoSocial;
            mskIe.Text = modelo.IE;
            mskCnpj.Text = modelo.CNPJ;
            txtEndereco.Text = modelo.Endereco;
            txtNumero.Text = modelo.Numero;
            txtComplemento.Text = modelo.Complemento;
            txtBairro.Text = modelo.Bairro;
            mskCep.Text = modelo.CEP;
            txtIdCidade.Text = Convert.ToString(modelo.CidadeId);
            if (txtIdCidade.Text != "")
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCidade bll = new BLLCidade(cx);
                ModeloCidade modelocidade = bll.CarregaModeloCidade(Convert.ToInt32(txtIdCidade.Text));
                txtNomeCidade.Text = modelocidade.Nome;
                txtUf.Text = modelocidade.UF;
            }
            else
            {
                txtIdCidade.Clear();
                txtNomeCidade.Clear();
                txtUf.Clear();
            }
            txtEmail.Text = modelo.Email;
            mskTelefone.Text = modelo.Telefone;
            mskCelular.Text = modelo.Celular;
            mskCelular2.Text = modelo.Celular2;
            txtObservacao.Text = modelo.Observacao;
            txtDataCadastro.Text = modelo.DataCadastro;
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

        private void txtIdCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btProcurarCidade_Click(object sender, EventArgs e)
        {
            frmConsultaCidade f = new frmConsultaCidade(true);
            f.ShowDialog();
            if (f.id != 0)
            {
                txtIdCidade.Text = f.id.ToString();
                txtIdCidade_Leave(sender, e);
            }
        }

        private void txtIdCidade_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCidade bll = new BLLCidade(cx);
                ModeloCidade modelo = bll.CarregaModeloCidade(Convert.ToInt32(txtIdCidade.Text));
                if (modelo.CidadeId <= 0)
                {
                    txtIdCidade.Clear();
                    txtNomeCidade.Clear();
                    txtUf.Clear();
                }
                else
                {
                    txtNomeCidade.Text = modelo.Nome;
                    txtUf.Text = modelo.UF;
                }

            }
            catch
            {
                txtIdCidade.Clear();
                txtNomeCidade.Clear();
                txtUf.Clear();
            }
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (ValidaCEP.ValidaCep(mskCep.Text) == false)
            {
                pctCepInvalido.Visible = true;

                txtIdCidade.Clear();
                txtBairro.Clear();
                txtUf.Clear();
                txtNomeCidade.Clear();
                txtEndereco.Clear();
            }
            else if (BuscaEndereco.verificaCEP(mskCep.Text) == true)
            {
                pctCepInvalido.Visible = false;
                txtBairro.Text = BuscaEndereco.bairro;
                txtUf.Text = BuscaEndereco.estado;
                txtNomeCidade.Text = BuscaEndereco.cidade;
                txtEndereco.Text = BuscaEndereco.endereco;
            }
        }

        private void txtNomeCidade_TextChanged(object sender, EventArgs e)
        {
            this.nome = txtNomeCidade.Text;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            ModeloCidade modelo = bll.LocalizarPorNomeCidade(nome);
            if (txtNomeCidade.Text != "")
            {
                txtIdCidade.Text = modelo.CidadeId.ToString();
            }
        }

        private void mskCnpj_Leave(object sender, EventArgs e)
        {
            pctCnpjInvalido.Visible = false;
            string valor = mskCnpj.Text;
            if (ValidaCpfCnpj.ValidaCnpj(valor) == false)
            {
                pctCnpjInvalido.Visible = true;
            }
        }

        private void txtIdCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.NomeVendedor = txtNomeVendedor.Text;
                modelo.NomeFantasia = txtNomeFantasia.Text;
                modelo.RazaoSocial = txtRazaoSocial.Text;
                if (pctCnpjInvalido.Visible == true)
                {
                    MessageBox.Show("Digite um valor válido no campo CPF/CNPJ!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    modelo.CNPJ = mskCnpj.Text;
                }
                modelo.IE = mskIe.Text;
                modelo.Endereco = txtEndereco.Text;
                modelo.Numero = txtNumero.Text;
                modelo.Complemento = txtComplemento.Text;
                modelo.Bairro = txtBairro.Text;
                if (pctCepInvalido.Visible == true)
                {
                    MessageBox.Show("Digite um valor válido no campo CEP!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if ((txtIdCidade.Text == "") && (txtNomeCidade.Text == "") && (txtUf.Text == ""))
                {
                    MessageBox.Show("CEP Inválido!!! Digite novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    modelo.CEP = mskCep.Text;
                }
                modelo.CidadeId = Convert.ToInt32(txtIdCidade.Text);
                modelo.Email = txtEmail.Text;
                modelo.Telefone = mskTelefone.Text;
                modelo.Celular = mskTelefone.Text;
                modelo.Celular2 = mskCelular2.Text;
                modelo.Observacao = txtObservacao.Text;
                modelo.DataCadastro = txtDataCadastro.Text;
                if (pbFoto.Image != null)
                {
                    modelo.Foto = ConverterEmByte(pbFoto.Image);
                }
                else
                {
                    modelo.Foto = null;
                }

                if (chbAtivo.Checked == true)
                    modelo.Status = Convert.ToChar("A");
                else if (chbAtivo.Checked == false)
                    modelo.Status = Convert.ToChar("I");

                if (txtID.Text == "")
                {
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    this.Close();
                }
                else
                {
                    modelo.FornecedorId = Int32.Parse(txtID.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloFornecedor mt = bll.CarregaModeloFornecedor(modelo.FornecedorId);
                        modelo.Foto = mt.Foto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                this.LimpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void LimpaTela()
        {
            txtNomeVendedor.Clear();
            txtNomeFantasia.Clear();
            mskCnpj.Clear();
            mskIe.Clear();
            txtRazaoSocial.Clear();
            chbAtivo.Checked = true;
            mskCep.Text = "17800000";
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            mskCelular2.Clear();
            txtEmail.Clear();
            txtIdCidade.Clear();
            txtNomeCidade.Clear();
            txtUf.Clear();
            txtObservacao.Clear();
        }

        private void btAddFoto_Click_1(object sender, EventArgs e)
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
    }
}
