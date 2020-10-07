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
    public class BLLUnidadeMedida
    {
        private DALConexao conexao;
        public BLLUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeMedida modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres é 100!");
            }
            //--------------------------------------------------------------
            if (modelo.Sigla.Trim().Length == 0)
            {
                throw new Exception("A silgla é obrigatória");
            }
            modelo.Sigla = modelo.Sigla.ToUpper();

            if (modelo.Sigla.Trim().Length > 5)
            {
                throw new Exception("O limite máximo de caracteres é 5!");
            }

            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeMedida modelo)
        {
            if (modelo.UnidadeMedidaId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Nome.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres é 100!");
            }
            //--------------------------------------------------------------
            if (modelo.Sigla.Trim().Length == 0)
            {
                throw new Exception("A silgla é obrigatória");
            }
            modelo.Sigla = modelo.Sigla.ToUpper();

            if (modelo.Sigla.Trim().Length > 5)
            {
                throw new Exception("O limite máximo de caracteres é 5!");
            }

            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(conexao);
            return DALObj.CarregaModeloUnidadeMedida(codigo);
        }
    }
}
