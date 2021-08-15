using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index() {
            ViewBag.keywords = "فروشگاه قالب و پلاگین محمد اخلاقی | محمد اخلاقی | ";
            ViewBag.Descption = "فروشگاه قالب و پلاگین اختصاصی و غیر اختصاصی محمد اخلاقی برنامه نویس تحت بک اند و اپلیکیشن";
            return View(); }
        
        [Route("Error")]
        public IActionResult Error()
        {
           
            return View();
        }
        
        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        {
            if(HttpContext.Request.Query["Status"] !=""&&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"&&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];
                var wallet = _userService.GetWalletByWalletId(id);
                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.Code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }
            }
            return View();
        }
    }

}
