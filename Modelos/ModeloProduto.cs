using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloProduto
    {
        public int ProdutoID { get; set; }
        public int NumSerie { get; set; }
        public string TipoProduto { get; set; }
        public string DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int UNID { get; set; }
        public int GrupoID { get; set; }
        public int SubGruooID { get; set; }
        public int FornecedorID { get; set; }
        public int MarcaID { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PorcentagemCusto { get; set; }
        public decimal PrecoAvista { get; set; }
        public decimal PorcentagemAvista { get; set; }
        public decimal PrecoPrazo { get; set; }
        public decimal PorcentagemDesconto { get; set; }
        public decimal PrecoDesconto { get; set; }
        public decimal EstoqueAtual { get; set; }
        public decimal EstoqueMax { get; set; }
        public decimal EstoqueMin { get; set; }
        public char ControlarEstoque { get; set; }
        public string Observacao { get; set; }
        public byte[] Foto { get; set; }
        public char Status { get; set; }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                FileInfo arqImagem = new FileInfo(imgCaminho);
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];
                int iByteRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
