using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.DTOs.Order;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities;

namespace Shop.Pages.Admin.Orders
{
    [PermissionChecker(26)]
    public class IndexModel : PageModel
    {
        private IOrderService _orderService;

        public IndexModel(IOrderService orderService)
        {
            
            _orderService = orderService;
        }
        public OrderForAdminViewModel OrderForAdminViewModel { get; set; }

        public void OnGet(int pageId = 1, string filterOrderId = "", string filterUserName = "")
        {
            
            OrderForAdminViewModel = _orderService.GetOrders(pageId, filterOrderId,  filterUserName );

        }
    }
}
