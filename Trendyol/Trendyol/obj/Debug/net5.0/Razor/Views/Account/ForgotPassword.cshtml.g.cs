#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Account\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c7d6b659914f8d00ca663fca74b1c9955b2bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPassword), @"mvc.1.0.view", @"/Views/Account/ForgotPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c7d6b659914f8d00ca663fca74b1c9955b2bee", @"/Views/Account/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0359f9a8bb00d1f3bffb678c26dfe4f04833ce4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ForgotPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Trendyol\Trendyol\Views\Account\ForgotPassword.cshtml"
  
    ViewData["Title"] = "ForgotPassword";
    Layout = "~/Views/Shared/_TrendyolLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css'>
<style>
    .login {
        margin-top: 15px;
        color: darkorange;
    }
</style>
<br />
<h4 class=""text-center"">
    Merhaba,
</h4>
<h6 class=""text-center"">Trendyol’a giriş yap veya hesap oluştur, indirimleri kaçırma!</h6>
<div></div>
<div class=""card container col-md-4"">
    <div class=""row"">
        <div class=""col-md-12 text-center login "">Şifremi Unuttum </div>
       
    </div>
    <div class=""card-body"">

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c7d6b659914f8d00ca663fca74b1c9955b2bee5066", async() => {
                WriteLiteral(@"
            <br />
            <h6 class=""card-title"">E Posta</h6>
            <span  class=""text-danger""></span>
            <input name=""email"" class=""form-control"" />
            <br />
                   
            <input style=""background-color:darkorange;color:wheat"" type=""submit"" value=""Giriş"" class=""btn btn-block w-100 btn-primary"">
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <br />

        <div class=""row"">

            <div class=""col-md-6 "">

                <div class="" container"" style=""height:35px"">
                    <div>
                        <div class=""row"">
                            <div class=""col-4"" style=""width:30px;height:30px;background-color:royalblue;font-weight:bold"">
                                <i style=""color:white;"" class='fa fa-facebook'></i>
                            </div>
                            <div class=""col-8"">
                                <span style=""font-size:15px;""> Facebook</span>
                                <span style=""font-size:12px;position:absolute;margin-top:18px;margin-left:-63px;"" class=""text-muted"">ile Giriş Yap</span>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <div class=""col-md-6 "">

                <div class="" container"" style=""height:35px"">
                    <div>
     ");
            WriteLiteral(@"                   <div class=""row"">
                            <div class=""col-4"" style=""width:30px;height:30px;background-color:red;font-weight:bold"">

                                <i style=""color:white;"" class=""fa-solid fa-g""></i>
                            </div>
                            <div class=""col-8"">
                                <span style=""font-size:15px;""> Facebook</span>
                                <span style=""font-size:12px;position:absolute;margin-top:18px;margin-left:-63px;"" class=""text-muted"">ile Giriş Yap</span>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
