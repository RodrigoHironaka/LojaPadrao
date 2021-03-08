using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloCompra
    {
        public Int64 CompraId { get; set; }
        public string DataCadastro { get; set; }
        public Int64 NumNota { get; set; }
        public DateTime DataNota { get; set; }
        public decimal PrecoNota { get; set; }
        public Int64 FornecedorId { get; set; }
        public string Observacao { get; set; }
        public int TotalItens { get; set; }
        public decimal TotalCusto { get; set; }
        public decimal TotalAvista { get; set; }
        public decimal TotalPrazo { get; set; }
        public char Status { get; set; }
    }
}
