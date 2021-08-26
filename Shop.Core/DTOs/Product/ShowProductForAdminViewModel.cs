using System;
using System.Collections.Generic;
using System.Linq;
using Shop.DataLayer.Entities.Product;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs
{
    public class ShowProductForAdminViewModel
    {
       
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
