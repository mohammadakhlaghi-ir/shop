using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataLayer.Entities.Product
{
    public class UserProduct
    {
        [Key]
        public int UP_Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }


        public Product Product { get; set; }
        public User.User User { get; set; }
    }
}
