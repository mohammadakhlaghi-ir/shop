using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class MyOrdersController : Controller
    {
        private IOrderService _orderService;
        private ShopContext _context;

        public MyOrdersController(IOrderService orderService,ShopContext context)
        {
            _orderService = orderService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowOrder(int id, bool finaly = false)
        {
            var order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);

            if (order == null)
            {
                return Redirect("/404");
            }

            ViewBag.finaly = finaly;
            return View(order);
        }
        
        public IActionResult FinalyOrder(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {
                return Redirect("/UserPanel/MyOrders/ShowOrder/" + id + "?finaly=true");
            }

            return BadRequest();
        }
        
        
        public IActionResult Delete(int id)
        {
            var orderDetail = _context.OrderDetails.Find(id);
            _context.Remove(orderDetail);
            _context.SaveChanges();
            return Redirect("/UserPanel/MyOrders/ShowOrder/"+orderDetail.OrderId);
        }

    }

}
