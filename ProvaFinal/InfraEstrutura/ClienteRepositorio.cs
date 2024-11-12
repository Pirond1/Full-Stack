using Entidades;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IRepositorioCliente
    {
        public ClienteRepositorio(Contexto contexto) : base(contexto) 
        {
        }
    }
}
