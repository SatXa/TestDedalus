#pragma checksum "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905e4e76040f223cce3bb600bdc28ff05a9a112e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestDedalus.Pages.CapitalCities.Pages_CapitalCities_CapitalCityDisplayList), @"mvc.1.0.razor-page", @"/Pages/CapitalCities/CapitalCityDisplayList.cshtml")]
namespace TestDedalus.Pages.CapitalCities
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
#line 1 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\_ViewImports.cshtml"
using TestDedalus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905e4e76040f223cce3bb600bdc28ff05a9a112e", @"/Pages/CapitalCities/CapitalCityDisplayList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c3c8f90fc75a209db742a932130501979cfa6d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CapitalCities_CapitalCityDisplayList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
  
    ViewData["Title"] = "Countries & capitals";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h1>Capital City Search</h1>\r\n\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905e4e76040f223cce3bb600bdc28ff05a9a112e3716", async() => {
                WriteLiteral("Full list of countries with their respective capitals");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </p>
    </div>
</div>
<div class=""row"">
    <div class=""col-sm-12"">
        <table class=""table"">
            <tr>
                <th>Customer ID</th>
                <th>Name</th>
                <th>Country</th>
                <th>Region</th>
            </tr>
");
#nullable restore
#line 25 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
             foreach (var item in Model.CapitalCitiesDisplayList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CapitalId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CapitalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CountryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\sdhofhuis\source\repos\TestDedalus\TestDedalus\Pages\CapitalCities\CapitalCityDisplayList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestDedalus.Pages.CapitalCities.CapitalCityDisplayListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestDedalus.Pages.CapitalCities.CapitalCityDisplayListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestDedalus.Pages.CapitalCities.CapitalCityDisplayListModel>)PageContext?.ViewData;
        public TestDedalus.Pages.CapitalCities.CapitalCityDisplayListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591