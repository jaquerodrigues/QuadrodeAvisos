#pragma checksum "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c7b52847f678815fcfec4ebd4357bca450f3b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuadroAvisos.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace QuadroAvisos.Pages
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
#line 1 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\_ViewImports.cshtml"
using QuadroAvisos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c7b52847f678815fcfec4ebd4357bca450f3b5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905746c994d099835bab0a013554e5b2d9c991ef", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
  
    ViewData["Title"] = "Quadro de Avisos";

    var avisos = dataContext.Avisos
                            .OrderByDescending(s => s.Hora)
                            .Take(100)
                            .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 11 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-10\">\r\n");
#nullable restore
#line 15 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
         if (avisos.Any())
        {
            foreach (var aviso in avisos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    <strong>");
#nullable restore
#line 20 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
                       Write(aviso.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> | ");
#nullable restore
#line 20 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
                                              Write(aviso.Hora.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 21 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
               Write(Html.Raw(aviso.Mensagem.Replace("\r\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 23 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Nenhum aviso publicado!  Seja o primeiro...</p>\r\n");
#nullable restore
#line 28 "D:\Documentos\GAMA\curso\QuadroAvisos\QuadroAvisos\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<a href=\"AdicionarAviso\">Adicionar Novo Aviso</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public QuadroAvisos.Data.AvisoContext dataContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
