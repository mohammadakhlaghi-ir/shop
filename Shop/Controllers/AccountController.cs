﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Convertors;
using Shop.Core.DTOs;
using Shop.Core.Generator;
using Shop.Core.Security;
using Shop.Core.Senders;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewRender;

        public AccountController(IUserService userService, IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;

        }
        #region Register

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

            #region Send Activation Email
            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعال سازی", body);
            #endregion

            return View("SuccessRegister", user);
        }


        #endregion

        #region Login
        [Route("Login")]
        public ActionResult Login(bool EditProfile=false)
        {
            ViewBag.EditProfile = EditProfile;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult Login(LoginViewModel login, string ReturnUrl = "/")
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
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.IsSuccess = true;
                    if (ReturnUrl != "/")
                    {
                        return Redirect(ReturnUrl);
                    }

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

        #region Logout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }

        #endregion
        #region ForgotPassword
        [Route("ForgotPassword")]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [Route("ForgotPassword")]
        public ActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
                return View(forgot);
            string fixedEmail = FixedText.FixEmail(forgot.Email);
            User user = _userService.GetUserByEmail(fixedEmail);
            if (user == null)
            {
                ModelState.AddModelError("Email", "کاربری یافت نشد");
                return View(forgot);
            }
            string bodyEmail = _viewRender.RenderToStringAsync("_ForgotPassword", user);
            SendEmail.Send(user.Email, "بازیابی حساب کاربری", bodyEmail);
            ViewBag.IsSuccess = true;
            return View();
        }
        #endregion

        #region ResetPasword
        public ActionResult ResetPassword(string id)
        {
            return View(new ResetPasswrodViewModel()
            {
                ActiveCode = id
            }) ;
        }  
        [HttpPost]
        public ActionResult ResetPassword(ResetPasswrodViewModel reset)
        {
            if (!ModelState.IsValid)
                return View(reset);

            User user = _userService.GetUserByActiveCode(reset.ActiveCode);
            if (user == null)
                return NotFound();
            string hashNewPassword = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hashNewPassword;
            _userService.UpdateUser(user);
            return Redirect("/Login");
        }
        #endregion
    }
}
