#pragma checksum "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52fecb80a19720703b2741198fe385cd16ef6acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxProductCategory), @"mvc.1.0.view", @"/Views/Shared/_BoxProductCategory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
using Shop.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52fecb80a19720703b2741198fe385cd16ef6acf", @"/Views/Shared/_BoxProductCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7db16aee64cbeac812c006cdd1ca0852847eda", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BoxProductCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Core.DTOs.ShowProductListItemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
  
   
    bool IsUserInProduct = false;

    if (User.Identity.IsAuthenticated)
    {
        IsUserInProduct = _OrderService.IsUserInProduct(User.Identity.Name, Model.ProductId);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"product-layout product-grid col-lg-3 col-md-3 col-sm-4 col-xs-12\">\r\n    <div class=\"product-thumb\">\r\n        <div class=\"image\"><a");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 512, 2);
            WriteAttributeValue("", 475, "/product/ShowProduct/", 475, 21, true);
#nullable restore
#line 15 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
WriteAttributeValue("", 496, Model.ProductId, 496, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 518, "\"", 555, 2);
            WriteAttributeValue("", 524, "/product/thumb/", 524, 15, true);
#nullable restore
#line 15 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
WriteAttributeValue("", 539, Model.ImageName, 539, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 556, "\"", 574, 1);
#nullable restore
#line 15 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
WriteAttributeValue("", 562, Model.Title, 562, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 575, "\"", 595, 1);
#nullable restore
#line 15 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
WriteAttributeValue("", 583, Model.Title, 583, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" /></a></div>\r\n        <div class=\"caption\">\r\n            <h4><a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 727, 2);
            WriteAttributeValue("", 690, "/product/ShowProduct/", 690, 21, true);
#nullable restore
#line 17 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
WriteAttributeValue("", 711, Model.ProductId, 711, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
                                                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            <p class=\"price\"><span class=\"price-new\">");
#nullable restore
#line 18 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
                                                 Write((Model.Price==0)?"رایگان":Model.Price.ToString("#,0") + "تومان");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> <span class=\"price-old\">");
#nullable restore
#line 18 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
                                                                                                                                                    Write((Model.Price==0)?null:Model.OldPrice.ToString("#,0") + "تومان");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
         if (Model.Price != 0 && !IsUserInProduct)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cart\">\r\n                <div>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1169, 2);
            WriteAttributeValue("", 1133, "/product/BuyProduct/", 1133, 20, true);
#nullable restore
#line 24 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
WriteAttributeValue("", 1153, Model.ProductId, 1153, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"> افزودن به سبد</a>\r\n                </div>\r\n\r\n            </div>");
#nullable restore
#line 27 "C:\Users\shadow\Desktop\shop\Shop\Views\Shared\_BoxProductCategory.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<span class=\"clearfix visible-lg-block\" />\r\n\r\n\r\n\r\n\r\n\r\n");
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
