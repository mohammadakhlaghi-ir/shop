#pragma checksum "C:\Users\shadow\Desktop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "036648616609784d87efc073072c5ef3fdf9b788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Shared__SideBar), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
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
#line 1 "C:\Users\shadow\Desktop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using Shop.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shadow\Desktop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using Shop.Core.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"036648616609784d87efc073072c5ef3fdf9b788", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7db16aee64cbeac812c006cdd1ca0852847eda", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_UserPanel_Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\shadow\Desktop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
   
    SideBarUserPanelViewModel user = _UserService.GetSideBarUserPanelData(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<aside id=\"column-right\" class=\"col-sm-3 hidden-xs\">\r\n    <h3 class=\"subtitle\">حساب کاربری</h3>\r\n    <h4 class=\"subtitle\">");
#nullable restore
#line 11 "C:\Users\shadow\Desktop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                    Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    <div class=""list-group"">
        <ul class=""list-item"">
            <li><a href=""/UserPanel""> پروفایل</a></li>
            <li><a href=""/UserPanel/EditProfile"">ویرایش پروفایل</a></li>
            <li><a href=""/UserPanel/ChangePassword"">تغییر رمز عبور</a></li>
            <li><a href=""/UserPanel/Wallet"">کیف پول</a></li>
            <li><a href=""/UserPanel/MyOrders"">نمایش فاکتورها</a></li>
            
        </ul>
    </div>
</aside> ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
