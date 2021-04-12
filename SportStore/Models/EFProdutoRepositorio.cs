using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public class EFProdutoRepositorio : IProdutoRepositorio
    {
        public ApplicationDbContext context;
        public EFProdutoRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        //retorna a lista de produtos
        public IQueryable<Produto> Produtos => context.Produtos
            .Include(f => f.Fabricante);
        //adiciona novo produto
        public void Create(Produto produto)
        { 
            context.Add(produto);
            context.SaveChanges();
        }
        //utilizado para obter os detalhes dos produtos
        public Produto ObterProduto(int id)
        { 
            var produto = context.Produtos
                .Include(f => f.Fabricante)
                .FirstOrDefault(p => p.ProdutoID == id);
            return produto; 
        }
        //atualização dos cadastros
        public void Edit(Produto produto) 
        { 
            context.Entry(produto).State = EntityState.Modified;
            context.SaveChanges(); 
        }
        //excluir cadastros
        public void Delete(Produto produto)
        { 
            context.Remove(produto);
            context.SaveChanges();
        }
    }
}
