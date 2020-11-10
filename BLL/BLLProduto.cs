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
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
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

            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProdutoID <= 0)
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

            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregaModeloProduto(codigo);
        }

        public DataTable CarregaComboUN()
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregaComboUN();
        }

        public double CalculaPorPorcentagem(double valor, double porcentagem)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CalculaPorPorcentagem(valor, porcentagem);
        }

        public double CalculaRegraDeTresPorcentagem(double valor, double valor2)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CalculaRegraDeTresPorcentagem(valor, valor2);
        }

        public double CalculaPorPorcentagemDesconto(double valor, double porcentagem)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CalculaPorPorcentagemDesconto(valor, porcentagem);
        }
    }
}

