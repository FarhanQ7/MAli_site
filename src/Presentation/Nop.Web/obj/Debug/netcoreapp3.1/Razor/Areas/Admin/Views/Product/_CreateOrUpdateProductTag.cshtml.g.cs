#pragma checksum "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d66686d65971fb117333de3d35ded68c682db42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__CreateOrUpdateProductTag), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml")]
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
#line 7 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d66686d65971fb117333de3d35ded68c682db42e", @"/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747547476f7bb62f744009a759f9c139df531eb3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__CreateOrUpdateProductTag : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ProductTagModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-required", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d66686d65971fb117333de3d35ded68c682db42e15005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 3 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66686d65971fb117333de3d35ded68c682db42e16545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 4 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 6 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
 if (ViewBag.RefreshPage == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\n        try {window.opener.document.forms[\'");
#nullable restore
#line 9 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
                                       Write(Context.Request.Query["formId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'].");
#nullable restore
#line 9 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
                                                                            Write(Context.Request.Query["btnId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".click();}\n        catch (e){}\n        window.close();\n    </script>\n");
#nullable restore
#line 13 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"content\">\n    <div class=\"form-horizontal\">\n        <div class=\"panel-group\">\n            ");
#nullable restore
#line 18 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
       Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ProductTagDetailsTop, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"panel panel-default panel-popup\">\n                <div class=\"panel-body\">\n                    ");
#nullable restore
#line 21 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
                Write(Html.LocalizedEditor<ProductTagModel, ProductTagLocalizedModel>("producttag-localized",
                    item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("<div>\n                        <div class=\"form-group\">\n                            <div class=\"col-sm-3\">\n                                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66686d65971fb117333de3d35ded68c682db42e21260", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 25 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                            </div>\n                            <div class=\"col-sm-9\">\n                                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66686d65971fb117333de3d35ded68c682db42e22746", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 28 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d66686d65971fb117333de3d35ded68c682db42e24148", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 29 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                            </div>\n                        </div>\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66686d65971fb117333de3d35ded68c682db42e25666", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
    __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
    __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].LanguageId);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                    </div>\n");
    PopWriter();
}
)    ,
                    item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("<div>\n                        <div class=\"form-group\">\n                            <div class=\"col-sm-3\">\n                                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66686d65971fb117333de3d35ded68c682db42e28134", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 38 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                            </div>\n                            <div class=\"col-sm-9\">\n                                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66686d65971fb117333de3d35ded68c682db42e29608", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 41 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.IsRequired = (string)__tagHelperAttribute_1.Value;
    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d66686d65971fb117333de3d35ded68c682db42e31188", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n");
    PopWriter();
}
)    ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            ");
#nullable restore
#line 49 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Areas/Admin/Views/Product/_CreateOrUpdateProductTag.cshtml"
       Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ProductTagDetailsBottom, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductTagModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
