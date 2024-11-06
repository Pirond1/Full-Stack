using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venda
    {
        public int id {  get; set; }
        public DateTime dataVenda { get; set; }
        public DateTime dataRetirada { get; set; }
        public int idPagamento { get; set; }
        public int idOrdem { get; set; }

        public Pagamento pagamento { get; set; }
        public Ordem ordem { get; set; }
    }
}
