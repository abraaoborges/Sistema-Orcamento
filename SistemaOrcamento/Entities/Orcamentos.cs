using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Entities
{
    public class Orcamentos
    {
        public int IdOrcamento { get; set; }
        public string NumOrcamento { get; set; }
        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
