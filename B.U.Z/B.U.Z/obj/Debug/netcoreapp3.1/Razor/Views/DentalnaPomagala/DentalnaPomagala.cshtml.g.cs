#pragma checksum "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e5a2021d95a17dc7e1dc6daacc91b607339333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DentalnaPomagala_DentalnaPomagala), @"mvc.1.0.view", @"/Views/DentalnaPomagala/DentalnaPomagala.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using ShieldUI.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e5a2021d95a17dc7e1dc6daacc91b607339333", @"/Views/DentalnaPomagala/DentalnaPomagala.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c214f9cc327750748f057da8e48ccd81cdbd30", @"/Views/_ViewImports.cshtml")]
    public class Views_DentalnaPomagala_DentalnaPomagala : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DentalnaPomagala>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Universal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/rounded-corners.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DentalnaPomagalaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e5a2021d95a17dc7e1dc6daacc91b6073393336145", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4e5a2021d95a17dc7e1dc6daacc91b6073393336411", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4e5a2021d95a17dc7e1dc6daacc91b6073393337593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div id=\"mainContainer\">\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4e5a2021d95a17dc7e1dc6daacc91b6073393339546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div id=\"MainPageBody\">\r\n            <div id=\"pageContent\">\r\n");
            WriteLiteral("                <div  id=\"partialNav\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4e5a2021d95a17dc7e1dc6daacc91b60733933310852", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""primarydark rcMainBody"" id=""ostatakBody-a"">


                    <div id=""AjaxPrikazOdabranogDentalnogPomagala"">

                    </div>

                    <div id=""PretraziDiv"" class=""primarydark"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e5a2021d95a17dc7e1dc6daacc91b60733933312268", async() => {
                WriteLiteral("\r\n                            <label>Pretraži dentalna pomagala:</label>\r\n                            <input type=\"text\" name=\"filter\" />\r\n                            <input type=\"submit\" value=\"Pretraži\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <table id=""tabela""  class=""table rcMainTable"">
                        <thead>
                            <tr>
                                <th scope=""col"">Redni broj</th>
                                <th scope=""col"">Šifra</th>
                                <th scope=""col"">Naziv</th>
                                <th scope=""col"">Opis</th>
                                <th scope=""col"">Pacijent</th>
");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                             foreach (var s in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr id=\"dentalnoRow\" class=\"tblHover\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1882, "\"", 1927, 3);
            WriteAttributeValue("", 1892, "OpenOdabranoDentalnoPomagalo(", 1892, 29, true);
#nullable restore
#line 45 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
WriteAttributeValue("", 1921, s.Id, 1921, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1926, ")", 1926, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td></td>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                                   Write(s.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                                   Write(s.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                                   Write(s.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                                   Write(s.Pacijent?.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 50 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                                                           Write(s.Pacijent?.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                    <div id=\"BrojDostupnihDentalnihPomagala\" class=\"primarydark\">\r\n                        <label style=\"margin-left:1%\">Broj dostupnih dentalnih pomagala:</label>");
#nullable restore
#line 60 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\DentalnaPomagala\DentalnaPomagala.cshtml"
                                                                                           Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
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
            color: white;
        }

        #BrojDostupnihDentalnihPomagala {
            color: white;
        }

        #AjaxPrikazOdabranogDentalnogPomagala {
            color: white;
        }

        /*#dentalnoRow:hover {
            background-color: aqua;
        }*/
    </style>

    <script>
        function OpenOdabranoDentalnoPomagalo(DentalnoPomagaloId) {
            var url = ""/DentalnaPomagala/SelectDentalnoPomagalo?DentalnoPomagaloId="" + DentalnoPomagaloId;
            $.get(url, function (d) {
                $(""#AjaxPrikazOdabranogDentalnogPomagala""");
            WriteLiteral(").html(d);\r\n            });\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DentalnaPomagala>> Html { get; private set; }
    }
}
#pragma warning restore 1591
