using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.DTOs;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;

namespace Shop.Pages.Admin.Users
{
    [PermissionChecker(2)]

    public class IndexModel : PageModel
    {
        private IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }
        public UserForAdminViewModel UserForAdminViewModel { get; set; }

        public void OnGet(int pageId = 1, string filterUserName = "", string filterEmail = "")
        {
            UserForAdminViewModel = _userService.GetUsers(pageId, filterEmail, filterUserName);
        }

    }
}
