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
    public class BLLDepartamento
    {
        private DALConexao conexao;
        public BLLDepartamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloDepartamento modelo)
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

            DALDepartamento DALObj = new DALDepartamento(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloDepartamento modelo)
        {
            if (modelo.DepartamentoId <= 0)
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

            DALDepartamento DALObj = new DALDepartamento(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloDepartamento CarregaModeloDepartamento(int codigo)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.CarregaModeloDepartamento(codigo);
        }

        public Int64 VerificaUltimoIdInserido()
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.VerificaUltimoIdInserido();
        }

        public DataTable LocalizarUltimoItemInserido()
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.LocalizarUltimoItemInserido();
        }

        public DataTable LocalizarUltimoItemAlterar(Int64 idAlterado)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.LocalizarUltimoItemAlterar(idAlterado);
        }
    }
}
