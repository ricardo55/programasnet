#pragma checksum "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2957515eec1f4bb548f6c731dc09b036833278ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payment/Index.cshtml", typeof(AspNetCore.Views_Payment_Index))]
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
#line 1 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/_ViewImports.cshtml"
using ReservacionHotelExamen2;

#line default
#line hidden
#line 2 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/_ViewImports.cshtml"
using ReservacionHotelExamen2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2957515eec1f4bb548f6c731dc09b036833278ca", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2e95d45193badd775c58441c2cc63500c95865", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservacionHotelExamen2.Models.Payment>>
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(103, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(132, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2957515eec1f4bb548f6c731dc09b036833278ca4861", async() => {
                BeginContext(155, 10, true);
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
            BeginContext(169, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(262, 49, false);
#line 16 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentAmount));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 51, false);
#line 19 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentComments));

#line default
#line hidden
            EndContext();
            BeginContext(418, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(474, 43, false);
#line 22 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Booking));

#line default
#line hidden
            EndContext();
            BeginContext(517, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(573, 44, false);
#line 25 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(617, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(673, 49, false);
#line 28 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(722, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(840, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(889, 48, false);
#line 37 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentAmount));

#line default
#line hidden
            EndContext();
            BeginContext(937, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(993, 50, false);
#line 40 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentComments));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1099, 52, false);
#line 43 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Booking.BookingID));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1207, 65, false);
#line 46 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.CustomerAdressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1328, 64, false);
#line 49 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentMethod.PaymentMethodID));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1447, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2957515eec1f4bb548f6c731dc09b036833278ca11299", async() => {
                BeginContext(1499, 4, true);
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
#line 52 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
                                       WriteLiteral(item.PaymentID);

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
            BeginContext(1507, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1527, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2957515eec1f4bb548f6c731dc09b036833278ca13660", async() => {
                BeginContext(1582, 7, true);
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
#line 53 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
                                          WriteLiteral(item.PaymentID);

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
            BeginContext(1593, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1613, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2957515eec1f4bb548f6c731dc09b036833278ca16027", async() => {
                BeginContext(1667, 6, true);
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
#line 54 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
                                         WriteLiteral(item.PaymentID);

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
            BeginContext(1677, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Payment/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1716, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservacionHotelExamen2.Models.Payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
