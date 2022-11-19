using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyDotnetApp.Web.Models;

namespace MyDotnetApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();

            if (!_productRepository.GetAll().Any())
            {
                _productRepository.Add(new() { Id = 1, Name = "Kalem", Price = 100, Stock = 100 });
                _productRepository.Add(new() { Id = 2, Name = "Silgi", Price = 200, Stock = 200 });
                _productRepository.Add(new() { Id = 3, Name = "Defter", Price = 300, Stock = 300 });
                _productRepository.Add(new() { Id = 4, Name = "Çanta", Price = 400, Stock = 400 });
            }
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAll();

            return View(products);
        }
    }
}