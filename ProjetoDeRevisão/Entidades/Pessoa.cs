using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; } = string.Empty;
        public DateTime dataNascimento { get; set; }
        public string cpf { get; set; } = string.Empty;
        public string rg { get; set; } = string.Empty;
        public string endereco { get; set; } = string.Empty;

        public int CalcularIdade()
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento.Month > DateTime.Now.Month)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
