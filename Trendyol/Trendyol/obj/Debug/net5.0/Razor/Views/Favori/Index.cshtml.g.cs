#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d053976fae2933aaf9dfad46a86d00d55c0a7113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favori_Index), @"mvc.1.0.view", @"/Views/Favori/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d053976fae2933aaf9dfad46a86d00d55c0a7113", @"/Views/Favori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0359f9a8bb00d1f3bffb678c26dfe4f04833ce4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Favori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Favori>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("270"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TrendyolLayout.cshtml";

#line default
#line hidden
#nullable disable
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
<!--Main Container Start-->
<!--Main Container Start-->

<style>
    .checked{
       color: orange;
    }
</style>


<div class=""container col-10   mt");
            WriteLiteral(@"-4"" style=""min-height: 500px;"">

    <!--Favorilerim Rowu Start-->


    <div class=""row d-flex justify-content-between align-items-center"">

        <div class=""col-9"">
            <div class=""header-left-section text-decoration-none"">
                <a class=""active text-decoration-none""
                   style="":hover{background-color: darkorange;}"" href=""#"">
                    <i style=""color: darkorange;""
                       class=""fa-regular fa-heart mx-2 fs-5 text-decoration-none""></i><span style=""color: darkorange;font-weight: bold;font-style: italic;font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; ""
                                                                                            class=""fs-5 text-decoration-none"">Favorilerim</span>
                </a>
            </div>


        </div>
        <div class=""col-3"">

            <div class=""header-right-section mt-2"">
                <div class=""searchbox-wrapper"">
                  ");
            WriteLiteral("  <div class=\"click-outside d-flex \">\r\n                        <input style=\"z-index: 1;\" type=\"text\" size=\"30%\"\r\n                               class=\"search-input input-passive\" placeholder=\"Favorilerimde ara\"");
            BeginWriteAttribute("value", " value=\"", 2370, "\"", 2378, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""search-icon""></i>

                        <div class=""d-flex justify-content-center align-items-center"">
                            <button style=""background-color: orange;position: absolute;z-index: 2;margin-right: 2%;font-size: xx-small;""
                                    class=""btn btn-primary btn-sm"" type=""submit"">
                                <i class=""fas fa-search""></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>

        </div>



    </div>


    <!--Favorilerim Rowu END-->





    <hr class=""mt-3 mb-3"">


    <!--Tüm Favoriler Yıldızlı Ürünler Rowu Start-->

    <div class=""row d-flex justify-content-start mt-4"">

        <div class=""col-3 gx-2 d-flex justify-content-center align-items-center""
             style=""border-radius: 8px;margin-left: 10px;width: 12%;height: 40px;"">

            <button style=""color: darkorange;   border-color: darkorange; "" cl");
            WriteLiteral(@"ass=""btn btn-outline-light bg-light"">
                <i style=""color: darkorange;margin-right: 4px;"" class=""fa-regular fa-heart""></i> Tüm Favorilerim
            </button>


        </div>
        <div class=""col-1 gx-2 d-flex justify-content-center align-items-center""
             style=""border-radius: 8px;margin-left: 10px;width: 12%;height: 40px;"">

            <button style=""color: blue;   border-color: blue; "" class=""btn btn-outline-light bg-light"">
                <i style=""color: blue;margin-right: 4px;"" class=""fa-regular fa-star""></i> Yıldızlı Ürünler
            </button>


        </div>
        <div class=""col-1 gx-2 d-flex justify-content-center align-items-center""
             style=""border-radius: 8px;margin-left: 10px;width: 12%;height: 40px;"">

            <button style=""color: red;   border-color: red; "" class=""btn btn-outline-light bg-light"">
                <i style=""color: red;margin-right: 4px;"" class=""fa-solid fa-arrow-trend-down""></i> Fiyatı Düşenler
            </b");
            WriteLiteral(@"utton>


        </div>
        <div class=""col-1 gx-2 d-flex justify-content-center align-items-center""
             style=""border-radius: 8px;margin-left: 10px;width: 12%;height: 40px;"">

            <button style=""color: darkorange;   border-color: darkorange; "" class=""btn btn-outline-light bg-light"">
                <i style=""color: darkorange;margin-right: 4px;"" class=""fa-solid fa-ticket""></i> Kuponlu Ürünler
            </button>


        </div>





    </div>

    <hr class=""mt-5 mb-5"">


    <!--Tüm Favoriler Yıldızlı Ürünler Rowu END-->
    <!--Ürün Kartları Rowu Start-->


    <div class=""row"">

");
#nullable restore
#line 135 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
         foreach (var item in Model.FavoriItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                <div class=\"card\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d053976fae2933aaf9dfad46a86d00d55c0a711311966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5255, "~/img/", 5255, 6, true);
#nullable restore
#line 139 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
AddHtmlAttributeValue("", 5261, item.Product.ProductImageUrl1, 5261, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-title\"> <b> ");
#nullable restore
#line 141 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                                              Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
#nullable restore
#line 141 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                                                                            Write(item.Product.ProductClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                        <p class=\"card-text d-flex justify-content-start align-items-center\">\r\n\r\n\r\n                           \r\n");
#nullable restore
#line 148 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                             if (item.Product.StarNumber == 0)
                            {
                               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col"">
                                    <span style=""margin-right: 5px;"">
                                        0.0
                                    </span>
                                    <i class=""fas fa-star ""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <span><small style=""margin-left: 5px;"">(335)</small></span>
                                    <span><i class=""fas fa-camera"" style=""margin-left: 5px;""></i></span>
                                </div>
");
#nullable restore
#line 163 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                             if (item.Product.StarNumber == 1 && item.Product.StarNumber < 21)
                            {
                               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col"">
                                    <span style=""margin-right: 5px;"">
                                        1.0
                                    </span>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <span><small style=""margin-left: 5px;"">(335)</small></span>
                            <span><i class=""fas fa-camera"" style=""margin-left: 5px;""></i></span>
                                </div>
");
#nullable restore
#line 179 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 181 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                             if (item.Product.StarNumber > 20 && item.Product.StarNumber < 41)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col"">
                                    <span style=""margin-right: 5px;"">
                                        2.0
                                    </span>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                    <span><small style=""margin-left: 5px;"">(335)</small></span>
                                    <span><i class=""fas fa-camera"" style=""margin-left: 5px;""></i></span>
                                </div>
");
#nullable restore
#line 196 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 198 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                             if (item.Product.StarNumber > 40 && item.Product.StarNumber < 61)
                            {
                               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col"">
                                    <span style=""margin-right: 5px;"">
                                        3.0
                                    </span>
                                    <i style=""font-size:14px;"" class=""fas fa-star checked""></i>
                                    <i style=""font-size:14px;"" class=""fas fa-star checked""></i>
                                    <i style=""font-size:14px;"" class=""fas fa-star checked""></i>
                                    <i style=""font-size:14px;"" class=""fas fa-star""></i>
                                    <i style=""font-size:14px;"" class=""fas fa-star""></i>
                                     <span><small style=""margin-left: 5px;"">(335)</small></span>
                            <span><i class=""fas fa-camera"" style=""margin-left: 5px;""></i></span>
                                </div>
");
#nullable restore
#line 213 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 215 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                             if (item.Product.StarNumber == 60 && item.Product.StarNumber < 81)
                            {
                              

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col"">
                                    <span style=""margin-right: 5px;"">
                                        4.0
                                    </span>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star""></i>
                                    <span><small style=""margin-left: 5px;"">(335)</small></span>
                                    <span><i class=""fas fa-camera"" style=""margin-left: 5px;""></i></span>
                                </div>
");
#nullable restore
#line 230 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 231 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                             if (item.Product.StarNumber == 80)
                            {
                              

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col"">
                                    <span style=""margin-right: 5px;"">
                                        5.0
                                    </span>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <i class=""fas fa-star checked""></i>
                                    <span><small style=""margin-left: 5px;"">(335)</small></span>
                                    <span><i class=""fas fa-camera"" style=""margin-left: 5px;""></i></span>
                                </div>
");
#nullable restore
#line 246 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                           

                           

                        </p>



                        <div class=""d-flex align-items-center justify-content-between"">


                            <a href=""#"">


                                <div class=""dropdown open"">
                                    <button style=""font-size: 100%;"" class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""triggerId""
                                        data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        L
                                    </button>
                                    <div class=""dropdown-menu"" aria-labelledby=""triggerId"">
                                        <button class=""dropdown-item"" href=""#"">S</button>
                                        <button class=""dropdown-item"" href=""#"">M</button>
                                        <button class=""dropdown-item"" href=""#"">L</button>
                ");
            WriteLiteral(@"                        <button class=""dropdown-item"" href=""#"">XL</button>
                                        <button class=""dropdown-item"" href=""#"">XXL</button>


                                    </div>
                                </div>

                            </a>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d053976fae2933aaf9dfad46a86d00d55c0a711324708", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 13113, "\"", 13137, 1);
#nullable restore
#line 281 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"
WriteAttributeValue("", 13121, item.Product.Id, 13121, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <input type=""hidden"" name=""quantity"" value=""1"" />
                                <input type=""hidden"" name=""size"" value=""XL"" />
                                <button type=""submit"" class=""btn btn-lg w-100 sepetbuton text-white"">
                                    <a");
                BeginWriteAttribute("name", " name=\"", 13447, "\"", 13454, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"border-color: darkorange;color: darkorange;font-size: 75%;\"");
                BeginWriteAttribute("id", " id=\"", 13522, "\"", 13527, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                   class=\"btn btn-outline-light\" >Sepete Ekle</a>\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                     \r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 297 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Favori\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      






    </div>

    <!--Ürün Kartları Rowu Start-->




</div>


<!--Main Container END-->







<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.1.0/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz""
        crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Favori> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
