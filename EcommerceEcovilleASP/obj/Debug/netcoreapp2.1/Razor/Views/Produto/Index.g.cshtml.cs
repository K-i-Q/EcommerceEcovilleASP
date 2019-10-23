#pragma checksum "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d5312956bf0aeb108d042febe87978136d3441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\_ViewImports.cshtml"
using EcommerceEcovilleASP;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\_ViewImports.cshtml"
using EcommerceEcovilleASP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d5312956bf0aeb108d042febe87978136d3441", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c5ecb0e520d85d579ff3a421e7f6ab283d2894", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
   
    Layout = "~/ Views / Shared / _Layout.cshtml";
    List <Produto> produtos = ViewBag.Produtos;
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(152, 554, true);
            WriteLiteral(@"

        <h2>Gerenciamento de Produtos</h2>

        <table class=""table table-hover table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Nome</th>
                    <th scope=""col"">Descrição</th>
                    <th scope=""col"">Preço</th>
                    <th scope=""col"">Quantidade</th>
                    <th scope=""col"">Criado em</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                 foreach (Produto item in produtos)
                {

#line default
#line hidden
            BeginContext(778, 88, true);
            WriteLiteral("                    <tr class=\"table-primary\">\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(867, 9, false);
#line 26 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(876, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(912, 14, false);
#line 27 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(926, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(962, 25, false);
#line 28 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.Preco.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(987, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1023, 15, false);
#line 29 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1074, 13, false);
#line 30 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1122, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cc03adf9234ff5aed2739c86022b28", async() => {
                BeginContext(1219, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                                                            WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1269, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7290e948d6bf428b8791c7dde62ac999", async() => {
                BeginContext(1375, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                                                                    WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1391, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1444, 82, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <p><b>Dados atualizados em: </b>");
            EndContext();
            BeginContext(1527, 8, false);
#line 38 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                   Write(dataHora);

#line default
#line hidden
            EndContext();
            BeginContext(1535, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
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
