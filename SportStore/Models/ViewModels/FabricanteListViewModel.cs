using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStore.Models;

namespace SportStore.Models.ViewModels
{
    public class FabricanteListViewModel
    {
        public IEnumerable<Fabricante> Fabricantes{ get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
