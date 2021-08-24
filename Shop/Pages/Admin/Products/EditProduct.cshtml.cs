using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.Product;

namespace Shop.Pages.Admin.Products
{
    [PermissionChecker(12)]
    public class EditProductModel : PageModel
    {
        private IProductService _productService;

        public EditProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Product Product { get; set; }
        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);

            var categories = _productService.GetCategoryForManageProduct();
            ViewData["Categories"] = new SelectList(categories, "Value", "Text");

            var subCategories = _productService.GetSubCategoryForManageProduct(int.Parse(categories.First().Value));
            ViewData["SubCategories"] = new SelectList(subCategories, "Value", "Text");




        }

        public IActionResult OnPost(IFormFile imgProductUp)
        {
            if (!ModelState.IsValid)
                return Page();

            _productService.UpdateProduct(Product, imgProductUp);

            return RedirectToPage("Index");
        }

    }
}
