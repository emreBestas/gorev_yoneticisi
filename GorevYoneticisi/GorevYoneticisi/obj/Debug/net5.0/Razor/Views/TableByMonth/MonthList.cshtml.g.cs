#pragma checksum "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b010f0951605bd09af54ea5e056c32cafa887ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableByMonth_MonthList), @"mvc.1.0.view", @"/Views/TableByMonth/MonthList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b010f0951605bd09af54ea5e056c32cafa887ed", @"/Views/TableByMonth/MonthList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9013dd2d6376a231cd41f52cbd9e37a688e693c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TableByMonth_MonthList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plan>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
  
    ViewData["Title"] = "MonthList";
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
#line 15 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                             using (Html.BeginForm("MonthList", "TableByMonth", FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4 class=\"card-title\">Plan tarihi seç</h4>\r\n");
            WriteLiteral(@"                                <div class=""form-group"">
                                    <label>Tarih Belirle</label>
                                    <input class=""form-group"" type=""month"" name=""datee""/>

                                </div>
                                <button type=""submit"" class=""btn btn-gradient-danger mr-2"">Göster</button>
");
#nullable restore
#line 26 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        \r\n                        <div class=\"card-body\">\r\n                            <h4 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                                              Write(ViewBag.MonthName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Ayı Plan Listesi</h4>
     
                            <table class=""table table-dark"">
                                <thead>
                                <tr>
                                    <th> Plan Saati </th>
                                    <th> Plan Başlığı </th>
                                    <th> Plan Detayı </th>
                            
                                </thead>
                                <tbody>
");
#nullable restore
#line 41 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 44 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                                       Write(item.PlanDay.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td> ");
#nullable restore
#line 45 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                                        Write(item.PlanTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td> ");
#nullable restore
#line 46 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                                        Write(item.PlanContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                 \r\n                    \r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByMonth\MonthList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        

                    </div>

                </div>
            </div>
        </div>
    </div>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plan>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591