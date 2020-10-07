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
    public class BLLMarca
    {
        private DALConexao conexao;
        public BLLMarca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloMarca modelo)
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

            DALMarca DALObj = new DALMarca(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloMarca modelo)
        {
            if (modelo.MarcaId <= 0)
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

            DALMarca DALObj = new DALMarca(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALMarca DALObj = new DALMarca(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloMarca CarregaModeloMarca(int codigo)
        {
            DALMarca DALObj = new DALMarca(conexao);
            return DALObj.CarregaModeloMarca(codigo);
        }
    }
}
