#pragma checksum "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\UserAccounts\UserAccounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de47077a2ce83a21730fceeafbfc4f6b620e0a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAccounts_UserAccounts), @"mvc.1.0.view", @"/Views/UserAccounts/UserAccounts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de47077a2ce83a21730fceeafbfc4f6b620e0a83", @"/Views/UserAccounts/UserAccounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c214f9cc327750748f057da8e48ccd81cdbd30", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAccounts_UserAccounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "UserAccountsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"float:left; height:1000px; width:20%; float:left; margin:0;\" class=\"primary\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de47077a2ce83a21730fceeafbfc4f6b620e0a834241", async() => {
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
            WriteLiteral("\r\n</div>\r\n<div class=\"primarylight\" style=\"width:80%; float:left; margin:0; padding:50px;\">\r\n    <h1 style=\"color: #0C6980\">User accounts</h1>\r\n\r\n    <div class=\"primary\" style=\"width:100%; padding-left:0%;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de47077a2ce83a21730fceeafbfc4f6b620e0a835593", async() => {
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
            WriteLiteral(@"
    </div>


    <table class=""table primarydark"" style=""width:100%;"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Ime</th>
                <th scope=""col"">Prezime</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\UserAccounts\UserAccounts.cshtml"
             foreach (var s in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td></td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\UserAccounts\UserAccounts.cshtml"
                   Write(s.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\UserAccounts\UserAccounts.cshtml"
                   Write(s.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\UserAccounts\UserAccounts.cshtml"
                   Write(s.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\UserAccounts\UserAccounts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
