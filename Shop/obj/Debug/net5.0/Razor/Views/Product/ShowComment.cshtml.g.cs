#pragma checksum "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2aac88e30573ec250f2d059c047a4f47e11631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowComment), @"mvc.1.0.view", @"/Views/Product/ShowComment.cshtml")]
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
#line 1 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
using Shop.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
using Shop.DataLayer.Entities.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2aac88e30573ec250f2d059c047a4f47e11631", @"/Views/Product/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7db16aee64cbeac812c006cdd1ca0852847eda", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Shop.DataLayer.Entities.Product.ProductComment>, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
 foreach (var item in Model.Item1)
{
    if (item.ParentId == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"comment-row\">\r\n            <table class=\"table table-striped table-bordered\">\r\n                <tbody>\r\n                    <tr>\r\n                        <td style=\"width: 50%;\"><strong><span> ");
#nullable restore
#line 17 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                                                          Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></strong></td>\r\n                        <td class=\"text-right\"><span>");
#nullable restore
#line 18 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                                                Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"2\">\r\n\r\n                            <p> ");
#nullable restore
#line 23 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"comment-row\">\r\n            <table class=\"table table-striped table-bordered\">\r\n                <tbody>\r\n                    <tr>\r\n                        <td colspan=\"2\">\r\n\r\n                            <p> پاسخ به ");
#nullable restore
#line 40 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                                   Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td style=\"width: 50%;\"><strong><span> ");
#nullable restore
#line 45 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                                                          Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></strong></td>\r\n                        <td class=\"text-right\"><span>");
#nullable restore
#line 46 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                                                Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"2\">\r\n\r\n                            <p> ");
#nullable restore
#line 51 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 66 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
         for (int i = 1; i <= (int)Model.Item2; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1939, "\"", 1964, 3);
            WriteAttributeValue("", 1949, "pageComment(", 1949, 12, true);
#nullable restore
#line 68 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
WriteAttributeValue("", 1961, i, 1961, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1963, ")", 1963, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 69 "C:\Users\wolf\Desktop\proje\shop\Shop\Views\Product\ShowComment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</nav>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Shop.DataLayer.Entities.Product.ProductComment>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
