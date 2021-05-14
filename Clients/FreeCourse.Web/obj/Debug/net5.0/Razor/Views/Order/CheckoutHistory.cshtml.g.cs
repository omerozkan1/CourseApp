#pragma checksum "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3758825fbff835b31f79286d12aaa6c57d2e42bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutHistory), @"mvc.1.0.view", @"/Views/Order/CheckoutHistory.cshtml")]
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
#line 1 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3758825fbff835b31f79286d12aaa6c57d2e42bc", @"/Views/Order/CheckoutHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69962e67833e25c23c87ef5eba8a5d2bafe877fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
  
    ViewData["Title"] = "CheckoutHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">Sipariş Geçmişim</h5>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                 if (Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-striped table-bordered"">

                        <tr>
                            <th>Sipariş Numarası</th>
                            <th>Satın Alma Tarihi</th>
                            <th>Detaylar</th>
                        </tr>

");
#nullable restore
#line 22 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                         foreach (var item in Model)
	                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t                    <tr>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                               Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>
                                    <table class=""table table-striped"">
                                        <tr>
                                            <th>Kurs İsmi</th>
                                            <th>Kurs Fiyatı</th>
                                        </tr>
");
#nullable restore
#line 33 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                                         foreach (var orderItem in item.OrderItems)
	                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t                                    <tr>\r\n                                                <td>");
#nullable restore
#line 36 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                                               Write(orderItem.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 37 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                                               Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
	                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </table>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
	                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </table>\r\n");
#nullable restore
#line 46 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info\">Satın aldığınız kurs bulunmamaktadır.</div>\r\n");
#nullable restore
#line 50 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Order\CheckoutHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591