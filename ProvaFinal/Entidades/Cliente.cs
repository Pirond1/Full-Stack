using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            this.endereco = new HashSet<Endereco>();
        }

        public int id { get; set; }
        public String nome { get; set; } = String.Empty;
        public String email { get; set; }

        public virtual ICollection<Endereco> endereco { get; set; }
    }
}
