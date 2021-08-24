using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.Product;

namespace Shop.Pages.Admin.Products
{
    [PermissionChecker(13)]
    public class DeleteProductModel : PageModel
    {
        private IProductService _productService;

        public DeleteProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Product Product { get; set; }
        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);
        }

        public IActionResult OnPost()
        {
            _productService.DeleteProduct(Product);

            return RedirectToPage("Index");
        }
    }
}
