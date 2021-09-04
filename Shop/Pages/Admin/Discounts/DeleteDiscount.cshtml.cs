using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities;

namespace Shop.Pages.Admin.Discounts
{
    [PermissionChecker(21)]

    public class DeleteDiscountModel : PageModel
    {

        private IOrderService _orderService;

        public DeleteDiscountModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Discount Discount { get; set; }
        public void OnGet(int id)
        {
            Discount = _orderService.GetDiscountById(id);
        }

        public IActionResult OnPost()
        {
            _orderService.DeleteDiscount(Discount);

            return RedirectToPage("Index");
        }
    }
}
