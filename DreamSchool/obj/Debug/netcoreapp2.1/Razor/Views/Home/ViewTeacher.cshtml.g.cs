#pragma checksum "D:\Pratics Projects\DreamSchool\DreamSchool\Views\Home\ViewTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14ad70126473c178976779f6b0ef2ac54e2c3cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewTeacher), @"mvc.1.0.view", @"/Views/Home/ViewTeacher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewTeacher.cshtml", typeof(AspNetCore.Views_Home_ViewTeacher))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14ad70126473c178976779f6b0ef2ac54e2c3cc", @"/Views/Home/ViewTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2595ba6fe1613c42b509338a5e4c0d13924d2550", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h2 text-primary font-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/ViewCourse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\Home\ViewTeacher.cshtml"
  
    ViewBag.Title = "ViewTeacher";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 323, true);
            WriteLiteral(@"
<!-- page title -->
<section class=""page-title-section overlay"" data-background=""/images/backgrounds/page-title.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <ul class=""list-inline custom-breadcrumb"">
                    <li class=""list-inline-item"">");
            EndContext();
            BeginContext(415, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a49fd8517441b8bc48b623573589e2", async() => {
                BeginContext(479, 11, true);
                WriteLiteral("Our Teacher");
                EndContext();
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
            BeginContext(494, 4793, true);
            WriteLiteral(@"</li>
                    <li class=""list-inline-item text-white h3 font-secondary nasted"">John Doe</li>
                </ul>
                <p class=""text-lighten"">Our courses offer a good compromise between the continuous assessment favoured by some universities and the emphasis placed on final exams by others.</p>
            </div>
        </div>
    </div>
</section>
<!-- /page title -->
<!-- teacher details -->
<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 mb-5"">
                <img class=""img-fluid w-100"" src=""/images/teachers/teacher-1.jpg"" alt=""teacher"">
            </div>
            <div class=""col-md-6 mb-5"">
                <h3>John Doe</h3>
                <h6 class=""text-color"">Computer Science</h6>
                <p class=""mb-5"">
                    Lorem ipsum dolor, sit amet consectetur adipisicing elit. Cumque accusamus tenetur ea harum
                    delectus ab consequatur excepturi, odit qui ");
            WriteLiteral(@"in quo quia voluptate nam optio, culpa aspernatur. Error placeat
                    iusto officia voluptas quae.
                </p>
                <div class=""row"">
                    <div class=""col-md-6 mb-5 mb-md-0"">
                        <h4 class=""mb-4"">CONTACT INFO:</h4>
                        <ul class=""list-unstyled"">
                            <li class=""mb-3""><a class=""text-color"" href=""mailto:johndoe@email.com""><i class=""ti-email mr-2""></i>johndoe@email.com</a></li>
                            <li class=""mb-3""><a class=""text-color"" href=""callto:+120345876""><i class=""ti-mobile mr-2""></i>+120 345 876</a></li>
                            <li class=""mb-3""><a class=""text-color"" href=""#""><i class=""ti-facebook mr-2""></i>john Doe</a></li>
                            <li class=""mb-3""><a class=""text-color"" href=""#""><i class=""ti-twitter-alt mr-2""></i>john Doe</a></li>
                            <li class=""mb-3""><a class=""text-color"" href=""#""><i class=""ti-skype mr-2""></i>john Doe</a></li>");
            WriteLiteral(@"
                            <li class=""mb-3""><a class=""text-color"" href=""#""><i class=""ti-world mr-2""></i>johnDoe.com</a></li>
                            <li class=""mb-3"">
                                <a class=""text-color"" href=""#"">
                                    <i class=""ti-location-pin mr-2""></i>1313 Boulevard
                                    Cremazie,Quebec
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-md-6"">
                        <h4 class=""mb-4"">SUMMARY OF ACTIVITIES/INTERESTS</h4>
                        <ul class=""list-unstyled"">
                            <li class=""mb-3"">Computer Networking</li>
                            <li class=""mb-3"">Computer Security</li>
                            <li class=""mb-3"">Human Computer Interfacing</li>
                        </ul>
                    </div>
                </div>
            </div>
            <di");
            WriteLiteral(@"v class=""col-12"">
                <h4 class=""mb-4"">BIOGRAPHY</h4>
                <p class=""mb-5"">
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et
                    dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                    commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
                    nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit
                    anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque
                    laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto.
                </p>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-12"">
                <h4 class");
            WriteLiteral(@"=""mb-4"">COURSES</h4>
            </div>
            <!-- course item -->
            <div class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card p-0 border-primary rounded-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/courses/course-4.jpg"" alt=""course thumb"">
                    <div class=""card-body"">
                        <ul class=""list-inline mb-2"">
                            <li class=""list-inline-item""><i class=""ti-calendar mr-1 text-color""></i>02-14-2018</li>
                            <li class=""list-inline-item""><a class=""text-color"" href=""#"">Humanities</a></li>
                        </ul>
                        ");
            EndContext();
            BeginContext(5287, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef287d3550ed4f658bb1d13f5bac7b67", async() => {
                BeginContext(5315, 104, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Complete Freelancing</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5423, 284, true);
            WriteLiteral(@"
                        <p class=""card-text mb-4"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor
                            incididunt ut labore et dolore magna.
                        </p>
                        ");
            EndContext();
            BeginContext(5707, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b620da32c80437699f4a05fb50b8136", async() => {
                BeginContext(5766, 9, true);
                WriteLiteral("Apply now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5779, 729, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <!-- course item -->
            <div class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card p-0 border-primary rounded-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/courses/course-5.jpg"" alt=""course thumb"">
                    <div class=""card-body"">
                        <ul class=""list-inline mb-2"">
                            <li class=""list-inline-item""><i class=""ti-calendar mr-1 text-color""></i>02-14-2018</li>
                            <li class=""list-inline-item""><a class=""text-color"" href=""#"">Humanities</a></li>
                        </ul>
                        ");
            EndContext();
            BeginContext(6508, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d1b8ff472d488bb65a9150276321ae", async() => {
                BeginContext(6536, 99, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Branding Design</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6639, 284, true);
            WriteLiteral(@"
                        <p class=""card-text mb-4"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor
                            incididunt ut labore et dolore magna.
                        </p>
                        ");
            EndContext();
            BeginContext(6923, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2641e0c86e70438ea935947470e4c70d", async() => {
                BeginContext(6982, 9, true);
                WriteLiteral("Apply now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6995, 729, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <!-- course item -->
            <div class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card p-0 border-primary rounded-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/courses/course-6.jpg"" alt=""course thumb"">
                    <div class=""card-body"">
                        <ul class=""list-inline mb-2"">
                            <li class=""list-inline-item""><i class=""ti-calendar mr-1 text-color""></i>02-14-2018</li>
                            <li class=""list-inline-item""><a class=""text-color"" href=""#"">Humanities</a></li>
                        </ul>
                        ");
            EndContext();
            BeginContext(7724, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "004fa742c43747be9eb45462ca926e66", async() => {
                BeginContext(7752, 94, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Art Design</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7850, 284, true);
            WriteLiteral(@"
                        <p class=""card-text mb-4"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor
                            incididunt ut labore et dolore magna.
                        </p>
                        ");
            EndContext();
            BeginContext(8134, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2366ebb0f1e7410999d415267e2abdc6", async() => {
                BeginContext(8193, 9, true);
                WriteLiteral("Apply now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8206, 145, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- /teacher details -->\r\n\r\n\r\n");
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
