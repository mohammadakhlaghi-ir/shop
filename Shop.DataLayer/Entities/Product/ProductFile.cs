using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataLayer.Entities.Product
{
    public class ProductFile
    {
        [Key]
        public int FileId { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "عنوان فایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string FileTitle { get; set; }


        [Display(Name = "فایل")]
        public string FileName { get; set; }

        [Display(Name = "رایگان")]
        public bool IsFree { get; set; }


        public Product Product { get; set; }


    }
}
