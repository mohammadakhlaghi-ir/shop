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
    [PermissionChecker(15)]
    public class CreateProductFileModel : PageModel
    {
        private IProductService _productService;

        public CreateProductFileModel(IProductService productService)
        {
            _productService = productService;
        }



        [BindProperty]
        public ProductFile ProductFile { get; set; }
        public void OnGet(int id)
        {
            ProductFile = new ProductFile();
            ProductFile.ProductId = id;

        }


        public IActionResult OnPost(IFormFile fileProduct)
        {
            if (!ModelState.IsValid || fileProduct == null)
                return Page();

            if (_productService.CheckExistFile(fileProduct.FileName))
            {
                ViewData["IsExistFile"] = true;
                return Page();
            }


            _productService.AddProductFile(ProductFile, fileProduct);

            return Redirect("/Admin/Products/IndexProductFile/" + ProductFile.ProductId);
        }

    }
}
