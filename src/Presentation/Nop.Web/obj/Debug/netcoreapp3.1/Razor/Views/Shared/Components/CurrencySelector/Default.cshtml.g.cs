#pragma checksum "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/Components/CurrencySelector/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9044e148d6971e13a82e4cfc457513287023165c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CurrencySelector_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CurrencySelector/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9044e148d6971e13a82e4cfc457513287023165c", @"/Views/Shared/Components/CurrencySelector/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf99b9f327774c79cb47ae67e60399dd32f83f8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CurrencySelector_Default : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CurrencySelectorModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customerCurrency"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "customerCurrency", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("setLocation(this.value);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/Components/CurrencySelector/Default.cshtml"
 if (Model.AvailableCurrencies.Count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"currency-selector\">\n");
#nullable restore
#line 8 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/Components/CurrencySelector/Default.cshtml"
          
            var returnUrl = webHelper.GetRawUrl(Context.Request);
            var currencies = Model.AvailableCurrencies.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = Url.RouteUrl("ChangeCurrency", new { customercurrency = x.Id, returnUrl }, webHelper.CurrentRequestProtocol),
                Selected = x.Id.Equals(Model.CurrentCurrencyId)
            });

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9044e148d6971e13a82e4cfc457513287023165c10575", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 16 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/Components/CurrencySelector/Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = currencies;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "aria-label", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/Components/CurrencySelector/Default.cshtml"
AddHtmlAttributeValue("", 709, T("Currency.Selector.Label"), 709, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("    </div>\n");
#nullable restore
#line 19 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/Components/CurrencySelector/Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Core.IWebHelper webHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurrencySelectorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
