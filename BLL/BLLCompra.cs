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
            
            if ((modelo.NumNota == 0)||(modelo.NumNota.ToString() == ""))
            {
                throw new Exception("Número da nota precisa ser preenchido!");
            }
            if ((modelo.PrecoNota == 0) || (modelo.PrecoNota.ToString() == "0,00"))
            {
                throw new Exception("Preço da nota precisa ser diferente de zero!");
            }
            //if ((modelo.FornecedorId == 0) || (modelo.FornecedorId.ToString() == ""))
            //{
            //    modelo.FornecedorId = 1;
            //}
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.CompraId <= 0)
            {
                throw new Exception("Codigo da compra inválido!");
            }
            if ((modelo.NumNota == 0) || (modelo.NumNota.ToString() == ""))
            {
                throw new Exception("Número da nota precisa ser preenchido!");
            }
            if ((modelo.PrecoNota == 0) || (modelo.PrecoNota.ToString() == "0,00"))
            {
                throw new Exception("Preço da nota precisa ser diferente de zero!");
            }

            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar()
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar();
        }
        public DataTable LocalizarTodos(String valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarTodos(valor);
        }

        public DataTable LocalizarAbertos(String valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarAbertos(valor);
        }

        public DataTable LocalizarFaturados(String valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarFaturados(valor);
        }

        public DataTable LocalizarCancelados(String valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarCancelados(valor);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.CarregaModeloCompra(codigo);
        }
        public Boolean Cancelar(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da OS deve ser maior que zero!");
            }
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Cancelar(codigo);
        }
    }
}
