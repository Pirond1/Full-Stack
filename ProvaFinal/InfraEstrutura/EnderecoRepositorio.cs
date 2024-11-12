using Entidades;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IRepositorioEndereco
    {
        public EnderecoRepositorio(Contexto contexto) : base(contexto) 
        {
        }
    }
}
