#pragma checksum "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9644dd0e36ca006f7a38a8b6aeb0344f319c62c2e0f98865f771a74ad58493aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxProduct), @"mvc.1.0.view", @"/Views/Shared/_BoxProduct.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
using Shop.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9644dd0e36ca006f7a38a8b6aeb0344f319c62c2e0f98865f771a74ad58493aa", @"/Views/Shared/_BoxProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efea2e71f954bd473eba526326fbac5407ace7a66ae135e1beeec8cf3de90fbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BoxProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Core.DTOs.ShowProductListItemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
  

    bool IsUserInProduct = false;

    if (User.Identity.IsAuthenticated)
    {
        IsUserInProduct = _OrderService.IsUserInProduct(User.Identity.Name, Model.ProductId);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"owl-item\" style=\"width: 228px;\">\r\n    <div class=\"product-thumb\">\r\n        <div class=\"image\"><a");
            BeginWriteAttribute("href", " href=\"", 431, "\"", 475, 2);
            WriteAttributeValue("", 438, "/product/ShowProduct/", 438, 21, true);
#nullable restore
#line 15 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 459, Model.ProductId, 459, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 481, "\"", 518, 2);
            WriteAttributeValue("", 487, "/product/thumb/", 487, 15, true);
#nullable restore
#line 15 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 502, Model.ImageName, 502, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 519, "\"", 537, 1);
#nullable restore
#line 15 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 525, Model.Title, 525, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 538, "\"", 558, 1);
#nullable restore
#line 15 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 546, Model.Title, 546, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" /></a></div>\r\n        <div class=\"caption\">\r\n            <h4><a");
            BeginWriteAttribute("href", " href=\"", 646, "\"", 690, 2);
            WriteAttributeValue("", 653, "/product/ShowProduct/", 653, 21, true);
#nullable restore
#line 17 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 674, Model.ProductId, 674, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
                                                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            <p class=\"price\"><span class=\"price-new\">");
#nullable restore
#line 18 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
                                                 Write((Model.Price==0)?"رایگان":Model.Price.ToString("#,0") + "تومان");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> <span class=\"price-old\">");
#nullable restore
#line 18 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
                                                                                                                                                    Write((Model.Price==0)?null:Model.OldPrice.ToString("#,0") + "تومان");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        </div>\r\n");
#nullable restore
#line 20 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
         if (Model.Price != 0 && !IsUserInProduct)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cart\">\r\n                <div>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1132, 2);
            WriteAttributeValue("", 1096, "/product/BuyProduct/", 1096, 20, true);
#nullable restore
#line 24 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 1116, Model.ProductId, 1116, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"> افزودن به سبد</a>\r\n                </div>\r\n\r\n            </div>");
#nullable restore
#line 27 "D:\project\themsmad.ir\shop\Shop\Views\Shared\_BoxProduct.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOrderService _OrderService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Core.DTOs.ShowProductListItemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
