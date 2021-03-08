using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloCompraPagamento
    {
        public int CompraPagamentoId { get; set; }
        public int CompraId { get; set; }
        public int FormaPagamentoId { get; set; }
        public int NParcela { get; set; }
        public DateTime DataInicioPagamento { get; set; }
        public decimal PrecoParcela { get; set; }
    }
}
