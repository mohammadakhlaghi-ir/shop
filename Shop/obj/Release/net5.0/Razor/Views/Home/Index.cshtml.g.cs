#pragma checksum "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5a1aafa6bdffdca9b2431a9bdaa4a721b8746690947f4003baee9acd49b6a405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
using Shop.Core.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
using Shop.DataLayer.Entities.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5a1aafa6bdffdca9b2431a9bdaa4a721b8746690947f4003baee9acd49b6a405", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efea2e71f954bd473eba526326fbac5407ace7a66ae135e1beeec8cf3de90fbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Shop.Core.DTOs.ShowProductListItemViewModel>, int>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""container"">

    <div class=""container"">
        <div class=""row"">
            <!--Middle Part Start-->
            <div id=""content"" class=""col-xs-12"">
                <!-- Slideshow Start-->
                <div class=""slideshow single-slider owl-carousel"">
                    <div class=""item""> <a href=""/product""><img class=""img-responsive"" src=""/image/slider/banner2.jpg"" alt=""فروشگاه محمد اخلاقی"" /></a> </div>
                    <div class=""item""> <a href=""https://mohammadakhlaghi.ir""><img class=""img-responsive"" src=""/image/slider/banner1.jpg"" alt=""محمد اخلاقی برنامه نویس"" /></a> </div>
                    <div class=""item""> <a href=""https://mohammadakhlaghi.ir/blog""><img class=""img-responsive"" src=""/image/slider/banner3.jpg"" alt=""محمد اخلاقی برنامه نویس"" /></a> </div>

                </div>
                <!-- Slideshow End-->
                <!-- Banner Start-->
                <!-- Banner End-->
                <!-- محصولات Tab Start -->
                <div id=""product-t");
            WriteLiteral(@"ab"" class=""product-tab"">
                    <ul id=""tabs"" class=""tabs"">
                        <li class=""active""><a href=""#tab-latest"">جدیدترین</a></li>
                        <li><a href=""#tab-popular"">محبوب ترین</a></li>

                    </ul>
                    <div id=""tab-latest"" class=""tab_content"">
                        <div class=""owl-carousel product_carousel_tab"">
");
#nullable restore
#line 33 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
                             foreach (var item in Model.Item1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a1aafa6bdffdca9b2431a9bdaa4a721b8746690947f4003baee9acd49b6a4055527", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 35 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div id=\"tab-popular\" class=\"tab_content\">\r\n                        <div class=\"owl-carousel product_carousel_tab\">\r\n");
#nullable restore
#line 41 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
                              
                                List<ShowProductListItemViewModel> popular = ViewBag.PopularProduct as List<ShowProductListItemViewModel>;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
                             if (popular != null)
                            {
                                foreach (var item in popular)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a1aafa6bdffdca9b2431a9bdaa4a721b8746690947f4003baee9acd49b6a4058230", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "D:\project\themsmad.ir\shop\Shop\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>



                </div>    <!-- محصولات Tab Start -->
                <!-- Banner Start -->
                <div class=""marketshop-banner"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12""><a href=""https://mohammadakhlaghi.ir""><img src=""/image/banner/develop.jpg"" alt=""محمد اخلاقی طراح سایت"" title=""محمد اخلاقی طراح سایت"" /></a></div>
                        <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12""><a href=""https://mohammadakhlaghi.ir""><img src=""/image/banner/developapp.jpg"" alt=""محمد اخلاقی طراح اپلیکیشن"" title=""محمد اخلاقی طراح اپلیکیشن"" /></a></div>
                    </div>
                </div>
                <!-- Banner End -->



            </div>
            <!--Middle Part End-->
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Shop.Core.DTOs.ShowProductListItemViewModel>, int>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
