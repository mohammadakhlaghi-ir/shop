using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs;
using Shop.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Controller
    {
        private IUserService _userService;

        public WalletController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            return View();
        }
        [Route("UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
                return View(charge);

            }
            int walletId = _userService.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ کیف پول");

            #region Online Payment
            
            var payment = new Zarinpal.Payment("f54d6d44-a637-43b4-b171-87c237dae35c", charge.Amount);
            var res = payment.PaymentRequest("شارژ کیف پول", "https://themesmad.ir/OnlinePayment/" + walletId , "mohammadakhlaghi.ir@gmail.com","09378982060");
            if(res.Result.Status == 100)
            {
                return Redirect("https://zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }
            #endregion
            return null;
        }
    }
}
