#pragma checksum "E:\labs\c#\web\web_project\web_project\Views\Places\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2d94eb7b0bcc0d5d4a08af6d546359deabdac52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Places_Index), @"mvc.1.0.view", @"/Views/Places/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Places/Index.cshtml", typeof(AspNetCore.Views_Places_Index))]
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
#line 1 "E:\labs\c#\web\web_project\web_project\Views\_ViewImports.cshtml"
using web_project;

#line default
#line hidden
#line 2 "E:\labs\c#\web\web_project\web_project\Views\_ViewImports.cshtml"
using web_project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d94eb7b0bcc0d5d4a08af6d546359deabdac52", @"/Views/Places/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e98a91d07db1d7eb626e2a132c3e85bb8b5bd6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Places_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\labs\c#\web\web_project\web_project\Views\Places\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(69, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "961799051e164e31b681981504d3258a", async() => {
                BeginContext(75, 139, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>Index Page</title>\r\n    ");
                EndContext();
                BeginContext(214, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24503179555549dc99f3ae7c9bcb4d7d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(260, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(269, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(271, 3447, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db60a52901e5474db7c2efed1f36a630", async() => {
                BeginContext(277, 3434, true);
                WriteLiteral(@"
<div id=""slides"" class=""carousel slide"" data-ride=""carousel"">
    <ul class=""carousel-indicators"">
        <li data-target=""#slides"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#slides"" data-slide-to=""1""></li>
        <li data-target=""#slides"" data-slide-to=""2""></li>
    </ul>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img src=""/img/background.png"">
            <div class=""carousel-caption"">
                <h1 class=""display-2"">Bootstrap</h1>
                <h3>Some Text</h3>
                <button type=""button"" class=""btn btn-outline-liight btn-lg"">View</button>
                <button type=""button"" class=""btn btn-primary btn-lg"">More</button>
            </div>
        </div>
        <div class=""carousel-item"">
            <img src=""/img/background2.png"">
            <div class=""carousel-caption"">
                <h1 class=""display-2"">Bootstrap</h1>
                <h3>Some Text</h3>
                <button type=""but");
                WriteLiteral(@"ton"" class=""btn btn-outline-liight btn-lg"">View</button>
                <button type=""button"" class=""btn btn-primary btn-lg"">More</button>
            </div>
        </div>
        <div class=""carousel-item"">
            <img src=""/img/background3.png"">
            <div class=""carousel-caption"">
                <h1 class=""display-2"">Bootstrap</h1>
                <h3>Some Text</h3>
                <button type=""button"" class=""btn btn-outline-liight btn-lg"">View</button>
                <button type=""button"" class=""btn btn-primary btn-lg"">More</button>
            </div>
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#slides"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#slides"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr");
                WriteLiteral(@"-only"">Next</span>
    </a>
</div>

<!--- Meet the team -->
<div class=""container-fluid padding"">
    <div class=""row welcome text-center"">
        <div class=""col-12"">
            <h1 class=""display-4"">Some Text</h1>
        </div>
        <hr>
    </div>
</div>

<!--- Cards -->
<div class=""container-fluid padding"">
    <div class=""row padding"">
        <div class=""col-md-4"">
            <div class=""card"">
                <img class=""card-img-top"" src=""/img/team3.png"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Some Title</h4>
                    <p class=""card-text"">Some Info</p>
                    <a href=""#"" class=""btn btn-outline-secondary"">Read More</a>
                </div>
            </div>
        </div>
    </div>
</div>

<!--- Connect -->
<div class=""container-fluid padding"">
    <div class=""row text-center padding"">
        <div class=""col-12"">
            <h2>Connect</h2>
        </div>

        <div class=""col-12 soc");
                WriteLiteral(@"ial padding"">
            <a href=""#""><i class=""fab fa-facebook""></i></a>
            <a href=""#""><i class=""fab fa-twitter""></i></a>
            <a href=""#""><i class=""fab fa-google-plus-g""></i></a>
            <a href=""#""><i class=""fab fa-instagram""></i></a>
            <a href=""#""><i class=""fab fa-youtube""></i></a>
        </div>
    </div>
</div>

");
                EndContext();
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
            EndContext();
            BeginContext(3718, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
