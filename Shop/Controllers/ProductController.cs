using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        
        private IOrderService _orderService;
        private IUserService _userService;
      
        private IProductService _productService;

        public ProductController(IProductService productService, IOrderService orderService,IUserService userService)
        {
            _productService = productService;
            _orderService = orderService;
            _userService = userService;
        }

        public IActionResult Index(int pageId = 1, string filter = ""
            , string orderByType = "date",
             List<int> selectedCategories = null)
        {
            ViewBag.selectedCategories = selectedCategories;
            ViewBag.Categories = _productService.GetAllCategory();
            ViewBag.pageId = pageId;
            return View(_productService.GetProduct(pageId, filter,  orderByType, selectedCategories, 30));
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

        [Route("DownloadFile/{productFileId}")]
        public IActionResult DownloadFile(int productFileId)
        {
            var productFile = _productService.GetProductFileById(productFileId);
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productFiles",
                productFile.FileName);
            string fileName = productFile.FileName;
            if (productFile.IsFree)
            {
                byte[] file = System.IO.File.ReadAllBytes(filepath);
                return File(file, "application/force-download", fileName);
            }

            if (User.Identity.IsAuthenticated)
            {
                if (_orderService.IsUserInProduct(User.Identity.Name, productFile.ProductId))
                {
                    byte[] file = System.IO.File.ReadAllBytes(filepath);
                    return File(file, "application/force-download", fileName);
                }
            }

            return Forbid();
        }
        [HttpPost]
        public IActionResult CreateComment(ProductComment newComment)
        {
            newComment.IsDelete = false;
            newComment.CreateDate = DateTime.Now;
            newComment.UserId = _userService.GetUserIdByUserName(User.Identity.Name);
            _productService.AddComment(newComment);

            return View("ShowComment", _productService.GetProductComment(newComment.ProductId));
        }

        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_productService.GetProductComment(id, pageId));
        }

    }

}
