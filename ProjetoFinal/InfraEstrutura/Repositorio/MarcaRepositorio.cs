using Entidades;
using InfraEstrutura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class MarcaRepositorio: BaseRepositorio<Marca>
    {
        public MarcaRepositorio(Contexto_Empresa contexto) : base(contexto) 
        { 
        }
    }
}
