using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs.Order;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;

namespace Shop.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class MyOrdersController : Controller
    {
        private IOrderService _orderService;
        private ShopContext _context;

        public MyOrdersController(IOrderService orderService, ShopContext context)
        {
            _orderService = orderService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetUserOrders(User.Identity.Name));
        }

        public IActionResult ShowOrder(int id, bool finaly = false, string type = "")
        {
            var order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);

            if (order == null)
            {
                return Redirect("/UserPanel/MyOrders");
            }
            ViewBag.typeDiscount = type;
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
            _orderService.UpdatePriceOrder(orderDetail.OrderId);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderDetail.OrderId);
        }
        public IActionResult UseDiscount(int orderId, string code)
        {
            DiscountUseType type = _orderService.UseDiscount(orderId, code);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId + "?type=" + type.ToString());
        }

    }

}
