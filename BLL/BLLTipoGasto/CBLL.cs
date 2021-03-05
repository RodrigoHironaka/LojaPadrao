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
    public class CBLL
    {
        private DALConexao conexao;
        public CBLL(DALConexao cx)
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

            CDAL DALObj = new CDAL(conexao);
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

            CDAL DALObj = new CDAL(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            CDAL DALObj = new CDAL(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
           CDAL DALObj = new CDAL(conexao);
           return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            CDAL DALObj = new CDAL(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            CDAL DALObj = new CDAL(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            CDAL DALObj = new CDAL(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            CDAL DALObj = new CDAL(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            CDAL DALObj = new CDAL(conexao);
            return DALObj.CarregarGridInativo();
        }

        public Modelo CarregaModelo (int codigo)
        {
            CDAL DALObj = new CDAL(conexao);
            return DALObj.CarregaModelo(codigo);
        }
    }
}
