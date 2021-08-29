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
    [PermissionChecker(17)]
    public class DeleteProductFileModel : PageModel
    {
        private IProductService _productService;

        public DeleteProductFileModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductFile ProductFile { get; set; }
        public void OnGet(int id)
        {
            ProductFile = _productService.GetProductFileById(id);
        }

        public IActionResult OnPost()
        {
            _productService.DeleteProductFile(ProductFile);

            return RedirectToPage("Index");
        }
    }
}
