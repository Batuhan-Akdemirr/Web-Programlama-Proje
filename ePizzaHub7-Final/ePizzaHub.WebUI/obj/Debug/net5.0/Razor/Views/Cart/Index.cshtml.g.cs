#pragma checksum "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc90858c834516b321aaa7678067105e01a36182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc90858c834516b321aaa7678067105e01a36182", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6c2151b50d34e51dad0fb018e547f0aab3d83d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<ePizzaHub.Repositories.Models.CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-returnurl", "/Cart/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart | ePizza Hub";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n");
#nullable restore
#line 8 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
     if (Model != null && Model.Items.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"card mb-3\">\r\n                    <div class=\"col-sm-12\">\r\n                        <h5 class=\"mt-3\">Sepet (");
#nullable restore
#line 14 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                           Write(Model.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ürün)</h5>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"card-body pt-0 pb-0\">\r\n");
#nullable restore
#line 18 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-5 col-lg-3 col-xl-3"">
                                    <div class=""rounded mb-3 mb-md-0"">
                                        <img class=""rounded w-100""");
            BeginWriteAttribute("src", "\r\n                                             src=\"", 865, "\"", 931, 1);
#nullable restore
#line 24 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 917, item.ImageUrl, 917, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Sample"">
                                    </div>
                                </div>
                                <div class=""col-md-7 col-lg-9 col-xl-9"">
                                    <div class=""d-flex justify-content-between"">
                                        <div>
                                            <h5>");
#nullable restore
#line 30 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"mb-2 text-muted small\">Boyut: Orta</p>\r\n                                            <p class=\"mb-2 text-muted small\">\r\n                                                Fiyat: ₺");
#nullable restore
#line 33 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                                    Write((item.UnitPrice/100).ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <span class=\"pl-1\">\r\n                                                    <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1720, "\"", 1752, 3);
            WriteAttributeValue("", 1730, "deleteItem(\'", 1730, 12, true);
#nullable restore
#line 35 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1742, item.Id, 1742, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1750, "\')", 1750, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" title=""Remove"" class=""pt-0""><i class=""bi bi-trash text-danger""></i></a>
                                                </span>
                                            </p>
                                        </div>
                                        <div>
                                            <div class=""def-number-input number-input safari_only mb-0 w-100"">
                                                <div class=""input-group mb-3"">
                                                    <div class=""input-group-prepend"">
                                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2371, "\"", 2410, 3);
            WriteAttributeValue("", 2381, "updateQuantity(\'", 2381, 16, true);
#nullable restore
#line 43 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2397, item.Id, 2397, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2405, "\',-1)", 2405, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\" type=\"button\">-</button>\r\n                                                    </div>\r\n                                                    <input class=\"form-control sm-control\" size=\"2\" min=\"0\" name=\"quantity\"");
            BeginWriteAttribute("value", " value=\"", 2655, "\"", 2677, 1);
#nullable restore
#line 45 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2663, item.Quantity, 2663, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                                                    <div class=\"input-group-append\">\r\n                                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2841, "\"", 2879, 3);
            WriteAttributeValue("", 2851, "updateQuantity(\'", 2851, 16, true);
#nullable restore
#line 47 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2867, item.Id, 2867, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2875, "\',1)", 2875, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-secondary"" type=""button"">+</button>
                                                    </div>
                                                </div>
                                            </div>
                                            <span id=""spanTotal"" class=""form-text text-muted text-center"">
                                                Toplam : ₺");
#nullable restore
#line 52 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                                      Write(((item.UnitPrice * @item.Quantity)/100).ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 58 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                             if (Model.Items.IndexOf(item) < Model.Items.Count - 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr class=\"mb-4\">\r\n");
#nullable restore
#line 61 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""mb-3"">
                    <a href=""/"" class=""btn btn-outline-primary"">Alışverişe Devam Et</a>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card mb-3"">
                    <div class=""col-sm-12"">
                        <h5 class=""mt-3"">Sipariş Özeti</h5>
                    </div>
                    <hr />
                    <div class=""card-body pt-0"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0"">
                                Miktar
                                <span>₺");
#nullable restore
#line 79 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                   Write(Model.Total/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0\">\r\n                                Vergi (5%)\r\n                                <span>+₺");
#nullable restore
#line 83 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                    Write(Model.Tax/100);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center  px-0 mb-3"">
                                <strong>Toplam Miktar</strong>
                                <span><strong>₺");
#nullable restore
#line 87 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                                           Write(Model.GrandTotal/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 90 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                         if (CurrentUser != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc90858c834516b321aaa7678067105e01a3618216811", async() => {
                WriteLiteral("Öde");
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
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc90858c834516b321aaa7678067105e01a3618218577", async() => {
                WriteLiteral("Öde");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 102 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-sm-12 mt-5"">
                <p style=""min-height:300px"">
                    Sepetiniz boş. Lütfen menüden bazı öğeler ekleyin.! <br><br>
                    <a href=""/"" class=""btn btn-primary"">Ana Sayfa</a>
                </p>
            </div>
        </div>
");
#nullable restore
#line 113 "C:\Users\batuh\OneDrive\Masaüstü\Web-Final\ePizzaHub7-Final\ePizzaHub.WebUI\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ePizzaHub.Repositories.Models.CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
