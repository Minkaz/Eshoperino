#pragma checksum "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba993d12f2cbcc27d8542341e6977325f651e8bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.RazorPages.Pages.Shared.Pages_Shared__pagination), @"mvc.1.0.view", @"/Pages/Shared/_pagination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_pagination.cshtml", typeof(Microsoft.eShopWeb.RazorPages.Pages.Shared.Pages_Shared__pagination))]
namespace Microsoft.eShopWeb.RazorPages.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages;

#line default
#line hidden
#line 2 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba993d12f2cbcc27d8542341e6977325f651e8bb", @"/Pages/Shared/_pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb9fa38969894e8ad22792b1abe78d5be5a41ca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginationInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 149, true);
            WriteLiteral("\n<div class=\"esh-pager\">\n\t<div class=\"container-fluid\">\n\t\t<article class=\"esh-pager-wrapper row\">\n\t\t\t<nav>\n\t\t\t\t<div class=\"col-md-2 col-xs-12\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(180, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d42a10b2974d91887d3227b6514d66", async() => {
                BeginContext(356, 21, true);
                WriteLiteral("\n\t\t\t\t\t\tPrevious\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 190, "esh-pager-item-left", 190, 19, true);
            AddHtmlAttributeValue(" ", 209, "esh-pager-item--navigable", 210, 26, true);
#line 8 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
AddHtmlAttributeValue(" ", 235, Model.Previous, 236, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
                              WriteLiteral(Model.ActualPage - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(381, 103, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t\n\t\t\t\t<div class=\"col-md-8 col-xs-12\">\n\t\t\t\t\t<span class=\"esh-pager-item\">\n\t\t\t\t\t\tShowing ");
            EndContext();
            BeginContext(485, 18, false);
#line 18 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
                           Write(Model.ItemsPerPage);

#line default
#line hidden
            EndContext();
            BeginContext(503, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(508, 16, false);
#line 18 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
                                                  Write(Model.TotalItems);

#line default
#line hidden
            EndContext();
            BeginContext(524, 17, true);
            WriteLiteral(" products - Page ");
            EndContext();
            BeginContext(543, 20, false);
#line 18 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
                                                                                     Write(Model.ActualPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(564, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(568, 16, false);
#line 18 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
                                                                                                              Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(584, 78, true);
            WriteLiteral("\n\t\t\t\t\t</span>\n\t\t\t\t</div>\n\t\t        \n\t\t\t\t<div class=\"col-md-2 col-xs-12\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(662, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "910e5a82f3c7460aade937f42e5a11d6", async() => {
                BeginContext(827, 17, true);
                WriteLiteral("\n\t\t\t\t\t\tNext\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 672, "esh-pager-item-right", 672, 20, true);
            AddHtmlAttributeValue(" ", 692, "esh-pager-item--navigable", 693, 26, true);
#line 23 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
AddHtmlAttributeValue(" ", 718, Model.Next, 719, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Shared\_pagination.cshtml"
                              WriteLiteral(Model.ActualPage + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(848, 51, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t</nav>\n\t\t</article>\n\t</div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginationInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
