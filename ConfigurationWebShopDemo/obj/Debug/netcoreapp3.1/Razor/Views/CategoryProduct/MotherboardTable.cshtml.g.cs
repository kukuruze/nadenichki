#pragma checksum "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b162832a058871bd7406f3b272b4b7b9e86abd5"
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
#line 1 "D:\nadenichki\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nadenichki\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b162832a058871bd7406f3b272b4b7b9e86abd5", @"/Views/CategoryProduct/MotherboardTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e28934afb9c5553adf875fd893f1370f13ccc87", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CategoryProduct_MotherboardTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConfigurationWebShopDemo.Models.Mother_Boards>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCartMotherBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
  
    ViewData["Title"] = "MotherboardTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n");
#nullable restore
#line 7 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
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
#line 21 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"50%\" style=\"color: white\">");
#nullable restore
#line 24 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                                                    Write(obj.mother_board_model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50%\" style=\"color: white\">");
#nullable restore
#line 25 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                                                    Write(obj.mother_board_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" лв.</td>\r\n");
#nullable restore
#line 26 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                     if (Logged.LoggedIn == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"w-75 btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b162832a058871bd7406f3b272b4b7b9e86abd56540", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-edit\"></i>\r\n                                    Add To Cart\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                                                           WriteLiteral(obj.mother_board_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 36 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 38 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 41 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"color: white\">Изчерпани са количествата</p>\r\n");
#nullable restore
#line 45 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\MotherboardTable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConfigurationWebShopDemo.Models.Mother_Boards>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
