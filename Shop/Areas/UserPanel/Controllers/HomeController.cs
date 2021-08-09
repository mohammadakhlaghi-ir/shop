﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }
    }
}
