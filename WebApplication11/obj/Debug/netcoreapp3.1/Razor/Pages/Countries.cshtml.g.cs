#pragma checksum "C:\Users\Темералин Темирлан\source\repos\WebApplication11\WebApplication11\Pages\Countries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48db83f84104201d546898e6c6908040d18f5545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication11.Pages.Pages_Countries), @"mvc.1.0.razor-page", @"/Pages/Countries.cshtml")]
namespace WebApplication11.Pages
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
#line 1 "C:\Users\Темералин Темирлан\source\repos\WebApplication11\WebApplication11\Pages\_ViewImports.cshtml"
using WebApplication11;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48db83f84104201d546898e6c6908040d18f5545", @"/Pages/Countries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa2d84a5d24ed210b98f59b6cc72ab015077802", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Countries : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Темералин Темирлан\source\repos\WebApplication11\WebApplication11\Pages\Countries.cshtml"
  
    ViewData["Title"] = "Countries";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <div id=\"countries\">\r\n            <h3>");
#nullable restore
#line 9 "C:\Users\Темералин Темирлан\source\repos\WebApplication11\WebApplication11\Pages\Countries.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>Here you can find countries you can go to, use the search</p>\r\n            <input type=\"text\" name=\"name\" onkeyup=\"searchFunc()\" id=\"searchC\" placeholder=\"Search\" />\r\n            <ul id=\"spisok\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">A</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 472, "\"", 479, 0);
            EndWriteAttribute();
            WriteLiteral(">Andorra</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 528, 0);
            EndWriteAttribute();
            WriteLiteral(">Argentina</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 572, "\"", 579, 0);
            EndWriteAttribute();
            WriteLiteral(">Australia</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 623, "\"", 630, 0);
            EndWriteAttribute();
            WriteLiteral(">Azerbaijan</a></li>\r\n\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 679, "\"", 686, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">B</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 748, 0);
            EndWriteAttribute();
            WriteLiteral(">Bangladesh</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 800, 0);
            EndWriteAttribute();
            WriteLiteral(">Bali</a></li>\r\n\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 843, "\"", 850, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">C</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 905, "\"", 912, 0);
            EndWriteAttribute();
            WriteLiteral(">Canada</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 953, "\"", 960, 0);
            EndWriteAttribute();
            WriteLiteral(">Cameroon</a></li>\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1005, "\"", 1012, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">D</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1067, "\"", 1074, 0);
            EndWriteAttribute();
            WriteLiteral(">Denmark</a></li>\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1118, "\"", 1125, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">E</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1187, 0);
            EndWriteAttribute();
            WriteLiteral(">Egypt</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1227, "\"", 1234, 0);
            EndWriteAttribute();
            WriteLiteral(">Estonia</a></li>\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1285, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">F</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1340, "\"", 1347, 0);
            EndWriteAttribute();
            WriteLiteral(">France</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1388, "\"", 1395, 0);
            EndWriteAttribute();
            WriteLiteral(">Fiji</a></li>\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1436, "\"", 1443, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">I</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1505, 0);
            EndWriteAttribute();
            WriteLiteral(">Iceland</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1547, "\"", 1554, 0);
            EndWriteAttribute();
            WriteLiteral(">India</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1594, "\"", 1601, 0);
            EndWriteAttribute();
            WriteLiteral(">Indonesia</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1645, "\"", 1652, 0);
            EndWriteAttribute();
            WriteLiteral(">Italy</a></li>\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1694, "\"", 1701, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">M</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1756, "\"", 1763, 0);
            EndWriteAttribute();
            WriteLiteral(">Mali</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1802, "\"", 1809, 0);
            EndWriteAttribute();
            WriteLiteral(">Madagaskar</a></li>\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1856, "\"", 1863, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"headerList\">R</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1918, "\"", 1925, 0);
            EndWriteAttribute();
            WriteLiteral(">Russia</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <style>\r\n        #footer{\r\n            top:1783px;\r\n        }\r\n    </style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication11.CountriesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication11.CountriesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication11.CountriesModel>)PageContext?.ViewData;
        public WebApplication11.CountriesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
