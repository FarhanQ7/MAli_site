#pragma checksum "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9847fb3fdce02741bf78788984da475f3dfcf7d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductBox), @"mvc.1.0.view", @"/Views/Shared/_ProductBox.cshtml")]
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
#nullable restore
#line 2 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
using Nop.Core.Domain.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
using Nop.Core.Domain.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
using Nop.Core.Domain.Tax;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9847fb3fdce02741bf78788984da475f3dfcf7d9", @"/Views/Shared/_ProductBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf99b9f327774c79cb47ae67e60399dd32f83f8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductBox : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ProductOverviewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
  
    //prepare "Add to cart" AJAX link
    var addtocartlink = "";
    var shoppingCartTypeId = (int)ShoppingCartType.ShoppingCart;
    var quantity = 1;
    if (Model.ProductPrice.ForceRedirectionAfterAddingToCart)
    {
        addtocartlink = Url.RouteUrl("AddProductToCart-Catalog", new { productId = Model.Id, shoppingCartTypeId = shoppingCartTypeId, quantity = quantity, forceredirection = Model.ProductPrice.ForceRedirectionAfterAddingToCart });
    }
    else
    {
        addtocartlink = Url.RouteUrl("AddProductToCart-Catalog", new { productId = Model.Id, shoppingCartTypeId = shoppingCartTypeId, quantity = quantity });
    }

    var addtowishlistlink = Url.RouteUrl("AddProductToCart-Catalog", new { productId = Model.Id, shoppingCartTypeId = (int)ShoppingCartType.Wishlist, quantity = quantity });
    var addtocomparelink = Url.RouteUrl("AddProductToCompare", new { productId = Model.Id });

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"product-item\" data-productid=\"");
#nullable restore
#line 25 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <div class=\"picture\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1268, 1);
#nullable restore
#line 27 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 1213, Url.RouteUrl("Product", new { SeName = Model.SeName }), 1213, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1269, "\"", 1309, 1);
#nullable restore
#line 27 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 1277, Model.DefaultPictureModel.Title, 1277, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <img");
            BeginWriteAttribute("alt", " alt=\"", 1328, "\"", 1374, 1);
#nullable restore
#line 28 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 1334, Model.DefaultPictureModel.AlternateText, 1334, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1375, "\"", 1416, 1);
#nullable restore
#line 28 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 1381, Model.DefaultPictureModel.ImageUrl, 1381, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1417, "\"", 1457, 1);
#nullable restore
#line 28 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 1425, Model.DefaultPictureModel.Title, 1425, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </a>\n    </div>\n    <div class=\"details\">\n        <h2 class=\"product-title\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 1561, "\"", 1621, 1);
#nullable restore
#line 33 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 1568, Url.RouteUrl("Product", new {SeName = Model.SeName}), 1568, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                                                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </h2>\n");
#nullable restore
#line 35 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
         if (catalogSettings.ShowSkuOnCatalogPages && !string.IsNullOrEmpty(Model.Sku))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"sku\">\n                ");
#nullable restore
#line 38 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
           Write(Model.Sku);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 40 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
         if (Model.ReviewOverviewModel.AllowCustomerReviews)
        {
            var ratingPercent = 0;
            if (Model.ReviewOverviewModel.TotalReviews != 0)
            {
                ratingPercent = ((Model.ReviewOverviewModel.RatingSum*100)/Model.ReviewOverviewModel.TotalReviews)/5;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-rating-box\"");
            BeginWriteAttribute("title", " title=\"", 2193, "\"", 2287, 1);
#nullable restore
#line 48 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 2201, string.Format(T("Reviews.TotalReviews").Text, Model.ReviewOverviewModel.TotalReviews), 2201, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"rating\">\n                    <div");
            BeginWriteAttribute("style", " style=\"", 2351, "\"", 2383, 3);
            WriteAttributeValue("", 2359, "width:", 2359, 6, true);
#nullable restore
#line 50 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue(" ", 2365, ratingPercent, 2366, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2382, "%", 2382, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 54 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"description\">\n            ");
#nullable restore
#line 56 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
       Write(Html.Raw(Model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"add-info\">\n            ");
#nullable restore
#line 59 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
       Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.ProductBoxAddinfoBefore, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"prices\">\n");
#nullable restore
#line 61 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                 if (!string.IsNullOrEmpty(Model.ProductPrice.OldPrice))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"price old-price\">");
#nullable restore
#line 63 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                                             Write(Model.ProductPrice.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 64 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"price actual-price\">");
#nullable restore
#line 65 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                                            Write(Model.ProductPrice.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 66 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                 if (Model.ProductPrice.DisplayTaxShippingInfo)
                {
                    var inclTax = workContext.TaxDisplayType == TaxDisplayType.IncludingTax;
                    //tax info is already included in the price (incl/excl tax). that's why we display only shipping info here
                    //of course, you can modify appropriate locales to include VAT info there

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"tax-shipping-info\">\n                        ");
#nullable restore
#line 72 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                   Write(T(inclTax ? "Products.Price.TaxShipping.InclTax" : "Products.Price.TaxShipping.ExclTax", Url.RouteUrl("Topic", new { SeName = Html.GetTopicSeName("shippinginfo") })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </span>\n");
#nullable restore
#line 74 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                 if (!string.IsNullOrEmpty(Model.ProductPrice.BasePricePAngV))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"base-price-pangv\">\n                        ");
#nullable restore
#line 78 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                   Write(Model.ProductPrice.BasePricePAngV);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 80 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            ");
#nullable restore
#line 82 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
       Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.ProductBoxAddinfoMiddle, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"buttons\">\n");
#nullable restore
#line 85 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                 if (!Model.ProductPrice.DisableBuyButton)
                {
                    var addToCartText = T("ShoppingCart.AddToCart").Text;
                    if (Model.ProductPrice.IsRental)
                    {
                        addToCartText = T("ShoppingCart.Rent").Text;
                    }
                    if (Model.ProductPrice.AvailableForPreOrder)
                    {
                        addToCartText = T("ShoppingCart.PreOrder").Text;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 4908, "\"", 4932, 1);
#nullable restore
#line 96 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 4916, addToCartText, 4916, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button-2 product-box-add-to-cart-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4981, "\"", 5056, 4);
            WriteAttributeValue("", 4991, "AjaxCart.addproducttocart_catalog(\'", 4991, 35, true);
#nullable restore
#line 96 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5026, addtocartlink, 5026, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5040, "\');return", 5040, 9, true);
            WriteAttributeValue(" ", 5049, "false;", 5050, 7, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 97 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                 if (!Model.ProductPrice.DisableAddToCompareListButton)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 5209, "\"", 5252, 1);
#nullable restore
#line 100 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5217, T("ShoppingCart.AddToCompareList"), 5217, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5253, "\"", 5296, 1);
#nullable restore
#line 100 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5261, T("ShoppingCart.AddToCompareList"), 5261, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button-2 add-to-compare-list-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5341, "\"", 5418, 4);
            WriteAttributeValue("", 5351, "AjaxCart.addproducttocomparelist(\'", 5351, 34, true);
#nullable restore
#line 100 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5385, addtocomparelink, 5385, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5402, "\');return", 5402, 9, true);
            WriteAttributeValue(" ", 5411, "false;", 5412, 7, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 101 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                 if (!Model.ProductPrice.DisableWishlistButton)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 5563, "\"", 5603, 1);
#nullable restore
#line 104 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5571, T("ShoppingCart.AddToWishlist"), 5571, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5604, "\"", 5644, 1);
#nullable restore
#line 104 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5612, T("ShoppingCart.AddToWishlist"), 5612, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button-2 add-to-wishlist-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5685, "\"", 5764, 4);
            WriteAttributeValue("", 5695, "AjaxCart.addproducttocart_catalog(\'", 5695, 35, true);
#nullable restore
#line 104 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
WriteAttributeValue("", 5730, addtowishlistlink, 5730, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5748, "\');return", 5748, 9, true);
            WriteAttributeValue(" ", 5757, "false;", 5758, 7, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 105 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            ");
#nullable restore
#line 107 "/Users/farhanqureshi/Desktop/nopCommerce/src/Presentation/Nop.Web/Views/Shared/_ProductBox.cshtml"
       Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.ProductBoxAddinfoAfter, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CatalogSettings catalogSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductOverviewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
