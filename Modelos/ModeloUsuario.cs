using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloUsuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public string Tipo { get; set; }
        public char Status { get; set; }
    }
}
