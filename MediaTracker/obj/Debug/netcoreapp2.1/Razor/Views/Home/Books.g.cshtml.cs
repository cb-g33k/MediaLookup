#pragma checksum "C:\Users\cebean\source\repos\MediaTracker\MediaTracker\Views\Home\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24bd9f2bfeef9bb2e22ecdab65d8fabae48103a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Books), @"mvc.1.0.view", @"/Views/Home/Books.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Books.cshtml", typeof(AspNetCore.Views_Home_Books))]
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
#line 1 "C:\Users\cebean\source\repos\MediaTracker\MediaTracker\Views\_ViewImports.cshtml"
using MediaTracker;

#line default
#line hidden
#line 2 "C:\Users\cebean\source\repos\MediaTracker\MediaTracker\Views\_ViewImports.cshtml"
using MediaTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24bd9f2bfeef9bb2e22ecdab65d8fabae48103a", @"/Views/Home/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841f0d30190d55c1b3c9311a4896333e0248f5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\cebean\source\repos\MediaTracker\MediaTracker\Views\Home\Books.cshtml"
  
    ViewData["Title"] = "Books";

#line default
#line hidden
            BeginContext(43, 146, true);
            WriteLiteral("\r\n<h2>Books</h2>\r\n<table id=\"fill\">\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>Release Date</td>\r\n        <td>Image</td>\r\n    </tr>\r\n</table>\r\n");
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