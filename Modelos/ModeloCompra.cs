using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloCompra
    {
        public int CompraId { get; set; }
        public string DataCadastro { get; set; }
        public int NumNota { get; set; }
        public DateTime DataNota { get; set; }
        public decimal PrecoNota { get; set; }
        public int FornecedorId { get; set; }
        public string Observacao { get; set; }
        public char Status { get; set; }
    }
}
