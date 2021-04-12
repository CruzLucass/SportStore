using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace SportStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context =
           app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Produtos.Any())
            {
                context.Produtos.AddRange(
                new Produto
                {
                    Nome = "Camiseta Oficial",
                    Descricao = "Todos os clubes",
                    Categoria = "Futebol",
                    Preco = 250,
                    FabricanteID = 1
                },
               new Produto
               {
                   Nome = "Short",
                   Descricao = "Treino fitness",
                   Categoria = "Academia",
                   Preco = 120,
                   FabricanteID = 3
               },
               new Produto
               {
                   Nome = "Tênis",
                   Descricao = "Corrida",
                   Categoria = "Maratona",
                   Preco = 540,
                   FabricanteID = 4
               },
               new Produto
               {
                   Nome = "Calça",
                   Descricao = "Corrida",
                   Categoria = "Fitness",
                   Preco = 565,
                   FabricanteID = 2
               },
               new Produto
               {
                   Nome = "Luvas",
                   Descricao = "Goleiro",
                   Categoria = "Futebol",
                   Preco = 340,
                   FabricanteID = 5
               },
               new Produto
               {
                   Nome = "Chuteira",
                   Descricao = "Society",
                   Categoria = "Futebol",
                   Preco = 545,
                   FabricanteID = 2
               },
               new Produto
               {
                   Nome = "Tornozeleira",
                   Descricao = "Corrida",
                   Categoria = "Diversos",
                   Preco = 140,
                   FabricanteID = 1
               },
               new Produto
               {
                   Nome = "Boné",
                   Descricao = "Proteção",
                   Categoria = "Praia",
                   Preco = 54,
                   FabricanteID = 2
               },
               new Produto
               {
                   Nome = "Raquete",
                   Descricao = "Tenis",
                   Categoria = "Esporte",
                   Preco = 1540,
                   FabricanteID = 7
               }
               );
                    context.Fabricantes.AddRange(
                    new Fabricante
                    {
                        Nome = "Adidas",
                        Email = "adidas@net.com",
                        Telefone = "(35)987056602"
                    },
                    new Fabricante
                    {
                        Nome = "Nike",
                        Email = "nike@nikenet.com",
                        Telefone = "(35)998670259",
                    },
                    new Fabricante
                    {
                        Nome = "Penalty",
                        Email = "penalty@penaltynet.com",
                        Telefone = "(35)998670259",
                    },
                    new Fabricante
                    {
                        Nome = "Topper",
                        Email = "topper@toppernet.com",
                        Telefone = "(35)998670259",
                    },
                    new Fabricante
                    {
                        Nome = "Puma",
                        Email = "puma@sport.com",
                        Telefone = "(35)998670295",
                    },
                    new Fabricante
                    {
                        Nome = "Mizuno",
                        Email = "mizuno@mizunonet.com",
                        Telefone = "(35)998670259",
                    },
                    new Fabricante
                    {
                        Nome = "Diadora",
                        Email = "diadora@diadoranet.com",
                        Telefone = "(35)998670259",
                    });
                context.SaveChanges();               
            }
        }
    }
}
