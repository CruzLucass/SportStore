#pragma checksum "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf781553bb84ef52369c75cec909f14ce75eb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_List), @"mvc.1.0.view", @"/Views/Produto/List.cshtml")]
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
#line 1 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf781553bb84ef52369c75cec909f14ce75eb0a", @"/Views/Produto/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e029ab5a91bd00d5e5bb1adf9aa1a51b0e3a5b0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("paging-action", new global::Microsoft.AspNetCore.Html.HtmlString("List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SportStore.Infraestrutura.PageLinkTagHelper __SportStore_Infraestrutura_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
 foreach (var p in Model.Produtos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card card-outline-primary m-1 p-1\">\r\n        <div class=\"bg-faded p-1\">\r\n            <h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf781553bb84ef52369c75cec909f14ce75eb0a5691", async() => {
#nullable restore
#line 8 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
                                                               Write(p.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
                                          WriteLiteral(p.ProdutoID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                    <small>");
#nullable restore
#line 10 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
                      Write(p.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </span>\r\n                ");
#nullable restore
#line 12 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
           Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h4>\r\n        </div>\r\n        <div class=\"card-text p-1\">");
#nullable restore
#line 15 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
                              Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"card-text p-1\">");
#nullable restore
#line 16 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
                              Write(p.Fabricante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf781553bb84ef52369c75cec909f14ce75eb0a9814", async() => {
                WriteLiteral("\r\n");
            }
            );
            __SportStore_Infraestrutura_PageLinkTagHelper = CreateTagHelper<global::SportStore.Infraestrutura.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__SportStore_Infraestrutura_PageLinkTagHelper);
#nullable restore
#line 19 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
__SportStore_Infraestrutura_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __SportStore_Infraestrutura_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "C:\Users\Usuário\Desktop\B.C.C\5° periodo\Ferramentas de Desenvolvimento\SportStore\SportStore\Views\Produto\List.cshtml"
__SportStore_Infraestrutura_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __SportStore_Infraestrutura_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __SportStore_Infraestrutura_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __SportStore_Infraestrutura_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __SportStore_Infraestrutura_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
