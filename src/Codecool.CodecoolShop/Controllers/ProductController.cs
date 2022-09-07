using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;


namespace Codecool.CodecoolShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService { get; set; }
        
        private List<Product> _cart = new List<Product>();


        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            ProductService = new ProductService(
                ProductDaoMemory.GetInstance(),
                ProductCategoryDaoMemory.GetInstance());
        }

        public IActionResult Index()
        {
            var products = ProductService.GetProductsForCategory(1).ToList();
            products.AddRange(ProductService.GetProductsForCategory(2).ToList());
            products.AddRange(ProductService.GetProductsForCategory(3).ToList());
            products.AddRange(ProductService.GetProductsForCategory(4).ToList());
            return View(products.Distinct().ToList());
        }

        public IActionResult Sweet()
        {
            var products = ProductService.GetProductsForCategory(1).ToList();
            return View("NIndex", products.ToList());
        }

        public IActionResult Sour()
        {
            var products = ProductService.GetProductsForCategory(2).ToList();
            return View("NIndex", products.ToList());
        }

        public IActionResult Salty()
        {
            var products = ProductService.GetProductsForCategory(3).ToList();
            return View("NIndex", products.ToList());
        }

        public IActionResult Spicy()
        {
            var products = ProductService.GetProductsForCategory(4).ToList();
            return View("NIndex", products.ToList());
        }

        public IActionResult Chio()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(1));
            return View("NIndex", products.ToList());
        }

        public IActionResult CrikCrok()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(2));
            return View("NIndex", products.ToList());
        }

        public IActionResult EatReal()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(3));
            return View("NIndex", products.ToList());
        }

        public IActionResult Lays()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(4));
            return View("NIndex", products.ToList());
        }

        public IActionResult fini()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(5));
            return View("NIndex", products.ToList());
        }

        public IActionResult Manner()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(6));
            return View("NIndex", products.ToList());
        }

        public IActionResult Milka()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(7));
            return View("NIndex", products.ToList());
        }

        public IActionResult Mizo()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(8));
            return View("NIndex", products.ToList());
        }

        public IActionResult Pocky()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(9));
            return View("NIndex", products.ToList());
        }

        public IActionResult Snickers()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(10));
            return View("NIndex", products.ToList());
        }

        public IActionResult SourPatch()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(11));
            return View("NIndex", products.ToList());
        }

        public IActionResult Toffifee()
        {
            var pdm = ProductDaoMemory.GetInstance();
            var sdm = SupplierDaoMemory.GetInstance();
            var products = pdm.GetBy(sdm.Get(12));
            return View("NIndex", products.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("AddCart/{id}")] 
        public IActionResult AddCart(int id)
        {
            var sdm = ProductDaoMemory.GetInstance();
            var product = sdm.Get(id);
            _cart.Add(product);
            
            return RedirectToAction("Index");
        }

        
        public IActionResult Checkout()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
