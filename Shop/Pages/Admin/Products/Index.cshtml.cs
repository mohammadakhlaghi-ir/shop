using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.DTOs.Product;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;

namespace Shop.Pages.Admin.Products
{
    [PermissionChecker(10)]
    public class IndexModel : PageModel
    {
        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<ShowProductForAdminViewModel> ListProduct { get; set; }

        public void OnGet()
        {
            ListProduct = _productService.GetProductsForAdmin();
        }

    }
}
