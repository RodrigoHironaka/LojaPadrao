using BLL;
using DAL;
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
        public frmCadastroProduto()
        {
            InitializeComponent();
            cbTipoProduto.SelectedIndex = 0;
            cbTipoProduto.Focus();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
        }

        public frmCadastroProduto(ModeloProduto modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.ProdutoID);
            txtNumSerie.Text = Convert.ToString(modelo.NumSerie);
            cbTipoProduto.Text = modelo.TipoProduto;
            txtDataCadastro.Text = modelo.DataCadastro;
            txtNome.Text = modelo.Nome;
            txtApelido.Text = modelo.Apelido;
            //cnbUN.Text = modelo.UNID;
            if (txtCodGrupo.Text != "")
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLGrupo bll = new BLLGrupo(cx);
                ModeloGrupo modelogrupo = bll.CarregaModeloGrupo(Convert.ToInt32(txtCodGrupo.Text));
                txtNome.Text = modelogrupo.Nome;
            }
            else
            {
                txtCodGrupo.Clear();
                txtNomeGrupo.Clear();
            }
            //cbTipoPessoa.Text = modelo.TipoPessoa;
            //txtEndereco.Text = modelo.Endereco;
            //txtNumero.Text = modelo.Numero;
            //txtComplemento.Text = modelo.Complemento;
            //txtBairro.Text = modelo.Bairro;
            //mskCep.Text = modelo.CEP;
            //mskDataNasc.Text = modelo.DataNasc;
            //txtIdCidade.Text = Convert.ToString(modelo.CidadeId);
            
            //txtEmail.Text = modelo.Email;
            //mskTelefone.Text = modelo.Telefone;
            //mskCelular.Text = modelo.Celular;
            //mskCelular2.Text = modelo.Celular2;
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
    }
}
