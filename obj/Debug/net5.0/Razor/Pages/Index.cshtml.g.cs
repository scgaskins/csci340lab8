#pragma checksum "C:\Users\sammy\Documents\Classes\2021-2022\FallSemester\Databases\csci340lab8\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a821f905466778560089276cd4908e6e22b98a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(csci340lab8.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace csci340lab8.Pages
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
#line 1 "C:\Users\sammy\Documents\Classes\2021-2022\FallSemester\Databases\csci340lab8\Pages\_ViewImports.cshtml"
using csci340lab8;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a821f905466778560089276cd4908e6e22b98a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b229b7e54b5b36a8fc408ae62f6d6ebfd747a28", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sammy\Documents\Classes\2021-2022\FallSemester\Databases\csci340lab8\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-auto"">
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 mb-4 "">
                <p class=""card-text"">
                    Clown College is a project based
                    on the Razor Pages tutorial provided
                    by Microsoft.
                </p>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 d-flex flex-column position-static"">
                <p class=""card-text mb-auto"">
                    You can build the application by following the steps in a series of tutorials.
                </p>
                <p>
                    <a href=""https://docs.microsoft.com/aspnet/core/data/ef-rp/intro"" class=""stretched-link"">See the tutorial</a>
                </p>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
   ");
            WriteLiteral(@"         <div class=""col p-4 d-flex flex-column"">
                <p class=""card-text mb-auto"">
                    You can download the completed turorial from GitHub.
                </p>
                <p>
                    <a href=""https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/data/ef-rp/intro/samples"" class=""stretched-link"">See project source code</a>
                </p>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
