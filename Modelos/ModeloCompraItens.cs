using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloCompraItens
    {
        public int CompraItensId { get; set; }
        public int CompraId { get; set; }
        public int ProdutoId { get; set; }
        public decimal QtdNova { get; set; }
        public decimal QtdFracao { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PorcentagemCusto { get; set; }
        public decimal PrecoAvista { get; set; }
        public decimal PorcentagemAvista { get; set; }
        public decimal PrecoPrazo { get; set; }
        public int TotalItens { get; set; }
        public decimal TotalCusto { get; set; }
        public decimal TotalAvista { get; set; }
        public decimal TotalPrazo { get; set; }
      
    }
}
