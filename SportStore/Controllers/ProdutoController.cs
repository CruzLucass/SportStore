using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStore.Models;
using SportStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Controllers
{
    public class ProdutoController : Controller
    {
        private ApplicationDbContext context;
        private IProdutoRepositorio repositorio;
        public int PageSize = 4;
        public ProdutoController(IProdutoRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }
        public ViewResult List(int paginaProduto = 1) => View(new ProdutoListViewModel
        {
            Produtos = repositorio.Produtos
                .OrderBy(p => p.ProdutoID)
                .Skip((paginaProduto - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                PaginaAtual = paginaProduto,
                ItensPorPagina = PageSize,
                TotalItens = repositorio.Produtos.Count()
            }
        });

        [HttpGet]//serve para gerar a view
        public IActionResult New()
        {
            ViewBag.FabricanteId = new SelectList(context.Fabricantes.OrderBy(f
            => f.Nome), "FabricanteID", "Nome");
            return View();
        }

        [HttpPost]//serve para quando for modificar um registro
        public IActionResult New(Produto produto)
        {
            repositorio.Create(produto);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            var produto = repositorio.ObterProduto(id);
            return View(produto);
        }

        [HttpGet] 
        public IActionResult Edit(int id) 
        { 
            var produto = context.Produtos.Find(id);
            ViewBag.FabricanteId = new SelectList(context.Fabricantes
                .OrderBy(f => f.Nome), "FabricanteID", "Nome");
            return View(produto);
        }

        [HttpPost] 
        public IActionResult Edit(Produto produto) 
        { 
            repositorio.Edit(produto);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var produto = repositorio.ObterProduto(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Delete(Produto produto)
        {
            repositorio.Delete(produto);
            return RedirectToAction("List");
        }
    }    
}
