using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.Convertors;
using Shop.Core.DTOs;
using Shop.Core.Generator;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/product/thumb", product.ProductImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }



            _context.Add(product);
            _context.SaveChanges();

            return product.ProductId;
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

        public ShowProductForAdminViewModel GetProductsForAdmin(int pageId = 1, string filterProductName = "")
        {
            IQueryable<Product> result = _context.Products;



            if (!string.IsNullOrEmpty(filterProductName))
            {
                result = result.Where(p => p.ProductTitle.Contains(filterProductName));
            }

            // Show Item In Page
            int take = 5;
            int skip = (pageId - 1) * take;


            ShowProductForAdminViewModel list = new ShowProductForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Products = result.OrderBy(p => p.CreateDate).Skip(skip).Take(take).ToList();

            return list;
            

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

        public void UpdateProduct(Product product, IFormFile imgProdcut)
        {


            if (imgProdcut != null && imgProdcut.IsImage())
            {
                if (product.ProductImageName != "no-photo.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/product/image", product.ProductImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/product/thumb", product.ProductImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                product.ProductImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgProdcut.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/product/image", product.ProductImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgProdcut.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/product/thumb", product.ProductImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }



            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(_context.Products.Find(product.ProductId));

            _context.SaveChanges();
        }

    }
}
