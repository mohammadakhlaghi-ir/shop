﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
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

        public MyOrdersController(IOrderService orderService)
        {
            _orderService = orderService;
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
                return NotFound();
            }

            ViewBag.finaly = finaly;
            return View(order);
        }

        public IActionResult FinalyOrder(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {
                return Redirect("/UserPanel/MyOrders/" + id + "?finaly=true");
            }

            return BadRequest();
        }
    }

}
