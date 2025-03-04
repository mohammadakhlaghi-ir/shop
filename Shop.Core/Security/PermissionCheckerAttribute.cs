﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Shop.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Security
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private IPermissionService _permissionService;
        private int _permissionId = 0;
        public PermissionCheckerAttribute(int permissionId)
        {
            _permissionId = permissionId;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService =
               (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string userName = context.HttpContext.User.Identity.Name;
                if (!_permissionService.CheckPermission(_permissionId, userName))
                {
                    context.Result = new RedirectResult("/Login?" + context.HttpContext.Request.Path);
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
