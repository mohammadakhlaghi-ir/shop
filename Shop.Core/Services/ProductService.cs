using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.DTOs.Product;
using Shop.Core.Generator;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities.Product;
using System;
using System.Collections.Generic;
using System.IO;
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

        public int AddProduct(Product product, IFormFile imgProduct)
        {
            product.CreateDate = DateTime.Now;
            product.ProductImageName = "no-photo.jpg";
            //TODO Check Image
            if (imgProduct != null)
            {
                product.ProductImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgProduct.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/product/image", product.ProductImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgProduct.CopyTo(stream);
                }
            }

            

            _context.Add(product);
            _context.SaveChanges();

            return product.ProductId;
        }

        public void DeleteProduct(int productId)
        {
            Product product = GetProductById(productId);
            product.IsDelete = true;
            _context.Update(product);
            _context.SaveChanges();
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

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public List<ShowProductForAdminViewModel> GetProductsForAdmin()
        {
            return _context.Products.Select(p => new ShowProductForAdminViewModel()
            {
                ProductId = p.ProductId,
                ImageName = p.ProductImageName,
                Title = p.ProductTitle
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
