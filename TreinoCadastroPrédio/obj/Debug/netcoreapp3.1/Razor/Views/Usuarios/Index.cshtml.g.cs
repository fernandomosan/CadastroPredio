#pragma checksum "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef09973608d68a99d07aef2b7374f578e2ea6f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\_ViewImports.cshtml"
using TreinoCadastroPrédio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\_ViewImports.cshtml"
using TreinoCadastroPrédio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
using GerenciadorCondominios.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef09973608d68a99d07aef2b7374f578e2ea6f3", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ba0298397b889fcc69c1316c0481e621312b51b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerenciarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Moradores Cadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""tabelas"">
    <div class=""collection with-header"">
        <div class=""collection-header grey darken-1"">
            <div class=""row"">
                <div class=""col s10"">
                    <h6 class=""White-text"">Moradores Cadastrados</h6>
                </div>

                <div class=""col s2"">
                    
                </div>
            </div>
        </div>

        <div class=""collection-item"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Nome
                        </th>

                        <th>
                            CPF
                        </th>

                        <th>
                            Email
                        </th>

                        <th>
                            Telefone
                        </th>


                        <th></th>
                    </tr>
                </thead>
      ");
            WriteLiteral("          <tbody>\r\n");
#nullable restore
#line 47 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n");
#nullable restore
#line 63 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                             if (item.Status == StatusConta.Analisando)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge purple darken-3\" data-badge-caption=\"\"");
            BeginWriteAttribute("id", " id=\"", 2134, "\"", 2147, 1);
#nullable restore
#line 66 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2139, item.Id, 2139, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
            WriteLiteral("                                <td");
            BeginWriteAttribute("class", " class=\"", 2276, "\"", 2292, 1);
#nullable restore
#line 69 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2284, item.Id, 2284, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"btn-floating blue darken-4 btnAprovar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2380, "\"", 2432, 5);
            WriteAttributeValue("", 2390, "AprovarUsuario(\'", 2390, 16, true);
#nullable restore
#line 70 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2406, item.Id, 2406, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2414, "\',", 2414, 2, true);
#nullable restore
#line 70 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
WriteAttributeValue(" ", 2416, item.UserName, 2417, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2431, ")", 2431, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\">thumb_up</i></a>\r\n                                    <a class=\"btn-floating red darken-4 btnReprovar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2562, "\"", 2615, 5);
            WriteAttributeValue("", 2572, "ReprovarUsuario(\'", 2572, 17, true);
#nullable restore
#line 71 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2589, item.Id, 2589, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2597, "\',", 2597, 2, true);
#nullable restore
#line 71 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
WriteAttributeValue(" ", 2599, item.UserName, 2600, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2614, ")", 2614, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\">thumb_down</i></a>\r\n                                </td>\r\n");
#nullable restore
#line 73 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                            }
                            else if (item.Status == StatusConta.Aprovado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge green darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 77 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef09973608d68a99d07aef2b7374f578e2ea6f312213", async() => {
                WriteLiteral("<i class=\"material-icons\">group</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-usuarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                                                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-usuarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                                                                                                                                                                     WriteLiteral(item.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 83 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td> \r\n                                    <span class=\"new badge orange darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 87 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
#nullable restore
#line 89 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 92 "D:\ESTUDOSC#\Treinos\TreinoCadastroPrédio\TreinoCadastroPrédio\Views\Usuarios\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
