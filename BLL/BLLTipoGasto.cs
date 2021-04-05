using DAL.DALTipoGasto;
using DAL;
using Modelos.ModeloTipoGasto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLTipoGasto
{
    public class BLLTipoGasto
    {
        private DALConexao conexao;
        public BLLTipoGasto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(Modelo modelo)
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

            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(Modelo modelo)
        {
            if (modelo.Id <= 0)
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

            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
           DALTipoGasto DALObj = new DALTipoGasto(conexao);
           return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            return DALObj.CarregarGridInativo();
        }

        public Modelo CarregaModelo (int codigo)
        {
            DALTipoGasto DALObj = new DALTipoGasto(conexao);
            return DALObj.CarregaModelo(codigo);
        }
    }
}
