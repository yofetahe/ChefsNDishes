#pragma checksum "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db49541af163ffe60957f867d20fd689db2cc7fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChefDish_DishesList), @"mvc.1.0.view", @"/Views/ChefDish/DishesList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChefDish/DishesList.cshtml", typeof(AspNetCore.Views_ChefDish_DishesList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db49541af163ffe60957f867d20fd689db2cc7fa", @"/Views/ChefDish/DishesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02df4c1f1661381a2cee8566181194bf8cf32afb", @"/Views/_ViewImports.cshtml")]
    public class Views_ChefDish_DishesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 434, true);
            WriteLiteral(@"
<div class=""header"">
    <a href=""/"">Chefs</a> | Dishes
</div>

<a href=""GetDishAddForm"" class=""btn btn-primary"">Add a Dish</a>

<p class=""title"">Yum, take a look at our tasty dishes!</p>

<table class=""table table-primary table-hover"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
         foreach(var d in Model)
        {

#line default
#line hidden
            BeginContext(498, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(559, 6, false);
#line 25 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
               Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(565, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(633, 22, false);
#line 28 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
               Write(d.PreparedBy.FristName);

#line default
#line hidden
            EndContext();
            BeginContext(655, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(657, 21, false);
#line 28 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
                                       Write(d.PreparedBy.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(678, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(746, 11, false);
#line 31 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
               Write(d.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(757, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(825, 10, false);
#line 34 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
               Write(d.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(835, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ChefNDishes\Views\ChefDish\DishesList.cshtml"
        }

#line default
#line hidden
            BeginContext(890, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
