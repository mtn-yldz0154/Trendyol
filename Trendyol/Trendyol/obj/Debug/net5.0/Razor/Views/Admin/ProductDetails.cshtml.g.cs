#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fe59ba83a87d210f75a7d64e67efc8fcc42f11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductDetails), @"mvc.1.0.view", @"/Views/Admin/ProductDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fe59ba83a87d210f75a7d64e67efc8fcc42f11", @"/Views/Admin/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0359f9a8bb00d1f3bffb678c26dfe4f04833ce4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
  
    ViewData["Title"] = "ProductDetails";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<br />
<h1>Ürün Detay</h1>
<hr />

<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css"" rel=""stylesheet"">


<div style=""margin-top: 70px;margin-bottom: 80px;margin-left:30px; "" class=""row"">
    <div class=""col-md-3"">
   
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3fe59ba83a87d210f75a7d64e67efc8fcc42f114344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 405, "~/img/", 405, 6, true);
#nullable restore
#line 19 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
AddHtmlAttributeValue("", 411, Model.ProductImageUrl1, 411, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9 mt-1\">\r\n        <h3 class=\"class=\" text-primary\" style=\"color:cornflowerblue\">\r\n            <p style=\"display:inline;font-size:18px;color:black\">Ürün Adı:</p> ");
#nullable restore
#line 23 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
                                                                          Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> <hr>\r\n        <h4 style=\"color:cornflowerblue\"><p style=\"display:inline;font-size:20px;color:black\">Ürün Rayonu:</p> ");
#nullable restore
#line 24 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
                                                                                                          Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rayonu</h4>\r\n            <div class=\"mb-5\">\r\n            <h4 style=\"color:cornflowerblue\">  <p style=\"display:inline;font-size:20px;color:black\">Ürün Bedeni:</p> ");
#nullable restore
#line 26 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
                                                                                                                Write(Model.ProductSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <br />\r\n            <h4 style=\"color:cornflowerblue\"> <p style=\"display:inline;font-size:20px;color:black\">Ürün Açıklaması:</p> ");
#nullable restore
#line 28 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
                                                                                                                   Write(Model.ProductDespcription.Substring(1,151));

#line default
#line hidden
#nullable disable
            WriteLiteral("....</h4>\r\n                \r\n            <h4 style=\"color:cornflowerblue\"> <p style=\"display:inline;font-size:20px;color:black\">Ürün Stok Adeti:</p> ");
#nullable restore
#line 30 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
                                                                                                                   Write(Model.ProductStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <br /><br />\r\n            <h4 style=\"color:darkblue\" >\r\n                <p style=\"display:inline;font-size:21px;color:black;\">Ürün Fiyatı:</p>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
               Write(Model.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-turkish-lira\" style=\"font-size:20px;\"></i>\r\n                </h4>\r\n                <br />\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1696, "\"", 1735, 2);
            WriteAttributeValue("", 1703, "/Product/ProductUpdate/", 1703, 23, true);
#nullable restore
#line 37 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
WriteAttributeValue("", 1726, Model.Id, 1726, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-lg mr-3\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1808, "\"", 1847, 2);
            WriteAttributeValue("", 1815, "/Product/ProductDelete/", 1815, 23, true);
#nullable restore
#line 38 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Admin\ProductDetails.cshtml"
WriteAttributeValue("", 1838, Model.Id, 1838, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-lg\">Delete</a></td>\r\n                </h6>\r\n            </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591