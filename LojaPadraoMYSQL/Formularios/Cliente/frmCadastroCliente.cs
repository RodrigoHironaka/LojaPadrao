using BLL;
using DAL;
using Ferramentas;
using Modelos;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static Ferramentas.ValidaCEP;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmCadastroCliente : Form
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
        //------------------------------------------------------------------

        public string nome = "";
        public frmCadastroCliente()
        {
            InitializeComponent();
            cbTipoPessoa.SelectedIndex = 0;
            cbTipoPessoa.Focus();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
           
        }
        public frmCadastroCliente(ModeloCliente modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.ClienteId);
            txtNomeFantasia.Text = modelo.NomeFantasia;
            txtRazaoSocial.Text = modelo.RazaoSocial;
            mskRgIe.Text = modelo.RGIE;
            mskCpfCnpj.Text = modelo.CPFCNPJ;
            cbTipoPessoa.Text = modelo.TipoPessoa;
            txtEndereco.Text = modelo.Endereco;
            txtNumero.Text = modelo.Numero;
            txtComplemento.Text = modelo.Complemento;
            txtBairro.Text = modelo.Bairro;
            mskCep.Text = modelo.CEP;
            mskDataNasc.Text = modelo.DataNasc;
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
            {
                chbAtivo.Checked = true;
                lbSit.Text = "CLIENTE ATIVADO";
                lbSit.Visible = true;
                lbSit.ForeColor = Color.White;
            }
            else if (modelo.Status.Equals('I'))
            {
                chbAtivo.Checked = false;
                lbSit.Text = "CLIENTE INATIVADO";
                lbSit.Visible = true;
                lbSit.ForeColor = Color.DarkRed;
            }
                
            
        }

        private void pctCalendario_Click(object sender, EventArgs e)
        {
            monthCalNasc.Visible = true;
        }

        private void monthCalNasc_DateSelected(object sender, DateRangeEventArgs e)
        {
            mskDataNasc.Text = Convert.ToString(monthCalNasc.SelectionStart.Date.ToShortDateString());
            DateTime datanasc = Convert.ToDateTime(mskDataNasc.Text);
            if (datanasc > System.DateTime.Now)
            {
                MessageBox.Show("Data inválida para nascimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDataNasc.Text = "";
            }
            monthCalNasc.Visible = false;
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

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                txtRazaoSocial.Enabled = false;
                lbRgIe.Text = "RG";
                mskRgIe.Mask = "00,000,000-0";
                lbCpfCnpj.Text = "CPF";
                mskCpfCnpj.Mask = "000,000,000-00";
                lbRazaoSocial.Enabled = false;
                lbNomeFantasia.Text = "Nome:";
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                txtRazaoSocial.Enabled = true;
                lbRgIe.Text = "IE";
                mskRgIe.Mask = "000,000,000,000";
                lbCpfCnpj.Text = "CNPJ";
                mskCpfCnpj.Mask = "00,000,000/0000-00";
                lbRazaoSocial.Enabled = true;
                lbNomeFantasia.Text = "Nome Fantasia:";
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
            BLLCliente bll = new BLLCliente(cx);
            ModeloCidade modelo = bll.LocalizarPorNomeCidade(nome);
            if (txtNomeCidade.Text != "")
            {
                txtIdCidade.Text = modelo.CidadeId.ToString();
            }
        }

        private void mskCpfCnpj_Leave(object sender, EventArgs e)
        {
            pctCpfcnpjInvalido.Visible = false;
            string valor = mskCpfCnpj.Text;
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                if (ValidaCpfCnpj.ValidaCpf(valor) == false)
                {
                    pctCpfcnpjInvalido.Visible = true;
                }
                else
                {
                    pctCpfcnpjInvalido.Visible = false;
                }

            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                if (ValidaCpfCnpj.ValidaCnpj(valor) == false)
                {
                    pctCpfcnpjInvalido.Visible = true;
                }
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
                    this.Close();
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
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = new ModeloCliente();
                modelo.NomeFantasia = txtNomeFantasia.Text;
                modelo.RazaoSocial = txtRazaoSocial.Text;
                if (pctCpfcnpjInvalido.Visible == true)
                {
                    MessageBox.Show("Digite um valor válido no campo CPF/CNPJ!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    modelo.CPFCNPJ = mskCpfCnpj.Text;
                }
                modelo.RGIE = mskRgIe.Text;
                modelo.TipoPessoa = cbTipoPessoa.Text;
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
                modelo.DataNasc = mskDataNasc.Text;
                modelo.CidadeId = Convert.ToInt32(txtIdCidade.Text);
                modelo.Email = txtEmail.Text;
                modelo.Telefone = mskTelefone.Text;
                modelo.Celular = mskTelefone.Text;
                modelo.Celular2 = mskCelular2.Text;
                modelo.Observacao = txtObservacao.Text;
                modelo.DataCadastro = txtDataCadastro.Text;
                if(pbFoto.Image != null)
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
                //----------------------------------------------------------------------------
                if (txtID.Text == "")
                {
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    this.Close();
                }
                else
                {
                    modelo.ClienteId = Int32.Parse(txtID.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloCliente mt = bll.CarregaModeloCliente(modelo.ClienteId);
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
            txtNomeFantasia.Clear();
            mskCpfCnpj.Clear();
            mskRgIe.Clear();
            txtRazaoSocial.Clear();
            cbTipoPessoa.SelectedIndex = 0;
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
            mskDataNasc.Clear();
            txtObservacao.Clear();
        }

        private void pctCalendario_DoubleClick(object sender, EventArgs e)
        {
            monthCalNasc.Visible = false;

        }

        private void tpageDadosPrincipais_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------
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

        private void frmCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyValue.Equals(27)) //ESC
            {
                btSair_Click(sender, e);
            }
        }
    }
}

