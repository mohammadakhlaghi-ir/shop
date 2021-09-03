using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        
        private IOrderService _orderService;

      
        private IProductService _productService;

        public ProductController(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }

        public IActionResult Index(int pageId = 1, string filter = ""
            , string orderByType = "date",
             List<int> selectedCategories = null)
        {
            ViewBag.selectedCategories = selectedCategories;
            ViewBag.Categories = _productService.GetAllCategory();
            ViewBag.pageId = pageId;
            return View(_productService.GetProduct(pageId, filter,  orderByType, selectedCategories, 40));
        }
        [Route("Product/ShowProduct/{id}")]
        public IActionResult ShowProduct(int id)
        {
            var product = _productService.GetProductForShow(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [Authorize]
        public ActionResult BuyProduct(int id)
        {
            int orderId = _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }

    }

}
