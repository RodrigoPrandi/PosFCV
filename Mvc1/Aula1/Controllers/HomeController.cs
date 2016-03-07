using Aula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var nomes = new[] { "Leandro", "Luzia", "mariana", "mario" };
            // return View(nomes);
            var listaCarros = new List<Veiculo>();
            listaCarros.Add(new Veiculo()
            {
                Ano = 2013,
                Marca = new Marca() { Nome = "VW", Pais = "Alemanha" },
                Modelo = "Fusca",
                Preco = 90123.23M
            });
            listaCarros.Add(new Veiculo()
            {
                Ano = 2013,
                Marca = new Marca() { Nome = "VW", Pais = "Alemanha" },
                Modelo = "Gol",
                Preco = 20123.23M
            });
            listaCarros.Add(new Veiculo()
            {
                Ano = 2018,
                Marca = new Marca() { Nome = "VW", Pais = "Alemanha" },
                Modelo = "Passat",
                Preco = 190123.23M
            });

            var db = new Contexto();
            db.Veiculos.AddRange(listaCarros);
            db.SaveChanges();

            return View(db.Veiculos.Include("Marca"));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}