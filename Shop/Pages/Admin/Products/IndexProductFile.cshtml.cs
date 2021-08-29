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
    [PermissionChecker(14)]
    public class IndexProductFileModel : PageModel
    {
        private IProductService _produceService;
        public IndexProductFileModel(IProductService productService)
        {
            _produceService = productService;
        }
        public List<ProductFile> ProductFiles { get; set; }
        public void OnGet(int id)
        {
            ViewData["ProductId"] = id;
            ProductFiles = _produceService.GetListProductFile(id);
        }
    }
}
