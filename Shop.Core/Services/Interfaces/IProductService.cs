using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.DTOs;
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
        ProductCategory GetCategoryById(int categoryId);
        void AddCategory(ProductCategory category);
        void UpdateCategory(ProductCategory category);
        void DeleteCategory(ProductCategory category);
        #endregion
        #region Product
        Product GetProductById(int productId);
        ShowProductForAdminViewModel GetProductsForAdmin(int pageId = 1, string filterProductName = "");
        
        int AddProduct(Product product, IFormFile imgProdcut);
        void UpdateProduct(Product product, IFormFile imgProdcut);
        void DeleteProduct(Product product);
        List<Product> GetAllProducts();
        Tuple<List<ShowProductListItemViewModel>, int> GetProduct(int pageId = 1, string filter = "",
            string orderByType = "date", List<int> selectedCategories = null, int take = 0);
        Product GetProductForShow(int productId);
        List<ShowProductListItemViewModel> GetPopularProduct();
        #endregion
        #region ProductFile
        List<ProductFile> GetListProductFile(int productId);
        bool CheckExistFile(string fileName);
        void DeleteProductFile(ProductFile productFile);
        int AddProductFile(ProductFile file, IFormFile prodcutFile);
        ProductFile GetProductFileById(int prodcutFileId);
        void EditProductFile(ProductFile file, IFormFile prodcutFile);
        #endregion
        #region Comments

        void AddComment(ProductComment comment);
        List<ProductComment> GetAllComments();
        ProductComment GetCommentById(int productCommentId);
        void DeleteComment(ProductComment productComment);

        CommentForAdminVIewModel GetComments(int pageId = 1, string filterProductName = "", string filterUserName = "");
        Tuple<List<ProductComment>, int> GetProductComment(int productId, int pageId = 1);

        #endregion
    }

}
