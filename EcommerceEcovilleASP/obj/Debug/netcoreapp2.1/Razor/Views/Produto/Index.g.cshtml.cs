#pragma checksum "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc19531bbf6a8c283e8ec6ddaa6c5500cd8e13ed"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc19531bbf6a8c283e8ec6ddaa6c5500cd8e13ed", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c5ecb0e520d85d579ff3a421e7f6ab283d2894", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
   
    List <Produto> produtos = ViewBag.Produtos;
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(100, 554, true);
            WriteLiteral(@"

        <h2>Gerenciamento de Produtos</h2>

        <table class=""table table-striped table-hover"">
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
#line 22 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                 foreach (Produto item in produtos)
                {

#line default
#line hidden
            BeginContext(726, 88, true);
            WriteLiteral("                    <tr class=\"table-primary\">\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(815, 9, false);
#line 25 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(824, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(860, 14, false);
#line 26 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(874, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(910, 25, false);
#line 27 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.Preco.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(935, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(971, 15, false);
#line 28 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(986, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1022, 13, false);
#line 29 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                       Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1070, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b7c4815150347fa8279b8652e43653e", async() => {
                BeginContext(1148, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                                         WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1158, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1193, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02357eea1ff6473996d15223fcf43e9b", async() => {
                BeginContext(1280, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                                                 WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1291, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1344, 82, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <p><b>Dados atualizados em: </b>");
            EndContext();
            BeginContext(1427, 8, false);
#line 37 "C:\Users\Aluno\Documents\GitHub\EcommerceEcovilleASP\EcommerceEcovilleASP\Views\Produto\Index.cshtml"
                                   Write(dataHora);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 6, true);
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