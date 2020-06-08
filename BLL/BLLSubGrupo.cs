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
    public class BLLSubGrupo
    {
        private DALConexao conexao;
        public BLLSubGrupo(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubGrupo modelo)
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

            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloSubGrupo modelo)
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

            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloSubGrupo CarregaModeloSubGrupo(int codigo)
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.CarregaModeloSubGrupo(codigo);
        }

        public DataTable CarregaComboGrupo()
        {
            DALSubGrupo DALObj = new DALSubGrupo(conexao);
            return DALObj.CarregaComboGrupo();
        }
    }
}
