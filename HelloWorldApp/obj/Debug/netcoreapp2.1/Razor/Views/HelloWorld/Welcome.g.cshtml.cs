#pragma checksum "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\HelloWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5966fbfd5bb852ee5e352b9d02e0a96caa7a855d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Views_HelloWorld_Welcome))]
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
#line 1 "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\_ViewImports.cshtml"
using HelloWorldApp;

#line default
#line hidden
#line 2 "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\_ViewImports.cshtml"
using HelloWorldApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5966fbfd5bb852ee5e352b9d02e0a96caa7a855d", @"/Views/HelloWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79fa102beaa097ba5916390b6f8a71a5ece5047c", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\HelloWorld\Welcome.cshtml"
   
    ViewData[ "Title" ] = "Welcome";

#line default
#line hidden
            BeginContext(46, 26, true);
            WriteLiteral("<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 7 "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\HelloWorld\Welcome.cshtml"
     for (int i = 0; i <(int)ViewData["NumTimes"]; i++ )
    {

#line default
#line hidden
            BeginContext(137, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(150, 19, false);
#line 9 "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\HelloWorld\Welcome.cshtml"
       Write(ViewData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "C:\Users\Mikolaj\source\repos\HelloWorldApp\HelloWorldApp\Views\HelloWorld\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(183, 11, true);
            WriteLiteral("\r\n</ul>\r\n\r\n");
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
