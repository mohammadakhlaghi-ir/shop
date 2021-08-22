using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataLayer.Entities.Product
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "عنوان دسته بندی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string CategoryTitle { get; set; }
        [Display(Name = "حذف شده ؟")]
        public bool IsDelete { get; set; }

        [Display(Name = "دسته بندی اصلی")]
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public List<ProductCategory> ProductCategories { get; set; }

        [InverseProperty("ProductCategory")]
        public List<Product> Products { get; set; }

        [InverseProperty("Category")]
        public List<Product> SubCategory { get; set; }

    }
}
