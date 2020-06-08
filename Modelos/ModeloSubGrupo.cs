using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloSubGrupo
    {
        public int SubGrupoId { get; set; }
        public string Nome { get; set; }
        public int GrupoId { get; set; }
        public char Status { get; set; }
    }
}
