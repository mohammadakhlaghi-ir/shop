#pragma checksum "D:\project\themsmad.ir\shop\Shop\Views\Home\onlinePayment.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62755e2177a3ff3c53c65deef8666e03be0490a7859f6eb26865c856472fe9cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_onlinePayment), @"mvc.1.0.view", @"/Views/Home/onlinePayment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"62755e2177a3ff3c53c65deef8666e03be0490a7859f6eb26865c856472fe9cf", @"/Views/Home/onlinePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efea2e71f954bd473eba526326fbac5407ace7a66ae135e1beeec8cf3de90fbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_onlinePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\project\themsmad.ir\shop\Shop\Views\Home\onlinePayment.cshtml"
  
    ViewData["Title"] = "نتیجه پرداخت";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""container"">
    <div class=""container"">
        <!-- Breadcrumb Start-->
        <ul class=""breadcrumb"">
            <li><a href=""/""><i class=""fa fa-home""></i></a></li>
            <li><a href=""/OnlinePayment"">نتیجه پرداخت</a></li>
        </ul>
");
#nullable restore
#line 14 "D:\project\themsmad.ir\shop\Shop\Views\Home\onlinePayment.cshtml"
         if (ViewBag.IsSuccess == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success\">\r\n                <h2 class=\"help-block\">پرداخت با موفقیت انجام شد</h2>\r\n                <p>کد پیگیری : ");
#nullable restore
#line 18 "D:\project\themsmad.ir\shop\Shop\Views\Home\onlinePayment.cshtml"
                          Write(ViewBag.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 20 "D:\project\themsmad.ir\shop\Shop\Views\Home\onlinePayment.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <h2 class=\"help-block\">پرداخت با شکست مواجه شد</h2>\r\n            </div>\r\n");
#nullable restore
#line 26 "D:\project\themsmad.ir\shop\Shop\Views\Home\onlinePayment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
