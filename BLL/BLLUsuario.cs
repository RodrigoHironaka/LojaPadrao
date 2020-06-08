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
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();
            if (modelo.Nome.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 50!");
            }
            //-------------------------------------------------------------------------
            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A Senha é obrigatória");
            }
            modelo.Senha = modelo.Senha.ToUpper();

            if (modelo.Senha.Trim().Length > 15)
            {
                throw new Exception("O limite máximo de caracteres na Senha é 15!");
            }
            //-------------------------------------------------------------------------
            if (modelo.ConfirmaSenha.Trim().Length == 0)
            {
                throw new Exception("A Confirmação da Senha é obrigatória");
            }
            modelo.ConfirmaSenha = modelo.ConfirmaSenha.ToUpper();

            if (modelo.ConfirmaSenha.Trim().Length > 15)
            {
                throw new Exception("O limite máximo de caracteres na Confirmação da Senha é 15!");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.UsuarioId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            //------------------------------------------------------------------------
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.Nome = modelo.Nome.ToUpper();
            if (modelo.Nome.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 50!");
            }
            //-------------------------------------------------------------------------
            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A Senha é obrigatória");
            }
            modelo.Senha = modelo.Senha.ToUpper();

            if (modelo.Senha.Trim().Length > 15)
            {
                throw new Exception("O limite máximo de caracteres na Senha é 15!");
            }
            //-------------------------------------------------------------------------
            if (modelo.ConfirmaSenha.Trim().Length == 0)
            {
                throw new Exception("A Confirmação da Senha é obrigatória");
            }
            modelo.ConfirmaSenha = modelo.ConfirmaSenha.ToUpper();

            if (modelo.ConfirmaSenha.Trim().Length > 15)
            {
                throw new Exception("O limite máximo de caracteres na Confirmação da Senha é 15!");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        public DataTable CarregaGrid()
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.CarregarGridInativo();
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.CarregaModeloUsuario(codigo);
        }

        //public void VerificaSenhaAdm(string nome, string senha)
        //{
        //    DALUsuario DALObj = new DALUsuario(conexao);
        //    DALObj.VerificaSenhaAdm(nome, senha);
        //}
    }
}
