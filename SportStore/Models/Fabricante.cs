using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Fabricante
    {
        public int FabricanteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone{ get; set; }
        public virtual ICollection<Produto> Produtos { get; set; } //para que a EF consiga executar a instrução join e fazer a relação um para muitos
    }
}
