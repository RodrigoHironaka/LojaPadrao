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

        public void Incluir(ModeloContaPagar modelo)
        {

            if (modelo.Descricao.ToString() == "")
            {
                throw new Exception("A descrição deve ser preenchida!");
            }
            if (modelo.Valor == 0)
            {
                throw new Exception("Por favor digite um valor maior que R$ 0,00;");
            }
            DALContaPagar DALObj = new DALContaPagar(conexao);
            DALObj.Incluir(modelo);
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

        public DataTable LocalizarTodos()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarTodos();
        }

        public DataTable LocalizarTodos(string valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarTodos(valor);
        }

        public DataTable LocalizarCliente()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarCliente();
        }

        public DataTable LocalizarCliente(string valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarCliente(valor);
        }

        public DataTable LocalizarFornecedor()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarFornecedor();
        }

        public DataTable LocalizarFornecedor(string valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarFornecedor(valor);
        }

        //public DataTable LocalizarTodos(String valor)
        //{
        //    DALContaPagar DALObj = new DALContaPagar(conexao);
        //    return DALObj.LocalizarTodos(valor);
        //}

        public DataTable LocalizarPendentes(String valor)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarPendentes(valor);
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

        public Int64 VerificaUltimoIdInserido()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.VerificaUltimoIdInserido();
        }

        public decimal CalculoComDiferenca(decimal valortotal, int qtdparcelas)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.CalculoComDiferenca(valortotal, qtdparcelas);
        }

        public decimal CalculoSemDiferenca(decimal valortotal, int qtdparcelas)
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.CalculoSemDiferenca(valortotal, qtdparcelas);
        }

        public Int64 VerificaUltimoIdInternoInserido()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.VerificaUltimoIdInternoInserido();
        }

        public int GeraIdInterno()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.GeraIdInterno();
        }

        public DataTable LocalizarUltimoItemInserido()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarUltimoItemInserido();
        }

        public DataTable LocalizarPorDataAtual()
        {
            DALContaPagar DALObj = new DALContaPagar(conexao);
            return DALObj.LocalizarPorDataAtual();
        }
    }
}
