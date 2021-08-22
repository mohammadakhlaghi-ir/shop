using Microsoft.AspNetCore.Mvc.Rendering;
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

        public List<SelectListItem> GetCategoryForManageProduct()
        {
            return _context.ProductCategories.Where(c => c.ParentId == null)
               .Select(c => new SelectListItem()
               {
                   Text = c.CategoryTitle,
                   Value = c.CategoryId.ToString()
               }).ToList();

        }

        public List<SelectListItem> GetSubCategoryForManageProduct(int groupId)
        {
            return _context.ProductCategories.Where(c => c.ParentId == groupId)
               .Select(c => new SelectListItem()
               {
                   Text = c.CategoryTitle,
                   Value = c.CategoryId.ToString()
               }).ToList();

        }
    }
}
