using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovel
    {
        public Automovel() { 
            this.ordem = new HashSet<Ordem>();
        }

        public int id { get; set; }
        public String cor { get; set; } = String.Empty;
        public int ano { get; set; }
        public int numeroPortas { get; set; }
        public int quilometragem { get; set; }
        public String numeroChassi { get; set; } = String.Empty;
        public int idModelo { get; set; }

        public Modelo modelo { get; set; }
        public virtual ICollection<Ordem> ordem { get; set; }
    }
}
