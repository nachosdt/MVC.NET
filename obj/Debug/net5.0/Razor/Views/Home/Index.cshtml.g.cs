#pragma checksum "C:\Users\elesp\Desktop\C#\MVC.NET\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2282e96732218f1fac2f12bba7b44d350dbd9a7b"
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
#line 1 "C:\Users\elesp\Desktop\C#\MVC.NET\Views\_ViewImports.cshtml"
using Clientes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elesp\Desktop\C#\MVC.NET\Views\_ViewImports.cshtml"
using Clientes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2282e96732218f1fac2f12bba7b44d350dbd9a7b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d580f61b3253ded3bf36e9e9e910957fdfd5af3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\elesp\Desktop\C#\MVC.NET\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-3 mt-5 font-weight-bold"">App web en .NET MVC</h1>
    <img class=""mt-5"" src=""e-intelligent.svg"" alt=""Logo E-Intelligence"">
    <p class=""mt-5"">Prueba para e-intelligent realizada por Nacho Sáenz de Tejada.</p>
    <div class=""d-flex flex-row justify-content-center align-items-center mt-4"">        
        <a href=""https://www.linkedin.com/in/nachosaenzdetejada"" target=""_blank"">
            <img class=""mr-2"" style=""width: 57px;"" src=""linkedin.png""");
            BeginWriteAttribute("alt", " alt=\"", 552, "\"", 558, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n        <a href=\"https://github.com/nachosdt\" target=\"_blank\">\r\n            <img class=\"ml-2\" style=\"width: 50px;\" src=\"github.png\"");
            BeginWriteAttribute("alt", " alt=\"", 707, "\"", 713, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n    </div>    \r\n</div>\r\n");
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
