#pragma checksum "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\Shared\NavPartition.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2313fc207a5f0b5ae54cece8c2f4c18494a9b830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NavPartition), @"mvc.1.0.view", @"/Views/Shared/NavPartition.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NavPartition.cshtml", typeof(AspNetCore.Views_Shared_NavPartition))]
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
#line 1 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\_ViewImports.cshtml"
using ChefNDishes;

#line default
#line hidden
#line 2 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\_ViewImports.cshtml"
using ChefNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2313fc207a5f0b5ae54cece8c2f4c18494a9b830", @"/Views/Shared/NavPartition.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02df4c1f1661381a2cee8566181194bf8cf32afb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NavPartition : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 950, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
  <div class=""container"">
  <a class=""navbar-brand"" href=""#"">Chef's N Dishes</a>
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarColor01"" aria-controls=""navbarColor01"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarColor01"">
    <ul class=""navbar-nav mr-auto"">
      <li class=""nav-item active"">
        <!-- <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a> -->
      </li>
      <li class=""nav-item"">
        <!-- <a class=""nav-link"" href=""#"">Features</a> -->
      </li>
      <li class=""nav-item"">
        <!-- <a class=""nav-link"" href=""#"">Pricing</a> -->
      </li>
      <li class=""nav-item"">
        <!-- <a class=""nav-link"" href=""#"">About</a> -->
      </li>
    </ul>
    ");
            EndContext();
            BeginContext(950, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10fb54a2f55546518e9ec2c1ed4eb171", async() => {
                BeginContext(989, 176, true);
                WriteLiteral("\r\n      <!-- <input class=\"form-control mr-sm-2\" type=\"text\" placeholder=\"Search\">\r\n      <button class=\"btn btn-secondary my-2 my-sm-0\" type=\"submit\">Search</button> -->\r\n    ");
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
            BeginContext(1172, 28, true);
            WriteLiteral("\r\n  </div>\r\n  </div>\r\n</nav>");
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
