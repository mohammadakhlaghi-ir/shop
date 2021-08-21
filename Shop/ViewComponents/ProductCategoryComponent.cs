using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class ProductCategoryComponent : ViewComponent
    {
        private IProductService _productService;

        public ProductCategoryComponent(IProductService productService)
        {
            _productService = productService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ProductCategory", _productService.GetAllCategory()));
        }

    }
}
