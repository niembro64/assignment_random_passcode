#pragma checksum "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fa457498d65a68ed0709cb4a337520d8b9f2ee9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\_ViewImports.cshtml"
using assignment_random_passcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\_ViewImports.cshtml"
using assignment_random_passcode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa457498d65a68ed0709cb4a337520d8b9f2ee9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ba74151749e31fd81010e3dd529986782743ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\Home\Index.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" string\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n\r\n    <h2>From ViewBag SessionName | ");
#nullable restore
#line 9 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\Home\Index.cshtml"
                              Write(ViewBag.SessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2>From ViewModel | ");
#nullable restore
#line 11 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\2.1\assignment_random_passcode\Views\Home\Index.cshtml"
                    Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<a href=\"/\">Generate</a>\r\n\r\n</div>\r\n");
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
