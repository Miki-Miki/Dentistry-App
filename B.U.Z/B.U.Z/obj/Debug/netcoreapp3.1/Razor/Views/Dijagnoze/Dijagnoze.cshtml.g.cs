#pragma checksum "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f46c2c8b019427d01c083f3ee4c2965b4e15c206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dijagnoze_Dijagnoze), @"mvc.1.0.view", @"/Views/Dijagnoze/Dijagnoze.cshtml")]
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
#line 1 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using ShieldUI.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46c2c8b019427d01c083f3ee4c2965b4e15c206", @"/Views/Dijagnoze/Dijagnoze.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c214f9cc327750748f057da8e48ccd81cdbd30", @"/Views/_ViewImports.cshtml")]
    public class Views_Dijagnoze_Dijagnoze : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dijagnoze>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DijagnozePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div style=\"float:left; height:1000px; width:20%; float:left; margin:0;\" class=\"primary\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f46c2c8b019427d01c083f3ee4c2965b4e15c2064842", async() => {
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div class=\"primarylight\" style=\"width:80%; float:left; margin:0; padding:50px;\">\r\n    <h1 style=\"color: #0C6980\">Dijagnoze</h1>\r\n    <div class=\"primarydark\">\r\n        <div class=\"primary\" style=\"width:100%; padding-left:9%;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f46c2c8b019427d01c083f3ee4c2965b4e15c2066237", async() => {
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
            WriteLiteral("\r\n        </div>\r\n\r\n        <div id=\"AjaxPrikazOdabraneDijagnoze\">\r\n\r\n        </div>\r\n\r\n        <div id=\"PretraziDiv\" class=\"primarydark\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f46c2c8b019427d01c083f3ee4c2965b4e15c2067523", async() => {
                WriteLiteral("\r\n                <label>Pretraži dijagnoze:</label>\r\n                <input type=\"text\" name=\"filter\" />\r\n                <input type=\"submit\" value=\"Pretraži\" />\r\n            ");
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

        <table class=""table primarydark"">
            <thead>
                <tr>
                    <th scope=""col"">Redni broj</th>
                    <th scope=""col"">Šifra</th>
                    <th scope=""col"">Naziv</th>
                    <th scope=""col"">Opis</th>
");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
                 foreach (var s in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr id=\"lijekoviRed\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1336, "\"", 1376, 3);
            WriteAttributeValue("", 1346, "OpenOdabranuDijagnozu(\'", 1346, 23, true);
#nullable restore
#line 40 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
WriteAttributeValue("", 1369, s.Id, 1369, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1374, "\')", 1374, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td></td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
                       Write(s.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
                       Write(s.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
                       Write(s.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n        <div id=\"BrojDijagnoza\" class=\"primarydark\">\r\n            <label style=\"margin-left:1%\">Broj dijagnoza:</label>");
#nullable restore
#line 55 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Dijagnoze\Dijagnoze.cshtml"
                                                            Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
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
            width: 100%;
        }

        #BrojDijagnoza {
            width: 100%;
        }

        #AjaxPrikazOdabraneDijagnoze {
            color: white;
        }

        #lijekoviRed:hover {
            background-color: aqua;
        }
    </style>


</div>
<script>
    function OpenOdabranuDijagnozu(DijagnozaId) {
        var url = ""/Dijagnoze/SelectDijagnozu?DijagnozaId="" + DijagnozaId;
        $.get(url, function (d) {
            $(""#AjaxPrikazOdabraneDijagnoze"").html(d);
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dijagnoze>> Html { get; private set; }
    }
}
#pragma warning restore 1591
