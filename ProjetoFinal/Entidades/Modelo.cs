using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modelo
    {
        public Modelo() {
            this.automovel = new HashSet<Automovel>();
        }

        public int id { get; set; }
        public String nomeModelo { get; set; } = String.Empty;
        public int idMarca { get; set; }

        public Marca marca { get; set; }
        public virtual ICollection<Automovel> automovel { get; set; }
    }
}
