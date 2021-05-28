using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            ViewBag.keywords = "فروشگاه قالب و پلاگین محمد اخلاقی | محمد اخلاقی | ";
            ViewBag.Descption = "فروشگاه قالب و پلاگین اختصاصی و غیر اختصاصی محمد اخلاقی برنامه نویس تحت بک اند و اپلیکیشن";
            return View(); }

        [Route("/Home/HandleError/{code:int}")]
        public IActionResult HandleError(int code)
        {
            ViewData["ErrorMessage"] = $"Error occurred. The ErrorCode is: {code}";
            return View("~/Views/Shared/HandleError.cshtml");
        }
    }

}
