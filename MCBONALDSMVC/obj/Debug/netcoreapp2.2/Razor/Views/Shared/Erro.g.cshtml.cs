#pragma checksum "C:\Users\44879682837\Documents\exercicio2\MCBONALDSMVC\Views\Shared\Erro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f51d623e40f24e0a2c1eb51ba2500c604286b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Erro), @"mvc.1.0.view", @"/Views/Shared/Erro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Erro.cshtml", typeof(AspNetCore.Views_Shared_Erro))]
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
#line 1 "C:\Users\44879682837\Documents\exercicio2\MCBONALDSMVC\Views\_ViewImports.cshtml"
using MCBONALDSMVC;

#line default
#line hidden
#line 2 "C:\Users\44879682837\Documents\exercicio2\MCBONALDSMVC\Views\_ViewImports.cshtml"
using MCBONALDSMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f51d623e40f24e0a2c1eb51ba2500c604286b9", @"/Views/Shared/Erro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f93177f67845a1171b8085740bf332a3bc083146", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Erro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MCBONALDSMVC.ViewMoldels.RespostasViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 17, true);
            WriteLiteral("<main>\r\n    <h2> ");
            EndContext();
            BeginContext(70, 18, false);
#line 3 "C:\Users\44879682837\Documents\exercicio2\MCBONALDSMVC\Views\Shared\Erro.cshtml"
    Write(ViewData["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 41, true);
            WriteLiteral(" deu ruim! \r\n        \r\n    </h2>\r\n    <p>");
            EndContext();
            BeginContext(130, 14, false);
#line 6 "C:\Users\44879682837\Documents\exercicio2\MCBONALDSMVC\Views\Shared\Erro.cshtml"
  Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(144, 19, true);
            WriteLiteral("\r\n    </p>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MCBONALDSMVC.ViewMoldels.RespostasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
