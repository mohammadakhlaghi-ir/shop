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
    [PermissionChecker(23)]
    public class CreateCategoryModel : PageModel
    {
        private IProductService _productService;

        public CreateCategoryModel(IProductService prodcutService)
        {
            _productService = prodcutService;
        }

        [BindProperty]
        public ProductCategory ProductCategories { get; set; }

        public void OnGet(int? id)
        {
            ProductCategories = new ProductCategory()
            {
                ParentId = id
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _productService.AddCategory(ProductCategories);

            return RedirectToPage("Index");
        }

    }
}
