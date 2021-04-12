using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public interface IProdutoRepositorio
    {
        IQueryable<Produto> Produtos { get; }
        public void Create(Produto produto); 
        public Produto ObterProduto(int id); 
        public void Edit(Produto produto); 
        public void Delete(Produto produto);
    }
}
