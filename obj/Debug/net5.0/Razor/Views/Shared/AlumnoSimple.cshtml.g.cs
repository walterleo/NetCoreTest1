#pragma checksum "D:\Users\Walter\Documents\Platzi\NetCore\NetCoreTest1\Views\Shared\AlumnoSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79906ebe46e36fe9a1c373a5d41e7a05b1f742c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AlumnoSimple), @"mvc.1.0.view", @"/Views/Shared/AlumnoSimple.cshtml")]
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
#line 1 "D:\Users\Walter\Documents\Platzi\NetCore\NetCoreTest1\Views\_ViewImports.cshtml"
using NetCoreTest1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Walter\Documents\Platzi\NetCore\NetCoreTest1\Views\_ViewImports.cshtml"
using NetCoreTest1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79906ebe46e36fe9a1c373a5d41e7a05b1f742c4", @"/Views/Shared/AlumnoSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27173cf84ab49e1fb899b26f6b9c86230027a095", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AlumnoSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\Walter\Documents\Platzi\NetCore\NetCoreTest1\Views\Shared\AlumnoSimple.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Alumno\r\n\r\n\r\n<div class=\"text-center\">\r\n   \r\n    <p class=\"display-4\">\r\n        Nombre:");
#nullable restore
#line 7 "D:\Users\Walter\Documents\Platzi\NetCore\NetCoreTest1\Views\Shared\AlumnoSimple.cshtml"
          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n        Id : ");
#nullable restore
#line 8 "D:\Users\Walter\Documents\Platzi\NetCore\NetCoreTest1\Views\Shared\AlumnoSimple.cshtml"
        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    \r\n   \r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
