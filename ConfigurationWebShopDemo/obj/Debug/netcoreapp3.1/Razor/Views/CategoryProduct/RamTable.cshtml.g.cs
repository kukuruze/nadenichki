#pragma checksum "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "349375147cf0320d7c53f7059b744565f6c46082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryProduct_RamTable), @"mvc.1.0.view", @"/Views/CategoryProduct/RamTable.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349375147cf0320d7c53f7059b744565f6c46082", @"/Views/CategoryProduct/RamTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e28934afb9c5553adf875fd893f1370f13ccc87", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryProduct_RamTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConfigurationWebShopDemo.Models.RAMs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
  
    ViewData["Title"] = "RamTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:white\">RAM View</h1>\r\n<h2 style=\"color:white\">Import Database from RAM Table</h2>\r\n\r\n<div class=\"container p-3\">\r\n");
#nullable restore
#line 10 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead style=""color: white; text-align:center"">
                <tr>
                    <th>
                        Model RAM
                    </th>
                    <th>
                        RAM Price
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\" style=\"color: white\">");
#nullable restore
#line 27 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
                                                        Write(obj.ram_capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\" style=\"color: white\">");
#nullable restore
#line 28 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
                                                        Write(obj.ram_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 34 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Изчерпани са количествата</p>\r\n");
#nullable restore
#line 38 "C:\Users\HP\Desktop\nadenichki2\ConfigurationWebShopDemo\Views\CategoryProduct\RamTable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConfigurationWebShopDemo.Models.RAMs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
