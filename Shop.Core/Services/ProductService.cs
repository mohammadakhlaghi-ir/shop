using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public class ProductService : IProductService
    {
        private ShopContext _context;

        public ProductService(ShopContext context)
        {
            _context = context;
        }

        public List<ProductCategory> GetAllCategory()
        {
            return _context.ProductCategories.ToList();
        }

    }
}
