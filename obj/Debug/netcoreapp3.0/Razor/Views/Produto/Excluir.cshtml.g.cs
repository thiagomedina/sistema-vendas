#pragma checksum "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3ae3da2ca67c453b28863e7e6c550d51be2020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Excluir), @"mvc.1.0.view", @"/Views/Produto/Excluir.cshtml")]
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
#line 1 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3ae3da2ca67c453b28863e7e6c550d51be2020", @"/Views/Produto/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c82d9cea325684eeeaf0450c735c45ad27ec96", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Excluir Produto?</h2>

<h3>Deseja realmente excluir Produto selecionado?</h3>

<button type=""button"" class=""btn btn-success"" onclick=""Sim()"">Sim</button>
<button type=""button"" class=""btn btn-success"" onclick=""Nao()"">Nao</button>


<script>

    function Sim(){
        window.location.href=""../../Produto/ExcluirProduto"" + '");
#nullable restore
#line 12 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Excluir.cshtml"
                                                          Write(ViewData["IdExcluir"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    }\r\n\r\n    function Nao(){\r\n        window.location.href=\"../../Produto/Index\"\r\n    }\r\n</script>\r\n\r\n");
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