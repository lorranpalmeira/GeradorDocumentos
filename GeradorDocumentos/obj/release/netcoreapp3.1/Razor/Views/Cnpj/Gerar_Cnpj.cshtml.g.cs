#pragma checksum "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\Cnpj\Gerar_Cnpj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9669f9457203e7c3b64d5527b39a460a9e278a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cnpj_Gerar_Cnpj), @"mvc.1.0.view", @"/Views/Cnpj/Gerar_Cnpj.cshtml")]
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
#line 1 "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\_ViewImports.cshtml"
using GeradorDocumentos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\_ViewImports.cshtml"
using GeradorDocumentos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9669f9457203e7c3b64d5527b39a460a9e278a", @"/Views/Cnpj/Gerar_Cnpj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2141291da0aa1682e64e3c480e0fa44cf60f0b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cnpj_Gerar_Cnpj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cnpj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostCnpj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\Cnpj\Gerar_Cnpj.cshtml"
  
     Layout = "_Layout";
    ViewData["Title"] = "Cnpj";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gerador de Cnpj</h1>\r\n<br />\r\n\r\n<h4>O gerador de CNPJ ajuda desenvolvedores a testar as aplicações em desenvolvimento, ou caso precisar de um cnpj válido</h4>\r\n\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9669f9457203e7c3b64d5527b39a460a9e278a4646", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Gerar Cnpj\" class=\"btn btn-primary\" />\r\n        \r\n    <input name=\"pontuacao\" id=\"pontuacao\" style=\"margin-left:10px\" type=\"checkbox\" value=\"true\" /> Com Pontuação?<br />\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<br />\r\n<div class=\"form-group\">\r\n    <div id=\"areacnpj\">\r\n        <b style=\"font-size:25px\" id=\"cnpj\">");
#nullable restore
#line 29 "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\Cnpj\Gerar_Cnpj.cshtml"
                                       Write(ViewBag.Cnpj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\Cnpj\Gerar_Cnpj.cshtml"
         if(@ViewBag.Cnpj!=null)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button onclick=\"copyToClipboard(\'#cnpj\')\" id=\"botao\" >Copiar</button>\r\n");
#nullable restore
#line 35 "C:\Users\Vector\source\repos\GeradorDocumentos\GeradorDocumentos\Views\Cnpj\Gerar_Cnpj.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
   
</div>

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />


<h4>O que é um CNPJ?</h4>

<p>
    Cadastro Nacional da Pessoa Jurídica mais conhecido como CNPJ é um número que  identifica uma pessoa jurídica e outros tipos de arranjo jurídico sem personalidade jurídica. O número registrado na Receita Federal brasileira subordinado ao Ministério da Economia. O CNPJ compreende as informações cadastrais de interesse das administrações tributárias da União, dos Estados, do Distrito Federal e dos Municípios. Criado em julho de 1998, como uma evolução do antigo Cadastro Geral de Contribuintes e por vezes também é grafado como CNPJ-ME. Encontra-se regulamentado pela Instrução Normativa RFB 1.470/2014.
</p>

    O Cadastro é uma identidade e nele tem informados:

<ul>
    <li>Data de abertura da empresa;</li>
    <li>Nome da empresa;</li>
    <li>Título ou nome fantasia;</li>
    <li>Código e descrição da atividade econômica principal;</li>
    <li>");
            WriteLiteral(@"Código e descrição das atividades econômicas secundárias;</li>
    <li>Código e descrição da natureza jurídica;</li>
    <li>Endereço;</li>
    <li>Situação cadastral</li>
</ul>


<p>O registro no CNPJ é efetuado a partir dos estabelecimentos, os quais recebem o mesmo número de identificação básico da respectiva matriz, complementado por um identificador específico para cada estabelecimento.</p>

<p>Fonte: Wikipedia</p>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

      function copyToClipboard(element) {
          var $temp = $(""<input>"");
          $(""body"").append($temp);
          $temp.val($(element).text()).select();
          document.execCommand(""copy"");
          $temp.remove();

          //
          document.getElementById(""botao"").innerHTML = ""Copiado"";
          document.getElementById(""botao"").style.backgroundColor = ""#00FF7F"";
       }

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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