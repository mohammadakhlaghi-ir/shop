using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int pageId = 1, string filter = ""
            , string orderByType = "date",
             List<int> selectedCategories = null)
        {
            ViewBag.selectedCategories = selectedCategories;
            ViewBag.Categories = _productService.GetAllCategory();
            ViewBag.pageId = pageId;
            return View(_productService.GetProduct(pageId, filter,  orderByType, selectedCategories, 8));
        }

    }
}
