using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public interface IFabricanteRepositorio
    {
        IQueryable<Fabricante> Fabricantes { get; }
        public void Create(Fabricante fabricante);
        public Fabricante ObterFabricante(int id);
        public void Edit(Fabricante fabricante);
        public void Delete(Fabricante fabricante);
    }
}
