using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tipo_Ordem
    {
        public Tipo_Ordem() {
            this.ordem = new HashSet<Ordem>();
        }

        public int id { get; set; }
        public String nomeTipo { get; set; } = String.Empty;
        public virtual ICollection<Ordem> ordem { get; set; }
    }
}
