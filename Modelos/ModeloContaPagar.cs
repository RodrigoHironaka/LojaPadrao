using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloContaPagar
    {
        public Int64 ContaPagarID { get; set; }
        public string DataCadastro { get; set; }
        public int TipoGastoID { get; set; }
        public char Unica { get; set; }
        public int QtdParcelas { get; set; }
        public decimal Valor { get; set; }
        public int FormaPagamentoID { get; set; }
        public string Descricao { get; set; }
        public DateTime Emissão { get; set; }
        public DateTime Vencimento { get; set; }
        public Int64 NumDoc { get; set; }
        public string TipoPessoa { get; set; }
        public int PessoaID { get; set; }
        public string Observacao { get; set; }
        public char Status { get; set; }
        
    }
}
