﻿using BLL;
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

namespace LojaPadraoMYSQL.Formularios.Colaborador
{
    public partial class frmCadastroColaborador : Form
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

        public void LimpaTela()
        {
            txtNome.Clear();
            mskCpf.Clear();
            mskRg.Clear();
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
            cbFuncao.SelectedValue.ToString();
            txtNomeCidade.Clear();
            txtUf.Clear();
            txtObservacao.Clear();
        }
        //---------------------------------------------------------------------
        public string foto = "";

        public string nome = "";

        public frmCadastroColaborador()
        {
            InitializeComponent();
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
        }

        public frmCadastroColaborador(ModeloColaborador modelo)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(modelo.ColaboradorId);
            txtNome.Text = modelo.Nome;
            mskRg.Text = modelo.RG;
            mskCpf.Text = modelo.CPF;
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
            cbFuncao.SelectedValue = modelo.FuncaoId.ToString();
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
            BLLColaborador bll = new BLLColaborador(cx);
            ModeloCidade modelo = bll.LocalizarPorNomeCidade(nome);
            if (txtNomeCidade.Text != "")
            {
                txtIdCidade.Text = modelo.CidadeId.ToString();
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            pctCnpjInvalido.Visible = false;
            string valor = mskCpf.Text;
            if (ValidaCpfCnpj.ValidaCpf(valor) == false)
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

        //FALTA BOTAO SALVAR
        //FALTA ADD FOTO
        //FALTA REMOVER FOTO
        // FALTA KEYDOWN
    }
}