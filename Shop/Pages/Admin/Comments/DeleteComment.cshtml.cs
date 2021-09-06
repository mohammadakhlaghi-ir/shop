using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Core.Security;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Entities.Product;

namespace Shop.Pages.Admin.Comments
{
    [PermissionChecker(28)]
    public class DeleteCommentModel : PageModel
    {
        
        private IProductService _productService;

        public DeleteCommentModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductComment Comment { get; set; }
        public void OnGet(int id)
        {
            Comment = _productService.GetCommentById(id);
        }

        public IActionResult OnPost()
        {
            _productService.DeleteComment(Comment);

            return RedirectToPage("Index");
        }
    }
}
