using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public int FabricanteID { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
