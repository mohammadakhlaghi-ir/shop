#pragma checksum "E:\project\asp\shop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c6e3aded36126ad0384aeb665a916521dd3c309"
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
#line 1 "E:\project\asp\shop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using Shop.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\asp\shop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using Shop.Core.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c6e3aded36126ad0384aeb665a916521dd3c309", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7db16aee64cbeac812c006cdd1ca0852847eda", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\project\asp\shop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
   
    SideBarUserPanelViewModel user = _UserService.GetSideBarUserPanelData(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<aside id=\"column-right\" class=\"col-sm-3 hidden-xs\">\r\n    <h3 class=\"subtitle\">حساب کاربری</h3>\r\n    <h4 class=\"subtitle\">");
#nullable restore
#line 11 "E:\project\asp\shop\shop\Shop\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
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
            <li><a href=""#"">تاریخچه سفارشات</a></li>
            <li><a href=""#"">دانلود ها</a></li>
        </ul>
    </div>
</aside> ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
