#pragma checksum "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7476d033a583157f175162b69b0b252fdb8b8f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Itempatterns_Index), @"mvc.1.0.view", @"/Views/Itempatterns/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Itempatterns/Index.cshtml", typeof(AspNetCore.Views_Itempatterns_Index))]
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
#line 1 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7476d033a583157f175162b69b0b252fdb8b8f95", @"/Views/Itempatterns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35637e76b85c4316bc78e95a1bdf0b6192c624e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Itempatterns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FridgePZ.Models.Itempattern>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7476d033a583157f175162b69b0b252fdb8b8f954781", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(158, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 43, false);
#line 16 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 40, false);
#line 19 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 40, false);
#line 22 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(486, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(542, 40, false);
#line 25 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(582, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(638, 44, false);
#line 28 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(682, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(738, 49, false);
#line 31 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SeverityLevel));

#line default
#line hidden
            EndContext();
            BeginContext(787, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(843, 44, false);
#line 34 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LongLife));

#line default
#line hidden
            EndContext();
            BeginContext(887, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(943, 55, false);
#line 37 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryItemPattern));

#line default
#line hidden
            EndContext();
            BeginContext(998, 146, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Photo\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1176, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 42, false);
#line 49 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1323, 39, false);
#line 52 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1418, 39, false);
#line 55 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1513, 39, false);
#line 58 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1608, 43, false);
#line 61 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1707, 48, false);
#line 64 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SeverityLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1811, 43, false);
#line 67 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LongLife));

#line default
#line hidden
            EndContext();
            BeginContext(1854, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1910, 59, false);
#line 70 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryItemPattern.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2028, "\"", 2087, 2);
            WriteAttributeValue("", 2034, "/images/", 2034, 8, true);
#line 73 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
WriteAttributeValue("", 2042, Html.DisplayFor(modelItem => item.PhotoName), 2042, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2088, 69, true);
            WriteLiteral(" width=\"60\" />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2157, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7476d033a583157f175162b69b0b252fdb8b8f9514188", async() => {
                BeginContext(2213, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
                                       WriteLiteral(item.ItemPatternId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2221, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2241, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7476d033a583157f175162b69b0b252fdb8b8f9516557", async() => {
                BeginContext(2300, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
                                          WriteLiteral(item.ItemPatternId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2311, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2331, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7476d033a583157f175162b69b0b252fdb8b8f9518932", async() => {
                BeginContext(2389, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
                                         WriteLiteral(item.ItemPatternId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2399, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\LENOVO\Desktop\Nowy folder (16)\Fridge_PZ\FridgePZ\Views\Itempatterns\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2438, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FridgePZ.Models.Itempattern>> Html { get; private set; }
    }
}
#pragma warning restore 1591
