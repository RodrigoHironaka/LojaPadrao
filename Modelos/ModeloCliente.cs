using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloCliente
    {
        public int ClienteId { get; set; }
        public string NomeFantasia { get; set; }
        public string CPFCNPJ { get; set; }
        public string RGIE { get; set; }
        public string RazaoSocial { get; set; } 
        public string TipoPessoa { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Celular2 { get; set; }
        public string Email { get; set; }
        public int CidadeId { get; set; }
        public string DataNasc { get; set; }
        public string Observacao { get; set; }
        public string DataCadastro { get; set; }
        public char Status { get; set; }
    }
}
