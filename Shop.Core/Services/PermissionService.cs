﻿using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private ShopContext _context;
        public PermissionService(ShopContext context)
        {
            _context = context;
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach (int roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId= roleId,
                    UserId = userId
                });
            }
            _context.SaveChanges();
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
