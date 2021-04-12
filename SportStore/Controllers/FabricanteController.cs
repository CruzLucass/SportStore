using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStore.Models;
using SportStore.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportStore.Controllers
{
    public class FabricanteController : Controller
    {
        private ApplicationDbContext context;
        private IFabricanteRepositorio repositorio;

        public int PageSize = 4;

        public FabricanteController(IFabricanteRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }
        
        public ViewResult List(int paginaFabricante = 1) => View(new FabricanteListViewModel
        {
            Fabricantes = repositorio.Fabricantes
                .OrderBy(p => p.FabricanteID)
                .Skip((paginaFabricante - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                PaginaAtual = paginaFabricante,
                ItensPorPagina = PageSize,
                TotalItens = repositorio.Fabricantes.Count()
            }
        });
        [HttpGet]//serve para gerar a view
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]//serve para quando for modificar um registro
        public IActionResult New(Fabricante fabricante)
        {
            repositorio.Create(fabricante);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            var fabricante = repositorio.ObterFabricante(id);
            return View(fabricante);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var fabricante = context.Fabricantes.Find(id);
            return View(fabricante);
        }

        [HttpPost]
        public IActionResult Edit(Fabricante fabricante)
        {
            repositorio.Edit(fabricante);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var fabricante = repositorio.ObterFabricante(id);
            return View(fabricante);
        }

        [HttpPost]
        public IActionResult Delete(Fabricante fabricante)
        {
            repositorio.Delete(fabricante);
            return RedirectToAction("List");
        }
    }
       
}
