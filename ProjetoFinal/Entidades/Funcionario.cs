using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcionario
    {
        public Funcionario()
        {
            this.ordem = new HashSet<Ordem>();
        }

        public int id { get; set; }
        public String nome { get; set; }
        public String login { get; set; }
        public String senha { get; set; }
        public DateTime dataNascimento { get; set; }
        public Decimal salario {  get; set; }
        public virtual ICollection<Ordem> ordem { get; set; }
    }
}
