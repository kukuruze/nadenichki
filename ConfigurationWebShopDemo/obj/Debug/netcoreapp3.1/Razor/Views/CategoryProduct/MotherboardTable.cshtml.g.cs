#pragma checksum "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c281af69033f4b69de3b9162317da7708e8f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryProduct_MotherboardTable), @"mvc.1.0.view", @"/Views/CategoryProduct/MotherboardTable.cshtml")]
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
#line 1 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c281af69033f4b69de3b9162317da7708e8f38", @"/Views/CategoryProduct/MotherboardTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e28934afb9c5553adf875fd893f1370f13ccc87", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryProduct_MotherboardTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConfigurationWebShopDemo.Models.Mother_Boards>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
  
    ViewData["Title"] = "MotherboardTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n");
#nullable restore
#line 7 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead style=""color: white; text-align:center"">
                <tr>
                    <th>
                        Model Mother Board
                    </th>
                    <th>
                        Mother Board Price
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\" style=\"color: white\">");
#nullable restore
#line 24 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                                                        Write(obj.mother_board_model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\" style=\"color: white\">");
#nullable restore
#line 25 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                                                        Write(obj.mother_board_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" лв.</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 28 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 31 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"color: white\">Изчерпани са количествата</p>\r\n");
#nullable restore
#line 35 "D:\nadenichki\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConfigurationWebShopDemo.Models.Mother_Boards>> Html { get; private set; }
    }
}
#pragma warning restore 1591
