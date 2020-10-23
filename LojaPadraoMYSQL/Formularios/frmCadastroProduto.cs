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
        private void carregaUN()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            cnbUN.DataSource = bll.CarregaComboUN();
            cnbUN.ValueMember = "id";
            cnbUN.DisplayMember = "sigla";
        }
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
            this.carregaUN();

            cbTipoProduto.SelectedIndex = 0;
            cbTipoProduto.Focus();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
        }

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

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

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
    }
}
