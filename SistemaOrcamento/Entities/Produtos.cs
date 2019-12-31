using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Entities
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdFornecedor { get; set; }
        public int IdUnidade { get; set; }
        public decimal Valor { get; set; }


    }
}
