#pragma checksum "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4823e1c9044232c1c090b995dbc33ed9cbc49322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Detalle), @"mvc.1.0.view", @"/Views/Cliente/Detalle.cshtml")]
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
#line 1 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\_ViewImports.cshtml"
using App588;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\_ViewImports.cshtml"
using App588.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4823e1c9044232c1c090b995dbc33ed9cbc49322", @"/Views/Cliente/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b66c637eaf1b698dc79eaee74ccdfc380144c04", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App588.Models.Clientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-current", new global::Microsoft.AspNetCore.Html.HtmlString("page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center m-2"">Detalle De Un Cliente</h2>

<div class=""col-12 bg-primary d-flex flex-column align-items-center flex-md-row flex-lg-row justify-content-md-center justify-content-lg-center align-items-md-start align-items-lg-start"">

    <div class=""col-12 col-md-6 col-lg-3 bg-white p-5 border rounded m-2 d-flex align-items-center justify-content-start"">
        <ul class=""nav nav-pills nav-fill"">
            <li class=""nav-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4823e1c9044232c1c090b995dbc33ed9cbc493224780", async() => {
                WriteLiteral("Ir a Lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                 if (User.IsInRole("Administrador") || User.IsInRole("Coordinador"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
               Write(Html.ActionLink("Editar", "Editar", new { id = @Model.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                                                                                    
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                 if (User.IsInRole("Administrador"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
               Write(Html.ActionLink("Borrar", "Borrar", new { id = @Model.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </li>
        </ul>
    </div>

    <div class=""col-12 col-md-6 col-lg-8 bg-white p-3 border rounded m-2"">

        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Codigo</th>
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Correo</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <th scope=""row"">");
#nullable restore
#line 43 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                               Write(Model.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Detalle.cshtml"
                   Write(Model.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>  \r\n        </table>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App588.Models.Clientes> Html { get; private set; }
    }
}
#pragma warning restore 1591
