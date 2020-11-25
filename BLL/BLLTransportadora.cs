using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTransportadora
    {
        private DALConexao conexao;
        public BLLTransportadora(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTransportadora modelo)
        {
            if (modelo.NomeFantasia.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.NomeFantasia = modelo.NomeFantasia.ToUpper();

            if (modelo.NomeFantasia.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.CNPJ.Trim().Length == 0)
            {
                throw new Exception("O CPF e/ou CPNJ não pode ficar em branco");
            }
            //--------------------------------------------------------------------------

            if (modelo.CEP.Trim().Length == 0)
            {
                throw new Exception("O CEP não pode ficar em branco");
            }
            //--------------------------------------------------------------------------

            if (modelo.RazaoSocial.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres na Razão Social é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Endereco.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Endereço é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Numero.Trim().Length > 10)
            {
                throw new Exception("O limite máximo de caracteres no Numero é 10!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Complemento.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Complemento é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Bairro.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Bairro é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Email.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Email é 50!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Observacao.Trim().Length > 300)
            {
                throw new Exception("O limite máximo de caracteres na Observação é 300!");
            }

            DALTransportadora DALObj = new DALTransportadora(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloTransportadora modelo)
        {
            if (modelo.CidadeId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            //---------------------------------------------------------------------------

            if (modelo.NomeFantasia.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.NomeFantasia = modelo.NomeFantasia.ToUpper();

            if (modelo.NomeFantasia.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.RazaoSocial.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres na Razão Social é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Endereco.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Endereço é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Numero.Trim().Length > 10)
            {
                throw new Exception("O limite máximo de caracteres no Numero é 10!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Complemento.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Complemento é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Bairro.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Bairro é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Email.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Email é 50!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Observacao.Trim().Length > 300)
            {
                throw new Exception("O limite máximo de caracteres na Observação é 300!");
            }
            DALTransportadora DALObj = new DALTransportadora(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public ModeloCidade LocalizarPorNomeCidade(String nome)
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.LocalizarPorNomeCidade(nome);
        }

        public DataTable CarregaGrid()
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloTransportadora CarregaModeloTransportadora(int codigo)
        {
            DALTransportadora DALObj = new DALTransportadora(conexao);
            return DALObj.CarregaModeloTransportadora(codigo);
        }
    }
}
