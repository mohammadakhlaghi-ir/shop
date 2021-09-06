using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.Product;

namespace Shop.Pages.Admin.ProductCategories
{
    [PermissionChecker(25)]
    public class DeleteCategoryModel : PageModel
    {
        private IProductService _productService;

        public DeleteCategoryModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductCategory ProductCategory { get; set; }
        public void OnGet(int id)
        {
            ProductCategory = _productService.GetCategoryById(id);
        }

        public IActionResult OnPost()
        {
            _productService.DeleteCategory(ProductCategory);

            return RedirectToPage("Index");
        }
    }
}
