using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloFormaPagamento
    {
        public int FormaPagamentoId { get; set; }
        public string Nome { get; set; }
        public int QtdParcelas { get; set; }
        public int DiasVencimento { get; set; }
        public char Status { get; set; }
    }
}
