#pragma checksum "C:\Users\jeffk.DESKTOP-CE8H4QM\Desktop\HazmatUpdated\SeniorProject\Views\Home\ManualSubmission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "092a92c3c95ee1d1cc1d049a43f999bb39902dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManualSubmission), @"mvc.1.0.view", @"/Views/Home/ManualSubmission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ManualSubmission.cshtml", typeof(AspNetCore.Views_Home_ManualSubmission))]
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
#line 1 "C:\Users\jeffk.DESKTOP-CE8H4QM\Desktop\HazmatUpdated\SeniorProject\Views\_ViewImports.cshtml"
using SeniorProject;

#line default
#line hidden
#line 2 "C:\Users\jeffk.DESKTOP-CE8H4QM\Desktop\HazmatUpdated\SeniorProject\Views\_ViewImports.cshtml"
using SeniorProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"092a92c3c95ee1d1cc1d049a43f999bb39902dac", @"/Views/Home/ManualSubmission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fba562bdd24dcbad35969f440336d1e3535e88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManualSubmission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(105, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(134, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe2052bda9f747ba8ead1d501954a994", async() => {
                BeginContext(140, 8, true);
                WriteLiteral("\r\n    \r\n");
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
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(157, 2835, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e72826c3f2de4c658fd93671ada17285", async() => {
                BeginContext(163, 1603, true);
                WriteLiteral(@"

    <div class=""jumbotron"">
        <h1>Manual Submission Page</h1>

        <p>When a scanner is down or a scan was missed. Use this page to manual submit scanner entries </p>
    </div>
    <div class=""input-group mb-3"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"" id=""basic-addon1"">Object Id</span>
        </div>
        <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1"">
    </div>
    <div class=""input-group mb-3"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"" id=""basic-addon1"">Weight</span>
        </div>
        <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1"">
    </div>
    <div class=""input-group mb-3"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"" id=""basic-addon1"">TimeStamp</span>
        </div>
        <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1"">
    </div>
    <div class=""dropdown"">");
                WriteLiteral(@"
        <button class=""btn btn-default orange-btn dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
            <span class=""caret""></span>
            Object Type
        </button>
        <ul class=""dropdown-menu list "">
            <li><a href="""">Paint Can</a></li>
            <li><a href="""">Oil</a></li>
            <li><a href="""">Lead</a></li>
            <li><a href="""">Gasoline</a></li>
            <li><a href="""">Engine Cleaner</a></li>
        </ul>
    </div>
    <button type=""button"" class=""btn btn-primary btn-lg btn-block"">Add Scanner</button>
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
            BeginContext(2992, 11, true);
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
