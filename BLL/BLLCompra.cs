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
    public class BLLCompra
    {
        private DALConexao conexao;
        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public int Incluir(ModeloCompra modelo)
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

            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.CompraId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            //if (modelo.Nome.Trim().Length == 0)
            //{
            //    throw new Exception("O nome é obrigatório");
            //}
            //modelo.Nome = modelo.Nome.ToUpper();

            //if (modelo.Nome.Trim().Length > 100)
            //{
            //    throw new Exception("O limite máximo de caracteres é 100!");
            //}

            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar(valor);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.CarregaModeloCompra(codigo);
        }
    }
}
