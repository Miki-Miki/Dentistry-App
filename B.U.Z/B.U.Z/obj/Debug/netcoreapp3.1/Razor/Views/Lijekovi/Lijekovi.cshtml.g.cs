#pragma checksum "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb2c251d36b00f4679cc6ed957017fd8b97bc0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lijekovi_Lijekovi), @"mvc.1.0.view", @"/Views/Lijekovi/Lijekovi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb2c251d36b00f4679cc6ed957017fd8b97bc0b", @"/Views/Lijekovi/Lijekovi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c214f9cc327750748f057da8e48ccd81cdbd30", @"/Views/_ViewImports.cshtml")]
    public class Views_Lijekovi_Lijekovi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Lijekovi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LijekoviPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"float:left; height:1000px; width:200px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bb2c251d36b00f4679cc6ed957017fd8b97bc0b4492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<h1>Lijekovi</h1>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bb2c251d36b00f4679cc6ed957017fd8b97bc0b5660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"AjaxPrikazOdabranogLijeka\">\r\n\r\n</div>\r\n\r\n<div id=\"PretraziDiv\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb2c251d36b00f4679cc6ed957017fd8b97bc0b6882", async() => {
                WriteLiteral("\r\n        <label>Pretraži lijekove:</label>\r\n        <input type=\"text\" name=\"filter\" />\r\n        <input type=\"submit\" value=\"Pretraži\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<table class=""table table-dark"" style=""width:80.7%;"">
    <thead>
        <tr>
            <th scope=""col"">Redni broj</th>
            <th scope=""col"">Šifra</th>
            <th scope=""col"">Naziv</th>
            <th scope=""col"">Opis</th>
");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
         foreach (var s in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr id=\"lijekoviRed\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 884, "\"", 919, 3);
            WriteAttributeValue("", 895, "OpenOdabraniLijek(", 895, 18, true);
#nullable restore
#line 38 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
WriteAttributeValue("", 913, s.Id, 913, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 918, ")", 918, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 40 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
           Write(s.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
           Write(s.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
           Write(s.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 47 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n<div id=\"BrojDostupnihLijekova\">\r\n    <label style=\"margin-left:1%\">Broj dostupnih lijekova:</label>");
#nullable restore
#line 53 "D:\FIT\RS\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
                                                             Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<style>
    body {
        counter-reset: Serial; /* Set the Serial counter to 0 */
    }

    tr td:first-child:before {
        counter-increment: Serial; /* Increment the Serial counter */
        content: counter(Serial); /* Display the counter */
    }
    #PretraziDiv {
        color: white;
        background-color: #343a40;
        width: 80.6%;
        margin-left: 18.1%;
    }
    #BrojDostupnihLijekova {
        color: white;
        background-color: #343a40;
        width: 80.6%;
        margin-left: 18.1%;
        margin-top: -2%;
    }
    #AjaxPrikazOdabranogLijeka {
        color: white;
        background-color: #343a40;
        width: 80.6%;
        margin-left: 18.1%;
        border:1px solid red;
    }

    #lijekoviRed:hover {
        background-color: aqua;
    }

</style>

<script>
    function OpenOdabraniLijek(LijekId)
    {
        var url = ""/Lijekovi/SelectLijek?LijekId="" + LijekId;
        $.get(url, function (d) {
            ");
            WriteLiteral("$(\"#AjaxPrikazOdabranogLijeka\").html(d);\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Lijekovi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
