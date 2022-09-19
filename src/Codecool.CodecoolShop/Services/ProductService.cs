using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Services
{
    public class ProductService
    {
        private readonly IProductDao productDao;
        private readonly IProductCategoryDao productCategoryDao;
        public readonly ICartDao cartDao;

        public ProductService(IProductDao productDao, IProductCategoryDao productCategoryDao, ICartDao cartDao)
        {
            this.productDao = productDao;
            this.productCategoryDao = productCategoryDao;
            this.cartDao = cartDao;
        }

        public  IEnumerable<Product> GetAllProducts()
        {
            return productDao.GetAll();
        }
        public ProductCategory GetProductCategory(int categoryId)
        {
            return productCategoryDao.Get(categoryId);
        }

        public IEnumerable<Product> GetProductsForCategory(int categoryId)
        {
            ProductCategory category = productCategoryDao.Get(categoryId);
            return this.productDao.GetBy(category);
        }
        
        public IEnumerable<Product> GetCart()
        {
            return this.cartDao.GetAll();
        }
        public Product GetProductById(int id)
        {
            var result = productDao.Get(id);
            if (result == null)
            {
                throw new ArgumentException("There is not any Product by this ID!");
            }
            return result;
        }
    }
}
