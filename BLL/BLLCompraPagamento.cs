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
    public class BLLCompraPagamento
    {
        private DALConexao conexao;
        public BLLCompraPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompraPagamento modelo)
        {
            //if (modelo.Nome.Trim().Length == 0)
            //{
            //    throw new Exception("O nome é obrigatório");
            //}
            //modelo.Nome = modelo.Nome.ToUpper();

            //if (modelo.Nome.Trim().Length > 100)
            //{
            //    throw new Exception("O limite máximo de caracteres é 100!");
            //}

            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCompraPagamento modelo)
        {
            //if (modelo.CompraId <= 0)
            //{
            //    throw new Exception("Digite o codigo");
            //}
            //if (modelo.Nome.Trim().Length == 0)
            //{
            //    throw new Exception("O nome é obrigatório");
            //}
            //modelo.Nome = modelo.Nome.ToUpper();

            //if (modelo.Nome.Trim().Length > 100)
            //{
            //    throw new Exception("O limite máximo de caracteres é 100!");
            //}

            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModeloCompraPagamento modelo)
        {
            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodosItens(int codigo)
        {
            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            DALObj.ExcluirTodosItens(codigo);
        }

        public DataTable Localizar(int valor)
        {
            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            return DALObj.Localizar(valor);
        }

        public ModeloCompraPagamento CarregaModeloCompraPagamento(int codigo, int idCompra, int idFormaPagamento)
        {
            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            return DALObj.CarregaModeloCompraPagamento(codigo, idCompra, idFormaPagamento);
        }

        public DataTable CarregaComboFormaPagamento()
        {
            DALCompraPagamento DALObj = new DALCompraPagamento(conexao);
            return DALObj.CarregaComboFormaPagamento();
        }
    }
}
