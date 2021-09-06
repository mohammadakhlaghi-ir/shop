using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs.Order
{
    public class OrderForAdminViewModel
    {
      
            public List<DataLayer.Entities.Order> Orders { get; set; }
            public int CurrentPage { get; set; }
            public int PageCount { get; set; }

        
    }
}
