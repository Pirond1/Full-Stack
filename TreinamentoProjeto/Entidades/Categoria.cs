using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public Categoria() {
            this.produtos = new HashSet<Produtos>();
            
        }

        public int id { get; set; }
        public String descricao { get; set; } = String.Empty;

        public virtual ICollection<Produtos> produtos { get; set; }
    }
}
