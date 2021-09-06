﻿using Shop.DataLayer.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs
{
    public class CommentForAdminVIewModel
    {
        public List<ProductComment> Commetns { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
