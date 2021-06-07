using Microsoft.AspNetCore.Mvc;
using Shop.Core.Convertors;
using Shop.Core.DTOs;
using Shop.Core.Generator;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;

        }
        #region register
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد");
                return View(register);
            }
            if (_userService.IsExistEmail(FixedText.FixEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل معتبر نمی باشد");
                return View(register);
            }


            DataLayer.Entities.User.User user = new User()
            {
                ActiveCode = NameGenerator.GenerateUniqCode(),
                Email = FixedText.FixEmail(register.Email),
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                RegisterDate = DateTime.Now,
                UserName = register.UserName
            };
            _userService.AddUser(user);

            return View("SuccessRegister", user);

        }
        #endregion
        #region login
        [Route("Login")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _userService.LoginUser(login);
            if (user != null)
            {
                if (user.IsActive)
                {
                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد");
                }
            }
            ModelState.AddModelError("Email", "کاربری با مشخصات وارد شده یافت نشد");
            return View(login);
        }

        #endregion
        #region Active Account

        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }

        #endregion

    }
}
