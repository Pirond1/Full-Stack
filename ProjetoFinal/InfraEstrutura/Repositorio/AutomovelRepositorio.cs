using Entidades;
using InfraEstrutura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace InfraEstrutura.Repositorio
{
    public class AutomovelRepositorio : BaseRepositorio<Automovel>, IRepositorioAutomovel
    {
        public AutomovelRepositorio(Contexto_Empresa contexto) : base(contexto) 
        { 
        }
    }
}
