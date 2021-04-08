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
    public class BLLContasPagar
    {
        private DALConexao conexao;
        public BLLContasPagar(DALConexao cx)
        {
            this.conexao = cx;
        }

        public int Incluir(ModeloContaPagar modelo)
        {

            if (modelo.Descricao.ToString() == "")
            {
                throw new Exception("A descrição deve ser preenchida!");
            }
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloContaPagar modelo)
        {
            if (modelo.ContaPagarID <= 0)
            {
                throw new Exception("Codigo inválido!");
            }
            if (modelo.Descricao.ToString() == "")
            {
                throw new Exception("A descrição deve ser preenchida!");
            }
            DALContaPagar DALObj = new DALContaPagar(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            DALObj.Excluir(id);
        }

        public DataTable LocalizarCliente()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarCliente();
        }
        public DataTable LocalizarTodos(String valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarTodos(valor);
        }

        public DataTable LocalizarAbertos(String valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarAbertos(valor);
        }

        public DataTable LocalizarPagos(String valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarPagos(valor);
        }

        public DataTable LocalizarCancelados(String valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarCancelados(valor);
        }

        public ModeloContaPagar CarregaModeloContaPagar(int id)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.CarregaModeloContaPagar(id);
        }
        public Boolean Cancelar(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O código deve ser maior que zero!");
            }
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.Cancelar(id);
        }

        public DataTable CarregaComboFormaPagamento()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.CarregaComboFormaPagamento();
        }

        public DataTable CarregaComboTipoGasto()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.CarregaComboTipoGasto();
        }
    }
}
