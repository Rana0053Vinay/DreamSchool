#pragma checksum "D:\Pratics Projects\DreamSchool\DreamSchool\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b99bdc236afd25d2ced68258950fec620e894d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contacts.cshtml", typeof(AspNetCore.Views_Home_Contacts))]
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
#line 1 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\_ViewImports.cshtml"
using DreamSchool;

#line default
#line hidden
#line 2 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\_ViewImports.cshtml"
using DreamSchool.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99bdc236afd25d2ced68258950fec620e894d78", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2595ba6fe1613c42b509338a5e4c0d13924d2550", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\Home\Contacts.cshtml"
  
    ViewBag.Title = "Contacts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 1114, true);
            WriteLiteral(@"
<!-- page title -->
<section class=""page-title-section overlay"" data-background=""/images/backgrounds/page-title.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <ul class=""list-inline custom-breadcrumb"">
                    <li class=""list-inline-item""><a class=""h2 text-primary font-secondary"" href=""#"">Contact Us</a></li>
                    <li class=""list-inline-item text-white h3 font-secondary""></li>
                </ul>
                <p class=""text-lighten"">Do you have other questions? Don't worry, there aren't any dumb questions. Just fill out the form below and we'll get back to you as soon as possible.</p>
            </div>
        </div>
    </div>
</section>
<!-- /page title -->
<!-- contact -->
<section class=""section bg-gray"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2 class=""section-title"">Contact Us</h2>
            </div>
        </div>
  ");
            WriteLiteral("      <div class=\"row\">\r\n            <div class=\"col-lg-7 mb-4 mb-lg-0\">\r\n                ");
            EndContext();
            BeginContext(1203, 613, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "881abb16636447e0bcc4c13894fea2ba", async() => {
                BeginContext(1220, 589, true);
                WriteLiteral(@"
                    <input type=""text"" class=""form-control mb-3"" id=""name"" name=""name"" placeholder=""Your Name"">
                    <input type=""email"" class=""form-control mb-3"" id=""mail"" name=""mail"" placeholder=""Your Email"">
                    <input type=""text"" class=""form-control mb-3"" id=""subject"" name=""subject"" placeholder=""Subject"">
                    <textarea name=""message"" id=""message"" class=""form-control mb-3"" placeholder=""Your Message""></textarea>
                    <button type=""submit"" value=""send"" class=""btn btn-primary"">SEND MESSAGE</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1816, 1166, true);
            WriteLiteral(@"
            </div>
            <div class=""col-lg-5"">
                <p class=""mb-5"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Velit recusandae voluptates doloremque veniam temporibus porro culpa ipsa, nisi soluta minima saepe laboriosam debitis nesciunt. Dolore, labore. Accusamus nulla sed cum aliquid exercitationem debitis error harum porro maxime quo iusto aliquam dicta modi earum fugiat, vel possimus commodi, deleniti et veniam, fuga ipsum praesentium. Odit unde optio nulla ipsum quae obcaecati! Quod esse natus quibusdam asperiores quam vel, tempore itaque architecto ducimus expedita</p>
                <a href=""tel:+8802057843248"" class=""text-color h5 d-block"">+880 20 5784 3248</a>
                <a href=""mailto:yourmail@email.com"" class=""mb-5 text-color h5 d-block"">yourmail@email.com</a>
                <p>71 Shelton Street<br>London WC2H 9JQ England</p>
            </div>
        </div>
    </div>
</section>
<!-- /contact -->
<!-- gmap -->
<section class=""section pt-0"">");
            WriteLiteral("\n    <!-- Google Map -->\r\n    <div id=\"map_canvas\" data-latitude=\"51.507351\" data-longitude=\"-0.127758\"></div>\r\n</section>\r\n<!-- /gmap -->\r\n\r\n");
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
