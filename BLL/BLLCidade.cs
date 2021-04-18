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
    public class BLLCidade
    {
        private DALConexao conexao;
        public BLLCidade(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCidade modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres é 100!");
            }

            DALCidade DALObj = new DALCidade(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCidade modelo)
        {
            if (modelo.CidadeId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres é 100!");
            }

            DALCidade DALObj = new DALCidade(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCidade DALObj = new DALCidade(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloCidade CarregaModeloCidade(int codigo)
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.CarregaModeloCidade(codigo);
        }
        public Int64 VerificaUltimoIdInserido()
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.VerificaUltimoIdInserido();
        }
        public DataTable LocalizarUltimoItemInserido()
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.LocalizarUltimoItemInserido();
        }
        public DataTable LocalizarUltimoItemAlterar(Int64 idAlterado)
        {
            DALCidade DALObj = new DALCidade(conexao);
            return DALObj.LocalizarUltimoItemAlterar(idAlterado);
        }
    }
}
