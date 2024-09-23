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
        public DateTime dataNascimento { get; set; }
        public float salario {  get; set; }
        public virtual ICollection<Ordem> ordem { get; set; }
    }
}
