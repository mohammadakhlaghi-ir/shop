#pragma checksum "D:\project\themsmad.ir\shop\Shop\Views\Account\SuccessRegister.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56d2bc40e40b142851df52218c178a4a8fa0c2492be6a3fa88b6a4fbd8cc2fa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuccessRegister), @"mvc.1.0.view", @"/Views/Account/SuccessRegister.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"56d2bc40e40b142851df52218c178a4a8fa0c2492be6a3fa88b6a4fbd8cc2fa2", @"/Views/Account/SuccessRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efea2e71f954bd473eba526326fbac5407ace7a66ae135e1beeec8cf3de90fbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_SuccessRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.DataLayer.Entities.User.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\project\themsmad.ir\shop\Shop\Views\Account\SuccessRegister.cshtml"
  
    ViewData["Title"] = "پایان ثبت نام";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">فروشگاه تم محمد اخلاقی</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">پایان ثبت نام</li>
    </ul>
</nav>

<div class=""alert alert-success"">
    <h2>");
#nullable restore
#line 14 "D:\project\themsmad.ir\shop\Shop\Views\Account\SuccessRegister.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز !</h2>\r\n    <p>ثبت نام شما انجام شد ، ایمیلی حاوی لینک فعالسازی به ایمیل \"");
#nullable restore
#line 15 "D:\project\themsmad.ir\shop\Shop\Views\Account\SuccessRegister.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ارسال شد .</p>\r\n    <p>جهت ادامه ثبت نام وارد ایمیل خود شوید و روی لینک کلیک کنید .</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.DataLayer.Entities.User.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
