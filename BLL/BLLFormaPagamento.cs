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
    public class BLLFormaPagamento
    {
        private DALConexao conexao;
        public BLLFormaPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFormaPagamento modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 30)
            {
                throw new Exception("O limite máximo de caracteres é 30!");
            }

            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloFormaPagamento modelo)
        {
            if (modelo.FormaPagamentoId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 30)
            {
                throw new Exception("O limite máximo de caracteres é 30!");
            }

            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloFormaPagamento CarregaModeloFormaPagamento(int codigo)
        {
            DALFormaPagamento DALObj = new DALFormaPagamento(conexao);
            return DALObj.CarregaModeloFormaPagamento(codigo);
        }
    }
}
