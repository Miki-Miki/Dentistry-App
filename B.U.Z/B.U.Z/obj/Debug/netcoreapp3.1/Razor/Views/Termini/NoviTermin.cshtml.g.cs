#pragma checksum "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Termini_NoviTermin), @"mvc.1.0.view", @"/Views/Termini/NoviTermin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e", @"/Views/Termini/NoviTermin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af08b38d399eb593fcc5d51851510ccab3f6c7ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Termini_NoviTermin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacijent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajTermin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "TerminiPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e4551", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
    <link rel=""stylesheet"" href=""/resources/demos/style.css"">
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
");
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
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <div style=\"float:left; width: 20%; background-color:#00A8A8\">\r\n        <div style=\"float:left; height:1000px;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e5982", async() => {
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
            WriteLiteral(@"
        </div>
    </div>

    <div id=""main_body"" style=""float:left; width: 80%; background-color:#C4DBE0; padding: 30px;"">
        <div style=""background-color: #0C6980; width:90%; height:300px; margin-left:auto; margin-right: auto;"">
     
            <div id=""noviTermin"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e7405", async() => {
                WriteLiteral(@"
                    <div id=""odabraniPacijent"">
                      
                    </div>
                    <div>
                        <input id=""odabraniPacijentId"" type=""hidden""  name=""PacijentId""/>
                    </div>
                    <div>
                        <label>Vrijeme pocetka</label>
                        <input type=""date"" name=""TerminStart"" />
                    </div>
                    <div>
                        <label>Vrijeme kraja</label>
                        <input type=""date"" name=""TerminEnd"" />
                    </div>
                    <div>
                        <label>Base Price</label>
                        <input type=""number"" name=""basePrice"" />
                    </div>
                    <div>
                        <input type=""submit"" name=""Spasi"" value=""Snimi"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div id=\"termini\" style=\"background-color: #0C6980;width:90%; height:500px; margin-left:auto; margin-right: auto;\">\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e10003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"main\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a496c7c3e9e48fd69b2c49c7ca667e83efc80e11195", async() => {
                WriteLiteral("\r\n                    <label>Pretraga:</label>\r\n                    <input type=\"text\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <table class=""table table-dark"">
                    <thead>
                        <tr>
                            <td scope=""col"">Id</td>
                            <td scope=""col"">Ime</td>
                            <td scope=""col"">Prezime</td>
                            <td scope=""col"">Broj kartona</td>
                        </tr>
                    </thead>
");
#nullable restore
#line 73 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
                     foreach (var p in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 2837, "\"", 2872, 3);
            WriteAttributeValue("", 2847, "odaberiPacijenta(\'", 2847, 18, true);
#nullable restore
#line 75 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
WriteAttributeValue("", 2865, p.Id, 2865, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2870, "\')", 2870, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
                           Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
                           Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
                           Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 79 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
                           Write(p.BrojKartona);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Termini\NoviTermin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>

            </div>


        </div>
    </div>
</div>
<script>
    //$(function () {
    //    $(""#tabs"").tabs();
    //});

    function odaberiPacijenta(PacijentId) {
        var url = ""/Termini/OdaberiPacijenta?pacijentId="" + PacijentId;
        $.get(url, function (d) {
            $(""#odabraniPacijent"").html(d);
            $(""#odabraniPacijentId"").val(PacijentId);
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacijent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
