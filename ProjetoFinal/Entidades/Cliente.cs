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
            this.ordem = new HashSet<Ordem>();
        }

        public int id { get; set; }
        public String nome { get; set; } = String.Empty;
        public virtual ICollection<Ordem> ordem { get; set; }
    }
}
