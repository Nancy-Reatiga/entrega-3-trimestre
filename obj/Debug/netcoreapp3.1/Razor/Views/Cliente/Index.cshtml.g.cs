#pragma checksum "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874c8ed8a3772e9ff623fd765732403051583fd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874c8ed8a3772e9ff623fd765732403051583fd6", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b66c637eaf1b698dc79eaee74ccdfc380144c04", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App588.Models.Clientes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-current", new global::Microsoft.AspNetCore.Html.HtmlString("page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
   
    ViewData["Title"] = "Bienvenidos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center m-2"">NUESTROS CLIENTES</h2>

<div class=""col-12 bg-primary d-flex flex-column align-items-center flex-md-row flex-lg-row justify-content-md-center justify-content-lg-center align-items-md-start align-items-lg-start"">

    <div class=""col-12 col-md-6 col-lg-3 bg-white p-5 border rounded m-2 d-flex align-items-center justify-content-start"">
        <ul class=""nav nav-pills nav-fill"">

");
#nullable restore
#line 15 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
             if (User.IsInRole("Administrador"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874c8ed8a3772e9ff623fd765732403051583fd65423", async() => {
                WriteLiteral("Agregar Cliente");
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
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 20 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </ul>
    </div>

    <div class=""col-12 col-md-6 col-lg-8 bg-white p-3 border rounded m-2"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Codigo</th>
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Correo</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 37 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                 foreach (var mycliente in Model)

                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 41 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                                   Write(mycliente.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                       Write(mycliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                       Write(mycliente.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 45 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                             if (User.IsInRole("Administrador") || User.IsInRole("Vendedor"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                           Write(Html.ActionLink("Detalle", "Detalle", new { id = @mycliente.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                                                                                                      
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 51 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                             if (User.IsInRole("Administrador") || User.IsInRole("Coordinador"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                           Write(Html.ActionLink("Editar", "Editar", new { id = @mycliente.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                                                                                                    
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 57 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                             if (User.IsInRole("Administrador"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                           Write(Html.ActionLink("Borrar", "Borrar", new { id = @mycliente.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                                                                                                    
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <!-- Definimos los objetos de la navegacion -->\r\n        ");
#nullable restore
#line 70 "C:\Users\maiik\Desktop\Nancy\TRIMESTRE 3\JESUS\App588\Views\Cliente\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page }),
         new X.PagedList.Mvc.Core.Common.PagedListRenderOptions
     {
         DisplayItemSliceAndTotal = false,
         ContainerDivClasses = new[] { "navigation" },
         LiElementClasses = new[] { "page-item" },
         PageClasses = new[] { "page-link" },

     }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n            <script>\r\n                $(document).ready(function () {\r\n                    $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n                });\r\n            </script>\r\n        ");
            }
            );
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App588.Models.Clientes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
