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
using Microsoft.AspNetCore.Mvc.Razor.Compilation;



namespace Codecool.CodecoolShop.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService { get; set; }
        
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            ProductService = new ProductService(
                ProductDaoMemory.GetInstance(),
                ProductCategoryDaoMemory.GetInstance(),
                CartDaoMemory.GetInstance()
            );
        }
        //-------------------------------------------------
        [Route("add/{id}")]
        public ActionResult Add(int id)
        {
            
            var products = ProductService.GetAllProducts();
            Product product = products.Where(t => t.Id == id).First();
            List<Product> InCart = (List<Product>)ProductService.GetCart();
            ProductService.cartDao.Add(product);

            return RedirectToAction("Index", "Product");
        }
        
        public ActionResult AddOneMore(int id)
        {
            
            var products = ProductService.GetAllProducts();
            Product product = products.Where(t => t.Id == id).First();
            List<Product> InCart = (List<Product>)ProductService.GetCart();
            ProductService.cartDao.Add(product);

            return RedirectToAction("ViewCart", "Product");
        }


        [Route("remove/{id}")]
        public ActionResult Remove(int Id)
        {
            ProductService.cartDao.Remove(Id);

            return RedirectToAction("ViewCart", "Product");
        }

        [Route("Cart")]
        public ActionResult ViewCart()
        {
            List<Product> InCart = (List<Product>)ProductService.GetCart();
            return View("Cart", InCart);
        }
        
        [Route("Checkout")]
        public ActionResult ViewCartCheckout()
        {
            List<Product> InCart = (List<Product>)ProductService.GetCart();
            return View("Checkout", InCart);
        }
//---------------------------------------------------------------------
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

        public IActionResult Thanks()
        {
            return View();
        }
        public IActionResult Privacy()
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
