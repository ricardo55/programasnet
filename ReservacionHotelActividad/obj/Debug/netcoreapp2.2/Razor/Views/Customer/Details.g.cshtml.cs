#pragma checksum "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94eff0b09882c1cf0a48efa51d9eac9b5a5dbb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94eff0b09882c1cf0a48efa51d9eac9b5a5dbb6", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2e95d45193badd775c58441c2cc63500c95865", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservacionHotelExamen2.Models.Customer>
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(225, 49, false);
#line 14 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerTitle));

#line default
#line hidden
            EndContext();
            BeginContext(274, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(338, 45, false);
#line 17 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerTitle));

#line default
#line hidden
            EndContext();
            BeginContext(383, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(446, 53, false);
#line 20 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(499, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(563, 49, false);
#line 23 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(612, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(675, 52, false);
#line 26 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(727, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(791, 48, false);
#line 29 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(839, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(902, 47, false);
#line 32 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(949, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1013, 43, false);
#line 35 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1119, 56, false);
#line 38 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAdressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1239, 52, false);
#line 41 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAdressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1354, 54, false);
#line 44 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAdressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1472, 50, false);
#line 47 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAdressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1585, 57, false);
#line 50 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAdressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1706, 53, false);
#line 53 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAdressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1822, 60, false);
#line 56 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAdressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1946, 56, false);
#line 59 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAdressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2065, 53, false);
#line 62 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2182, 49, false);
#line 65 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2294, 53, false);
#line 68 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2347, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2411, 49, false);
#line 71 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2460, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2523, 55, false);
#line 74 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerMobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2642, 51, false);
#line 77 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerMobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2693, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2756, 49, false);
#line 80 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2869, 45, false);
#line 83 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2914, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2961, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d94eff0b09882c1cf0a48efa51d9eac9b5a5dbb615633", async() => {
                BeginContext(3015, 4, true);
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
#line 88 "/Users/ricardovb/Documents/UAZ/Decimo/SistemasInfGeografica/Proyectos/ReservacionHotelActividad/Views/Customer/Details.cshtml"
                           WriteLiteral(Model.CustomerID);

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
            BeginContext(3023, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3031, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d94eff0b09882c1cf0a48efa51d9eac9b5a5dbb617974", async() => {
                BeginContext(3053, 12, true);
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
            BeginContext(3069, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservacionHotelExamen2.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
