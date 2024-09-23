using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pagamento
    {
        public Pagamento()
        {
            this.venda = new HashSet<Venda>();
            this.aluguel = new HashSet<Aluguel>();
        }

        public int id { get; set; }
        public String nomePagamento { get; set; } = String.Empty;
        public virtual ICollection<Venda> venda { get; set; }
        public virtual ICollection<Aluguel> aluguel { get; set; }
    }
}
