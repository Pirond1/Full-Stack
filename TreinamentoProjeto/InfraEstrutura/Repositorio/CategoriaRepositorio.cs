using Entidades;
using InfraEstrutura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class CategoriaRepositorio : BaseRepositorio<Categoria>
    {
        public CategoriaRepositorio(Contexto_Empresa contexto) : base(contexto)
        {
        }
    }
}
