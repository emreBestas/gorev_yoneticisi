#pragma checksum "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d6881c5dae3b73f86555f615957ce382bc1398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableByDay_Index), @"mvc.1.0.view", @"/Views/TableByDay/Index.cshtml")]
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
#line 1 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\_ViewImports.cshtml"
using GorevYoneticisi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\_ViewImports.cshtml"
using GorevYoneticisi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d6881c5dae3b73f86555f615957ce382bc1398", @"/Views/TableByDay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9013dd2d6376a231cd41f52cbd9e37a688e693c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TableByDay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-scroller"">
    <div class=""main-panel"">
        <div class=""content-wrapper"">
            <div class=""row"">
                <div class=""col-12 grid-margin stretch-card"">
                    <div class=""card"">
                        <div class=""card-body"">
");
#nullable restore
#line 14 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\Index.cshtml"
                             using (Html.BeginForm("ToDoList", "TableByDay", FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4 class=\"card-title\">Plan tarihi seç</h4>\r\n");
            WriteLiteral(@"                                <div class=""form-group"">
                                    <label>Tarih Belirle</label>
                                    <input class=""form-group"" type=""date"" name=""datee""/>

                                </div>
                                <button type=""submit"" class=""btn btn-gradient-danger mr-2"">Göster</button>
");
#nullable restore
#line 25 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        \r\n                        \r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
