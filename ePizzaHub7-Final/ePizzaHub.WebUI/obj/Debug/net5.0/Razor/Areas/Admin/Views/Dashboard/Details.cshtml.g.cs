#pragma checksum "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299c760fb88fb0a5cc897221c834fcd96688a31f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Details.cshtml")]
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
#line 1 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.Repositories.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299c760fb88fb0a5cc897221c834fcd96688a31f", @"/Areas/Admin/Views/Dashboard/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa8ab1f9f01c0863a76c8e15126a1e58ea19291", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Details : ePizzaHub.WebUI.Helpers.BaseViewPage<ePizzaHub.Repositories.Models.OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Sipariş Detayı</h2>\r\n<hr />\r\n");
#nullable restore
#line 8 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
       Write(Html.DisplayName("Order Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ₹");
#nullable restore
#line 27 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
        Write(Html.DisplayFor(model => model.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    <table class=""table"">
        <thead>
            <tr>
                <th colspan=""2"">
                    Ürün Detayı
                </th>
                <th>
                    Açıklama
                </th>
                <th>
                    Birim Fiyat
                </th>
                <th>
                    Miktar
                </th>
                <th>
                    Toplam
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 51 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1433, "\"", 1453, 1);
#nullable restore
#line 55 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
WriteAttributeValue("", 1439, item.ImageUrl, 1439, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ₹");
#nullable restore
#line 64 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
                    Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ₹");
#nullable restore
#line 70 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 73 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "299c760fb88fb0a5cc897221c834fcd96688a31f11023", async() => {
                WriteLiteral("Geri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 79 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-12 mt-4\">\r\n            <p style=\"min-height:300px\">\r\n                Ürün Detayı Yok\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 89 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ePizzaHub.Repositories.Models.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
