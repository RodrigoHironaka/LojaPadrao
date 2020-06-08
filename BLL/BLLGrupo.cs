using DAL;
using Modelos;
using System;
using System.Data;

namespace BLL
{
    public class BLLGrupo
    {
        private DALConexao conexao;
        public BLLGrupo(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloGrupo modelo)
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

            DALGrupo DALObj = new DALGrupo(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloGrupo modelo)
        {
            if (modelo.GrupoId <= 0)
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

            DALGrupo DALObj = new DALGrupo(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloGrupo CarregaModeloGrupo(int codigo)
        {
            DALGrupo DALObj = new DALGrupo(conexao);
            return DALObj.CarregaModeloGrupo(codigo);
        }
    }
}
