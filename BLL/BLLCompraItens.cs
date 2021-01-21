using DAL;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCompraItens
    {
        private DALConexao conexao;
        public BLLCompraItens(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompraItens modelo)
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

            DALCompraItens DALObj = new DALCompraItens(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCompraItens modelo)
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

            DALCompraItens DALObj = new DALCompraItens(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModeloCompraItens modelo)
        {
            DALCompraItens DALObj = new DALCompraItens(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodosItens(int codigo)
        {
            DALCompraItens DALObj = new DALCompraItens(conexao);
            DALObj.ExcluirTodosItens(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALCompraItens DALObj = new DALCompraItens(conexao);
            return DALObj.Localizar(codigo);
        }

        public ModeloCompraItens CarregaModeloCompraItens(int codigo, int idCompra, int idProduto)
        {
            DALCompraItens DALObj = new DALCompraItens(conexao);
            return DALObj.CarregaModeloCompraItens(codigo, idCompra, idProduto);
        }

        //public ModeloCompraItens CarregaGridItensCompra(int idCompra)
        //{
        //    DALCompraItens DALObj = new DALCompraItens(conexao);
        //    return DALObj.CarregaGridItensCompra(idCompra);
        //}
    }
}
