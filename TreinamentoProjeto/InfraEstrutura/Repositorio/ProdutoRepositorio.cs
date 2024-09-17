using Entidades;
using InfraEstrutura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produtos>
    {
        public ProdutoRepositorio(Contexto_Empresa contexto) : base(contexto)
        {
        }
    }
}
