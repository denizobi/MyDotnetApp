using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyDotnetApp.Web.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class IlkController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.name = "Ilk Controller Index with ViewBag";
            ViewData["age"] = 35;
            TempData["author"] = "Dante";
            ViewData["names"] = new List<string>() { "bayram", "fatih", "hasan" };
            
            return View();
        }

        // ilk controller index yönlendir
        public IActionResult Second()
        {
            return RedirectToAction("Index", "Ilk");
        }

        // 3rd controller for tempdata
        public IActionResult Third()
        {
            return View();
        }

        // 4th controller for viewdata
        public IActionResult Forth()
        {
            List<Product> Products = new List<Product>()
            {
                new() { Id = 1, Name = "Kalem" },
                new() { Id = 2, Name = "Silgi" },
                new() { Id = 3, Name = "Defter" }
            };
            return View(Products);
        }

        //default int parametre al yönlendir
        public IActionResult Parametre(int id)
        {
            return RedirectToAction("JSONResultParam", "Ilk", new { id = id });
        }

        public IActionResult ContentResult()
        {
            return Content("Content Result");
        }

        public IActionResult JSONResult()
        {
            return Json(new { id = 0, name = "Bayram", surname = "Tokluiçten", codename = "denizobi" });
        }

        public IActionResult JSONResultParam(int id)
        {
            return Json(new { id = id });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}

