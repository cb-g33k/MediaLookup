#pragma checksum "C:\Users\cebean\source\repos\MediaTracker\MediaTracker\Views\Home\Music.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d2bb19ac304b142a014ca7c4be7ca4c89a1306f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Music), @"mvc.1.0.view", @"/Views/Home/Music.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Music.cshtml", typeof(AspNetCore.Views_Home_Music))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2bb19ac304b142a014ca7c4be7ca4c89a1306f", @"/Views/Home/Music.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841f0d30190d55c1b3c9311a4896333e0248f5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Music : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\cebean\source\repos\MediaTracker\MediaTracker\Views\Home\Music.cshtml"
  
    ViewData["Title"] = "Music";

#line default
#line hidden
            BeginContext(43, 376, true);
            WriteLiteral(@"
<h2>Music</h2>
<table id=""fill"" style=""position: relative; top: 0; bottom: 0; left: 0; right: 0;"">
    <tr style=""height: 25%;"">
        <td style=""padding-left:10px; padding-right:10px;"">Name</td>
        <td style=""padding-left:10px; padding-right:10px;"">Release Date</td>
        <td style=""padding-left:10px; padding-right:10px;"">Image</td>
    </tr>
</table>

");
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
