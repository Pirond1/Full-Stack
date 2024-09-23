﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ordem
    {
        public Ordem()
        {
            this.venda = new HashSet<Venda>();
            this.aluguel = new HashSet<Aluguel>();
        }

        public int id { get; set; }
        public DateTime dataOrdem {  get; set; }
        public int idAutomovel { get; set; }
        public int idTipo_Ordem { get; set; }
        public int idFuncionario { get; set; }
        public int idCliente { get; set; }

        public Automovel automovel { get; set; }
        public Tipo_Ordem tipo_ordem { get; set; }
        public Funcionario funcionario { get; set; }
        public Cliente cliente { get; set; }
        public virtual ICollection<Venda> venda { get; set; }
        public virtual ICollection<Aluguel> aluguel { get; set; }
    }
}