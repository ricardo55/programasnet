#pragma checksum "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80e3fec01fb986fdadd23d0074f8736dc654c6b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Delete), @"mvc.1.0.view", @"/Views/Booking/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Delete.cshtml", typeof(AspNetCore.Views_Booking_Delete))]
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
#line 1 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/_ViewImports.cshtml"
using ReservacionHotelExamen2;

#line default
#line hidden
#line 2 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/_ViewImports.cshtml"
using ReservacionHotelExamen2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e3fec01fb986fdadd23d0074f8736dc654c6b8", @"/Views/Booking/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2e95d45193badd775c58441c2cc63500c95865", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservacionHotelExamen2.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Booking</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(269, 51, false);
#line 15 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(320, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(384, 47, false);
#line 18 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(431, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(494, 51, false);
#line 21 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(545, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(609, 47, false);
#line 24 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.TimeBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(656, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(719, 51, false);
#line 27 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(770, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(834, 47, false);
#line 30 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookedStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(881, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(944, 49, false);
#line 33 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(993, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1057, 45, false);
#line 36 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookedEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1165, 55, false);
#line 39 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentDueDate));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1284, 51, false);
#line 42 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentDueDate));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1398, 57, false);
#line 45 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentDueAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1519, 53, false);
#line 48 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentDueAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1635, 54, false);
#line 51 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentMadeOn));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1753, 50, false);
#line 54 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentMadeOn));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1866, 51, false);
#line 57 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingComments));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1981, 47, false);
#line 60 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookingComments));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2091, 44, false);
#line 63 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2199, 62, false);
#line 66 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerAdressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2305, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80e3fec01fb986fdadd23d0074f8736dc654c6b813589", async() => {
                BeginContext(2331, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2341, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80e3fec01fb986fdadd23d0074f8736dc654c6b813977", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Booking/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookingID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2384, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2467, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80e3fec01fb986fdadd23d0074f8736dc654c6b815913", async() => {
                    BeginContext(2489, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2505, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2518, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservacionHotelExamen2.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591