using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Marca
    {
        public Marca() {
            this.modelo = new HashSet<Modelo>();
        }

        public int id { get; set; }
        public String nomeMarca { get; set; } = String.Empty;
        public virtual ICollection<Modelo> modelo { get; set; }
    }
}
