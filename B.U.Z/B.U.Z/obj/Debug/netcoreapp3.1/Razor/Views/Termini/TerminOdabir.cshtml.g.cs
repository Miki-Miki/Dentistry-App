#pragma checksum "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b55cc69c99bffce6614f317fb6c4bac18dc6331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Termini_TerminOdabir), @"mvc.1.0.view", @"/Views/Termini/TerminOdabir.cshtml")]
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
#line 1 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using ShieldUI.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
using B.U.Z.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b55cc69c99bffce6614f317fb6c4bac18dc6331", @"/Views/Termini/TerminOdabir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c214f9cc327750748f057da8e48ccd81cdbd30", @"/Views/_ViewImports.cshtml")]
    public class Views_Termini_TerminOdabir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TerminiVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
  
    ViewData["Title"] = "TerminOdabir";
    Layout = null;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table table-dark\">\r\n    <tbody>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
           Write(Model.pacijent.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
                                     Write(Model.pacijent.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
           Write(Model.TerminStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
           Write(Model.TerminEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Termini\TerminOdabir.cshtml"
           Write(Model.basePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TerminiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
