#pragma checksum "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "deb425509bbf1ce5b2803fe207042b40a9940abb22ebe1a50293031ce5c91d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__AdminLayout), @"mvc.1.0.view", @"/Pages/Shared/_AdminLayout.cshtml")]
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
#line 1 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
using Shop.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"deb425509bbf1ce5b2803fe207042b40a9940abb22ebe1a50293031ce5c91d30", @"/Pages/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efea2e71f954bd473eba526326fbac5407ace7a66ae135e1beeec8cf3de90fbd", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb425509bbf1ce5b2803fe207042b40a9940abb22ebe1a50293031ce5c91d303302", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <title>پنل مدیریت </title>

    <!-- Core CSS - Include with every page -->
    <link href=""/AdminContent/css/bootstrap-rtl.css"" rel=""stylesheet"">
    <link href=""/AdminContent/font-awesome/css/font-awesome.css"" rel=""stylesheet"">

    <!-- Page-Level Plugin CSS - Dashboard -->
    <link href=""/AdminContent/css/plugins/morris/morris-0.4.3.min.css"" rel=""stylesheet"">
    <link href=""/AdminContent/css/plugins/timeline/timeline.css"" rel=""stylesheet"">

    <!-- SB Admin CSS - Include with every page -->
    <link href=""/AdminContent/css/sb-admin.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb425509bbf1ce5b2803fe207042b40a9940abb22ebe1a50293031ce5c91d305016", async() => {
                WriteLiteral(@"

    <div id=""wrapper"">

        <nav class=""navbar navbar-default navbar-fixed-top"" role=""navigation"" style=""margin-bottom: 0"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".sidebar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""/Admin"">themesmad</a>
            </div>
            <!-- /.navbar-header -->



            <div class=""navbar-default navbar-static-side"" role=""navigation"">
                <div class=""sidebar-collapse"">
                    <ul class=""nav"" id=""side-menu"">
                        <li class=""sidebar-search"">
                            <div class=""input-group custom-search-form"">
                                <input t");
                WriteLiteral(@"ype=""text"" class=""form-control"" placeholder=""Search..."">
                                <span class=""input-group-btn"">
                                    <button class=""btn btn-default"" type=""button"">
                                        <i class=""fa fa-search""></i>
                                    </button>
                                </span>
                            </div>
                            <!-- /input-group -->
                        </li>
");
#nullable restore
#line 61 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                         if (_PermissionService.CheckPermission(1, User.Identity.Name))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <a href=\"/Admin\"><i class=\"fa fa-dashboard fa-fw\"></i> پنل ادمین</a>\r\n                            </li>\r\n");
#nullable restore
#line 66 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            <a href=\"#\"><i class=\"fa fa-bar-chart-o fa-fw\"></i> مدیریت کاربران<span class=\"fa arrow\"></span></a>\r\n                            <ul class=\"nav nav-second-level\">\r\n");
#nullable restore
#line 70 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                                 if (_PermissionService.CheckPermission(6, User.Identity.Name))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <a href=\"/Admin/roles\">دسترسی ها</a>\r\n                                    </li>\r\n");
#nullable restore
#line 75 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                                 if (_PermissionService.CheckPermission(2, User.Identity.Name))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li>
                                        <a href=""/Admin/Users"">کاربران</a>
                                    </li>
                                    <li>
                                        <a href=""/Admin/Users/ListDeleteUsers"">کاربران حذف شده</a>
                                    </li>
");
#nullable restore
#line 84 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                            <!-- /.nav-second-level -->\r\n                        </li>\r\n");
#nullable restore
#line 88 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                         if (_PermissionService.CheckPermission(10, User.Identity.Name))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <a href=\"/Admin/Products\">لیست محصولات</a>\r\n                            </li>\r\n");
#nullable restore
#line 93 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                         if (_PermissionService.CheckPermission(22, User.Identity.Name))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <a href=\"/Admin/productcategories\">دسته بندی ها</a>\r\n                            </li>\r\n");
#nullable restore
#line 99 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                         if (_PermissionService.CheckPermission(18, User.Identity.Name))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <a href=\"/Admin/Discounts\">کد های تخفیف</a>\r\n                            </li>\r\n");
#nullable restore
#line 105 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                         if (_PermissionService.CheckPermission(26, User.Identity.Name))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <a href=\"/Admin/ORders\">لیست سفارشات</a>\r\n                            </li>\r\n");
#nullable restore
#line 111 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
#nullable restore
#line 111 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                            if (_PermissionService.CheckPermission(27, User.Identity.Name))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <a href=\"/Admin/comments\">لیست دیدگاه ها</a>\r\n                            </li>");
#nullable restore
#line 115 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
                                 }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </ul>
                    <!-- /#side-menu -->
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->
        </nav>

        <div id=""page-wrapper"">
            ");
#nullable restore
#line 125 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
    <!-- Core Scripts - Include with every page -->
    <script src=""/AdminContent/js/jquery-1.10.2.js""></script>
    <script src=""/AdminContent/js/bootstrap.min.js""></script>
    <script src=""/AdminContent/js/plugins/metisMenu/jquery.metisMenu.js""></script>

    <!-- Page-Level Plugin Scripts - Dashboard -->
    <script src=""/AdminContent/js/plugins/morris/raphael-2.1.0.min.js""></script>
    <script src=""/AdminContent/js/plugins/morris/morris.js""></script>

    <!-- SB Admin Scripts - Include with every page -->
    <script src=""/AdminContent/js/sb-admin.js""></script>

    <!-- Page-Level Demo Scripts - Dashboard - Use for reference -->
    <script src=""/AdminContent/js/demo/dashboard-demo.js""></script>
    ");
#nullable restore
#line 145 "D:\project\themsmad.ir\shop\Shop\Pages\Shared\_AdminLayout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPermissionService _PermissionService { get; private set; } = default!;
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
