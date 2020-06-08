using DAL;
using Modelos;
using System;
using System.Data;

namespace BLL
{
    public class BLLFuncao
    {
        private DALConexao conexao;
        public BLLFuncao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFuncao modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 50!");
            }

            if (modelo.Descricao.Trim().Length > 300)
            {
                throw new Exception("O limite máximo de caracteres na Descrição é 300!");
            }
            modelo.Descricao = modelo.Descricao.ToUpper();

            DALFuncao DALObj = new DALFuncao(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloFuncao modelo)
        {
            if (modelo.FuncaoId <= 0)
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
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
            }
            if (modelo.Descricao.Trim().Length > 300)
            {
                throw new Exception("O limite máximo de caracteres na Descrição é 300!");
            }
            modelo.Descricao = modelo.Descricao.ToUpper();

            DALFuncao DALObj = new DALFuncao(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloFuncao CarregaModeloFuncao(int codigo)
        {
            DALFuncao DALObj = new DALFuncao(conexao);
            return DALObj.CarregaModeloFuncao(codigo);
        }
    }
}
