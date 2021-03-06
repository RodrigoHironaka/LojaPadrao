﻿using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.NomeFantasia.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.NomeFantasia = modelo.NomeFantasia.ToUpper();

            if (modelo.NomeFantasia.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.CPFCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CPF e/ou CPNJ não pode ficar em branco");
            }
            //--------------------------------------------------------------------------

            if (modelo.CEP.Trim().Length == 0)
            {
                throw new Exception("O CEP não pode ficar em branco");
            }
            //--------------------------------------------------------------------------

            if (modelo.RazaoSocial.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres na Razão Social é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Endereco.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Endereço é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Numero.Trim().Length > 10)
            {
                throw new Exception("O limite máximo de caracteres no Numero é 10!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Complemento.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Complemento é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Bairro.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Bairro é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Email.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Email é 50!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Observacao.Trim().Length > 300)
            {
                throw new Exception("O limite máximo de caracteres na Observação é 300!");
            }

            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CidadeId <= 0)
            {
                throw new Exception("Digite o codigo");
            }
            //---------------------------------------------------------------------------

            if (modelo.NomeFantasia.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório");
            }
            modelo.NomeFantasia = modelo.NomeFantasia.ToUpper();

            if (modelo.NomeFantasia.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Nome é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.RazaoSocial.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres na Razão Social é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Endereco.Trim().Length > 100)
            {
                throw new Exception("O limite máximo de caracteres no Endereço é 100!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Numero.Trim().Length > 10)
            {
                throw new Exception("O limite máximo de caracteres no Numero é 10!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Complemento.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Complemento é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Bairro.Trim().Length > 20)
            {
                throw new Exception("O limite máximo de caracteres no Bairro é 20!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Email.Trim().Length > 50)
            {
                throw new Exception("O limite máximo de caracteres no Email é 50!");
            }
            //--------------------------------------------------------------------------

            if (modelo.Observacao.Trim().Length > 300)
            {
                throw new Exception("O limite máximo de caracteres na Observação é 300!");
            }
            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarAtivo(valor);
        }

        public DataTable LocalizarInativo(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarInativo(valor);
        }

        //---------------------------------------------------------
        public DataTable LocalizarAtivoFisica(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarAtivoFisica(valor);
        }

        public DataTable LocalizarInativoFisica(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarInativoFisica(valor);
        }

        public DataTable LocalizarAtivoJuridica(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarAtivoJuridica(valor);
        }

        public DataTable LocalizarInativoJuridica(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarInativoJuridica(valor);
        }

        public DataTable LocalizarFisica(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarFisica(valor);
        }

        public DataTable LocalizarJuridica(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarJuridica(valor);
        }
        //---------------------------------------------------------

        public ModeloCidade LocalizarPorNomeCidade(String nome)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarPorNomeCidade(nome);
        }

        public DataTable CarregaGrid()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGrid();
        }

        public DataTable CarregaGridAtivo()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridAtivo();
        }

        public DataTable CarregaGridInativo()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridInativo();
        }

        //--------------------------------------------------------
        public DataTable CarregaGridAtivoFisica()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridAtivoFisica();
        }

        public DataTable CarregaGridInativoFisica()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridInativoFisica();
        }

        public DataTable CarregaGridAtivoJuridica()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridAtivoJuridica();
        }

        public DataTable CarregaGridInativoJuridica()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridInativoJuridica();
        }

        public DataTable CarregaGridFisica()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridFisica();
        }

        public DataTable CarregaGridJuridica()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregarGridJuridica();
        }

        //--------------------------------------------------------
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaModeloCliente(codigo);
        }

        //public DataTable CarregaComboCidade()
        //{
        //    DALCliente DALObj = new DALCliente(conexao);
        //    return DALObj.CarregaComboCidade();
        //}

        public Int64 VerificaUltimoIdInserido()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.VerificaUltimoIdInserido();
        }

        public DataTable LocalizarUltimoItemInserido()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarUltimoItemInserido();
        }

        public DataTable LocalizarUltimoItemAlterar(Int64 idAlterado)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarUltimoItemAlterar(idAlterado);
        }
    }
}
