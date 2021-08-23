using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.DTOs.Product;
using Shop.DataLayer.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services.Interfaces
{
    public interface IProductService
    {
        #region Category

        List<ProductCategory> GetAllCategory();
        List<SelectListItem> GetCategoryForManageProduct();
        List<SelectListItem> GetSubCategoryForManageProduct(int groupId);
        #endregion
        #region Product
        Product GetProductById(int productId);
        List<ShowProductForAdminViewModel> GetProductsForAdmin();
        void DeleteProduct(int productId);
        int AddProduct(Product product, IFormFile imgCourse);

        #endregion
    }

}
