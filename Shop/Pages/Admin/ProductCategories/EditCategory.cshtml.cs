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
    [PermissionChecker(24)]
    public class EditCategoryModel : PageModel
    {
        private IProductService _productService;

        public EditCategoryModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductCategory ProductCategories { get; set; }

        public void OnGet(int id)
        {
            ProductCategories = _productService.GetCategoryById(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _productService.UpdateCategory(ProductCategories);

            return RedirectToPage("Index");
        }

    }
}
