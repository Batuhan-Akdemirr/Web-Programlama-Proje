#pragma checksum "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac8d0fb174ad94b5b450fa25f066af9081d9d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.Repositories.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac8d0fb174ad94b5b450fa25f066af9081d9d8f", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa8ab1f9f01c0863a76c8e15126a1e58ea19291", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<PagingListModel<OrderModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Order List</h2>\r\n");
#nullable restore
#line 10 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
 if (Model != null && Model.TotalRows > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Id
                </th>
                <th>
                    PaymentId
                </th>
                <th>
                    Amount
                </th>
                <th>
                    Locality
                </th>
                <th>
                    CreatedDate
                </th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
             foreach (var item in Model.Data)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PaymentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ₹");
#nullable restore
#line 44 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"6\" style=\"padding-bottom: 10px;\">\r\n                    ");
#nullable restore
#line 59 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Html.PagedListPager((IPagedList)Model.Data,
                            page => Url.Action("Index", new
                            {
                                page = page,
                                pageSize = Model.PageSize
                             }), PagedListRenderOptions.OnlyShowFivePagesAtATime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 69 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-12 mt-4\">\r\n            <p style=\"min-height:300px\">\r\n                There is no order received!\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingListModel<OrderModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
