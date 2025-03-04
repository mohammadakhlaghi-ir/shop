﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.DTOs;
using Shop.Core.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IProductService _productService;
        public HomeController(IUserService userService, IProductService productService)
        {
            _userService = userService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            var popular = _productService.GetPopularProduct();
            ViewBag.PopularProduct = popular;
            ViewBag.keywords = "فروشگاه قالب و پلاگین محمد اخلاقی | محمد اخلاقی  ";
            ViewBag.Descption = "فروشگاه قالب و پلاگین اختصاصی و غیر اختصاصی محمد اخلاقی برنامه نویس تحت بک اند و اپلیکیشن";
            return View(_productService.GetProduct());
        }
       
      
        [Route("Error")]
        public IActionResult Error()
        {

            return View();
        }

        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        {
           
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];
                var wallet = _userService.GetWalletByWalletId(id);
                var payment = new Zarinpal.Payment("f54d6d44-a637-43b4-b171-87c237dae35c", wallet.Amount);
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
        public IActionResult GetSubCategories(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_productService.GetSubCategoryForManageProduct(id));
            return Json(new SelectList(list, "Value", "Text"));
        }
        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/MyImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/MyImages/"}{fileName}";


            return Json(new { uploaded = true, url });
        }

    }

}
