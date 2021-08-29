using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.Product;

namespace Shop.Pages.Admin.Products
{
    [PermissionChecker(16)]
    public class EditProductFileModel : PageModel
    {
        private IProductService _productService;

        public EditProductFileModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductFile ProductFile { get; set; }
        public void OnGet(int id)
        {
            ProductFile = _productService.GetProductFileById(id);
        }

        public IActionResult OnPost(IFormFile fileProduct)
        {
            if (!ModelState.IsValid)
                return Page();

            if (fileProduct != null)
            {
                if (_productService.CheckExistFile(fileProduct.FileName))
                {
                    ViewData["IsExistFile"] = true;
                    return Page();
                }
            }


            _productService.EditProductFile(ProductFile, fileProduct);

            return Redirect("/Admin/Products/IndexProductFile/" + ProductFile.ProductId);
        }
    }
}
