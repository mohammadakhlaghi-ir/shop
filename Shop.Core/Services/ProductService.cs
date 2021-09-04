using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public List<ProductFile> GetListProductFile(int productId)
        {
            return _context.ProductFiles.Where(p => p.ProductId == productId).ToList();
        }

        public bool CheckExistFile(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productFiles", fileName);
            return File.Exists(path);
        }

        public int AddProductFile(ProductFile file, IFormFile prodcutFile)
        {
            file.FileName = prodcutFile.FileName;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productFiles", file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                prodcutFile.CopyTo(stream);
            }

            _context.ProductFiles.Add(file);
            _context.SaveChanges();
            return file.FileId;
        }

        public ProductFile GetProductFileById(int prodcutFileId)
        {
            return _context.ProductFiles.Find(prodcutFileId);
        }

        public void EditProductFile(ProductFile file, IFormFile prodcutFile)
        {
            if (prodcutFile != null)
            {
                string deleteFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productFiles", file.FileName);
                File.Delete(deleteFilePath);

                file.FileName = prodcutFile.FileName;
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productFiles", file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    prodcutFile.CopyTo(stream);
                }
            }

            _context.ProductFiles.Update(file);
            _context.SaveChanges();

        }

        public void DeleteProductFile(ProductFile productFile)
        {
            _context.ProductFiles.Remove(_context.ProductFiles.Find(productFile.FileId));

            _context.SaveChanges();
        }

     

        public Tuple<List<ShowProductListItemViewModel>, int> GetProduct(int pageId = 1, string filter = "",
            string orderByType = "date", List<int> selectedCategories = null, int take = 0)
        {
            if (take == 0)
                take = 4;

            IQueryable<Product> result = _context.Products;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(p => p.ProductTitle.Contains(filter));
            }




            switch (orderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "maxPrice":
                    {
                        result = result.OrderByDescending(p => p.ProductPrice);
                        break;
                    }
                case "minPrice":
                    {
                        result = result.OrderBy(p => p.ProductPrice);
                        break;
                    }
                case "free":
                    {
                        result = result.Where(p => p.ProductPrice == 0);
                        break;
                    }

            }




            if (selectedCategories != null && selectedCategories.Any())
            {
                foreach (int categoryId in selectedCategories)
                {
                    result = result.Where(c => c.CategoryId == categoryId || c.SubCategory == categoryId);
                }

            }

            int skip = (pageId - 1) * take;
            int pageCount = result.Select(p => new ShowProductListItemViewModel()
            {
                ProductId = p.ProductId,
                ImageName = p.ProductImageName,
                OldPrice = p.ProductPriceOld,
                Price = p.ProductPrice,
                Title = p.ProductTitle,


            }).Count() / take;

            var query = result.Select(p => new ShowProductListItemViewModel()
            {
                ProductId = p.ProductId,
                ImageName = p.ProductImageName,
                OldPrice = p.ProductPriceOld,
                Price = p.ProductPrice,
                Title = p.ProductTitle,

            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pageCount);
        }

        public Product GetProductForShow(int productId)
        {
            return _context.Products.Include(p => p.ProductFile).Include(p=>p.UserProducts)
               .FirstOrDefault(p => p.ProductId == productId);

        }

        public void AddComment(ProductComment comment)
        {
            _context.ProductComments.Add(comment);
            _context.SaveChanges();
        }

        public Tuple<List<ProductComment>, int> GetProductComment(int productId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.ProductComments.Where(p => !p.IsDelete && p.ProductId == productId).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.ProductComments.Include(p => p.User).Where(p => !p.IsDelete && p.ProductId == productId).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);

        }
    }
}