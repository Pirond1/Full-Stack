using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Endereco
    {
        public int id { get; set; }
        public String rua { get; set; } = String.Empty;
        public String cidade { get; set; } = String.Empty;

        public int idCliente { get; set; }

        public Cliente cliente { get; set; }
    }
}
