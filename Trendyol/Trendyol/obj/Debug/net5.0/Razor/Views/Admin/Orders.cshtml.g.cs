#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01094be2de36fd3fa3f56690540ca1736476760f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Orders), @"mvc.1.0.view", @"/Views/Admin/Orders.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\_ViewImports.cshtml"
using Trendyol;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\_ViewImports.cshtml"
using Trendyol.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\_ViewImports.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01094be2de36fd3fa3f56690540ca1736476760f", @"/Views/Admin/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0359f9a8bb00d1f3bffb678c26dfe4f04833ce4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Generic placeholder image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/type-writer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css"" rel=""stylesheet""
      integrity=""sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz""
        crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.0/css/all.min.css""
      integrity=""sha512-10/jx2EXwxxWqCLX/hHth/vu2KY3jCF70dCQB8TSgNjbCVAC/8vai53GfMDrO2Emgwccf2pJqxct9ehpzG+MTw==""
      crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<link rel=""stylesheet"" href=""style.css"">
<script src=""https://kit.fontawesome.com/9b5eb3da52.js"" crossorigin=""anonymous""></script>
<section style=""background-color: lightgrey;"">
    <div class=""container "">
        <br />
        <p><span class=""h1 text-primary""> Siparişler </span><span s");
            WriteLiteral("tyle=\"float:right\" class=\"h4 text-primary\">");
#nullable restore
#line 22 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                                                         Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Adet Sipariş</span></p>\r\n        <div class=\"row d-flex justify-content-center align-items-center \">\r\n            <div style=\"margin-top:20px\" class=\"col\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card mb-4"">
                        <div class=""card-body p-4"">

                            <div class=""row align-items-center"">
                                <div class=""col-md-2"">
                                    <p class=""small text-black mb-4 pb-2"">Sipariş Numarası</p>
                                    <p class=""lead fw-normal text-primary mb-0"">");
#nullable restore
#line 34 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                           Write(item.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""col-md-2 d-flex justify-content-center"">
                                    <div>
                                        <p class=""small text-black mb-4 pb-2"">Sipariş Tarihi</p>
                                        <p class=""lead fw-normal text-primary mb-0"">");
#nullable restore
#line 39 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                               Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""col-md-2 d-flex justify-content-center"">
                                    <div>
                                        <p class=""small text-black mb-4 pb-2"">Sipariş Sahibi</p>
                                        <p class=""lead text-primary fw-normal mb-0"">

                                            ");
#nullable restore
#line 47 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                       Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-md-2 d-flex justify-content-center"">
                                    <div>
                                        <p class=""small text-black mb-4 pb-2"">Sipariş Tutarı</p>
                                        <p class=""lead text-primary fw-normal mb-0"">");
#nullable restore
#line 54 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                               Write(item.OrderItems.Sum(i=>i.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</p>
                                    </div>
                                </div>
                                <div class=""col-md-2 d-flex justify-content-center"">
                                    <div>
                                        <p class=""small text-black mb-4 pb-2"">Sipariş Durumu</p>


");
#nullable restore
#line 62 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                         if (item.OrderState == EnumOrderState.completed)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <p class=""lead text-success fw-normal mb-0"">
                                                <i style=""color: green;"" class=""fas fa-check""></i>
                                                    Onaylandı
                                                </p>
");
#nullable restore
#line 68 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                         if (item.OrderState == EnumOrderState.unpaid)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <p style=""color:darkorange"" class=""lead  fw-normal mb-0"">

                                                <i style=""color:darkorange"" class=""fa-solid fa-truck""></i>   Kargoda              <a class=""btn btn-success btn-sm""");
            BeginWriteAttribute("href", " href=\"", 4405, "\"", 4441, 2);
            WriteAttributeValue("", 4412, "/admin/onay/", 4412, 12, true);
#nullable restore
#line 74 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
WriteAttributeValue("", 4424, item.OrderNumber, 4424, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Teslim Et</a>\r\n                                                </p>\r\n");
#nullable restore
#line 76 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                   
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                         if (item.OrderState == EnumOrderState.cancel)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <p class=""lead text-danger fw-normal mb-0"">

                                                <i class=""fa fa-times text-danger"" aria-hidden=""true""></i>  İptal Edildi
                                            </p>
");
#nullable restore
#line 84 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                       


                                    </div>
                                </div>
                                <div class=""col-md-2 d-flex justify-content-center"">
                                    <div>
                                        <p class=""small text-black mb-4 pb-2"">Sipariş Detayları</p>
                                        <a class=""btn btn-primary dropdown-toggle"" data-toggle=""collapse""");
            BeginWriteAttribute("href", " href=\"", 5499, "\"", 5524, 2);
            WriteAttributeValue("", 5506, "#", 5506, 1, true);
#nullable restore
#line 94 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
WriteAttributeValue("", 5507, item.OrderNumber, 5507, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Sipariş Detayları </a>
                                    </div>
                                </div>
                            </div>
                            <br><br>

                            <div class=""container col-md-11"">
                                <div class=""collapse multi-collapse""");
            BeginWriteAttribute("id", " id=\"", 5915, "\"", 5937, 1);
#nullable restore
#line 101 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
WriteAttributeValue("", 5920, item.OrderNumber, 5920, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div style=\"border:1px solid lightgrey;\" class=\"card mb-4\">\r\n");
#nullable restore
#line 103 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                         foreach (var orders in item.OrderItems)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""card-body p-4"">
                                                <div class=""row align-items-center"">
                                                    <div class=""col-md-2"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01094be2de36fd3fa3f56690540ca1736476760f16602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6491, "~/img/", 6491, 6, true);
#nullable restore
#line 109 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
AddHtmlAttributeValue("", 6497, orders.ImageUrl, 6497, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""col-md-4 d-flex justify-content-center"">
                                                        <div>
                                                            <p class=""small text-black mb-4 pb-2"">Ürün Adı</p>
                                                            <p class=""lead fw-normal text-primary mb-0"">");
#nullable restore
#line 115 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                                                   Write(orders.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>
                                                    <div class=""col-md-2 d-flex justify-content-center"">
                                                        <div>
                                                            <p class=""small text-black mb-4 pb-2"">Ürün Rengi</p>
                                                            
                                                        </div>
                                                    </div>
                                                    <div class=""col-md-2 d-flex justify-content-center"">
                                                        <div>
                                                            <p class=""small text-black mb-4 pb-2"">Ürün Adeti</p>
                                                            <p class=""lead text-primary fw-normal mb-0"">");
#nullable restore
#line 127 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                                                   Write(orders.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>
                                                    <div class=""col-md-1 d-flex justify-content-center"">
                                                        <div>
                                                            <p class=""small text-black mb-4 pb-2"">Ürün Fiyatı</p>
                                                            <p class=""lead text-primary fw-normal mb-0"">");
#nullable restore
#line 133 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                                                                                   Write(orders.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                                    </div>\r\n\r\n                                                </div>\r\n\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 141 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 150 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\Orders.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01094be2de36fd3fa3f56690540ca1736476760f22446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
