using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaLocadora.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Pessoa()
        {
            ViewBag.Title = "Pessoas";
            return View();
        }

        public ActionResult Carro()
        {
            ViewBag.Title = "Carros";
            return View();
        }
    }
}
