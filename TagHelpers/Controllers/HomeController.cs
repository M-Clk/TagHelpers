using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelpers.Models;

namespace TagHelpers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public HomeController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        // GET: Home
        public IActionResult Index()
        {
            return View(productRepository.Products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product entity)
        {
            productRepository.AddProduct(entity);
            return RedirectToAction("Index");
        }
        
    }
}