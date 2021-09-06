using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities;
using Shop.DataLayer.Entities.Product;
using Shop.DataLayer.Entities.User;

namespace Shop.Pages.Admin
{
    [PermissionChecker(1)]
   
    public class IndexModel : PageModel
    {
        private IUserService _userService;
        private IProductService _productService;
        private IOrderService _orderService;
        
        public IndexModel(IUserService userService,IProductService productService,IOrderService orderService)
        {
            _userService = userService;
            _productService = productService;
            _orderService = orderService;
        }
        public List<Discount> Discounts { get; set; }
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Order> Orders { get; set; }
        public List<ProductComment> Comments{ get;set;}
        public void OnGet()
        {
            Discounts = _orderService.GetAllDiscounts();
            Products = _productService.GetAllProducts();
            Users = _userService.GetAllUsers();
            ProductCategories = _productService.GetAllCategory();
            Orders = _orderService.GetAllOrders();
            Comments = _productService.GetAllComments();
        }
    }
}
