﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataLayer.Entities
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
      
        [Required]
        public int Price { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product.Product Product { get; set; }

    }

}
