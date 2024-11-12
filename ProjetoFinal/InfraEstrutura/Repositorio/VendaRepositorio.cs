﻿using Entidades;
using InfraEstrutura.Contexto;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class VendaRepositorio : BaseRepositorio<Venda>, IRepositorioVenda
    {
        public VendaRepositorio(Contexto_Empresa contexto) : base(contexto) 
        {
        }
    }
}