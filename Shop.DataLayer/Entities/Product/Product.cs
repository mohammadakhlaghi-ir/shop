using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataLayer.Entities.Product
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public int? SubCategory { get; set; }

        [Display(Name = "عنوان محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string ProductTitle { get; set; }

        [Display(Name = "شرح محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductDescription { get; set; }

        [Display(Name = "قیمت محصول بدون تخفیف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ProductPriceOld { get; set; }
        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ProductPrice { get; set; }

        [MaxLength(600)]
        public string Tags { get; set; }

        [MaxLength(50)]
        public string ProductImageName { get; set; }


        [Required]
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }


        #region Relations

        [ForeignKey("CategoryId")]
        public ProductCategory ProductCategory { get; set; }

        [ForeignKey("SubCategory")]
        public ProductCategory Category { get; set; }

        public List<ProductFile> ProductFile { get; set; }
        #endregion
    }

}
