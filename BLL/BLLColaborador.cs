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
    public class BLLColaborador
    {
        private DALConexao conexao;
        public BLLColaborador(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloColaborador modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.CPF.Trim().Length == 0)
            {
                throw new Exception("O CPF e/ou CPNJ não pode ficar em branco");
            }
            //--------------------------------------------------------------------------

            if (modelo.CEP.Trim().Length == 0)
            {
                throw new Exception("O CEP não pode ficar em branco");
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

            DALColaborador DALObj = new DALColaborador(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloColaborador modelo)
        {
            if (modelo.CidadeId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            //---------------------------------------------------------------------------

            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
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
            DALColaborador DALObj = new DALColaborador(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public ModeloCidade LocalizarPorNomeCidade(String nome)
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.LocalizarPorNomeCidade(nome);
        }

        public DataTable CarregaGrid()
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloColaborador CarregaModeloColaborador(int codigo)
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.CarregaModeloColaborador(codigo);
        }

        public DataTable CarregaComboFuncao()
        {
            DALColaborador DALObj = new DALColaborador(conexao);
            return DALObj.CarregaComboFuncao();
        }
    }
}
