#pragma checksum "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b912d0d1af648f972ac898bf6f1e95a2e1fa5fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_Details), @"mvc.1.0.view", @"/Views/Guest/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Guest/Details.cshtml", typeof(AspNetCore.Views_Guest_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b912d0d1af648f972ac898bf6f1e95a2e1fa5fcd", @"/Views/Guest/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2e95d45193badd775c58441c2cc63500c95865", @"/Views/_ViewImports.cshtml")]
    public class Views_Guest_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservacionHotelExamen2.Models.Guest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Guest</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(219, 46, false);
#line 14 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestTitle));

#line default
#line hidden
            EndContext();
            BeginContext(265, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(329, 42, false);
#line 17 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestTitle));

#line default
#line hidden
            EndContext();
            BeginContext(371, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(434, 50, false);
#line 20 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestForenames));

#line default
#line hidden
            EndContext();
            BeginContext(484, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(548, 46, false);
#line 23 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestForenames));

#line default
#line hidden
            EndContext();
            BeginContext(594, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(657, 49, false);
#line 26 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(706, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(770, 45, false);
#line 29 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(815, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(878, 44, false);
#line 32 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestDOB));

#line default
#line hidden
            EndContext();
            BeginContext(922, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(986, 40, false);
#line 35 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1089, 53, false);
#line 38 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestAdressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1206, 49, false);
#line 41 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestAdressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1318, 51, false);
#line 44 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestAdressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1433, 47, false);
#line 47 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestAdressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1543, 53, false);
#line 50 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestAdressCounty));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1660, 49, false);
#line 53 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestAdressCounty));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1772, 57, false);
#line 56 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestAdressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1829, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1893, 53, false);
#line 59 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestAdressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2009, 53, false);
#line 62 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2126, 49, false);
#line 65 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2222, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b912d0d1af648f972ac898bf6f1e95a2e1fa5fcd12773", async() => {
                BeginContext(2273, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelProyectoFinal/Views/Guest/Details.cshtml"
                           WriteLiteral(Model.GuestID);

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
            BeginContext(2281, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2289, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b912d0d1af648f972ac898bf6f1e95a2e1fa5fcd15112", async() => {
                BeginContext(2311, 12, true);
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
            BeginContext(2327, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservacionHotelExamen2.Models.Guest> Html { get; private set; }
    }
}
#pragma warning restore 1591
