using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produtos
    {
       
        public int id { get; set; }
        public String descricao { get; set; } = String.Empty;
        public Decimal? valor { get; set; }
        public DateTime? dataCadastro { get; set; }
        public bool ativo { get; set; }
        public int qtde { get; set; }
        public int idCategoria { get; set; }

        public Categoria categoria { get; set; }
    }
}
