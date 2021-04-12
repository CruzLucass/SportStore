using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public class EFFabricanteRepositorio : IFabricanteRepositorio
    {
        public ApplicationDbContext context;
        public EFFabricanteRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        //retorna a lista de fabricantes

        public IQueryable<Fabricante> Fabricantes => context.Fabricantes;

        //adiciona novo fabricante
        public void Create(Fabricante fabricante)
        {
            context.Add(fabricante);
            context.SaveChanges();
        }
        //utilizado para obter os detalhes dos fabricante
        public Fabricante ObterFabricante(int id)
        {
            var fabricante = context.Fabricantes
                .FirstOrDefault(p => p.FabricanteID == id);
            return fabricante;
        }
        //atualização dos cadastros
        public void Edit(Fabricante fabricante)
        {
            context.Entry(fabricante).State = EntityState.Modified;
            context.SaveChanges();
        }
        //excluir cadastros
        public void Delete(Fabricante fabricante)
        {
            context.Remove(fabricante);
            context.SaveChanges();
        }
    }
}
