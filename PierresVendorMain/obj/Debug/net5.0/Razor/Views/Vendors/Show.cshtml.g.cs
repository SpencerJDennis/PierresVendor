#pragma checksum "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa2c1dac3e20d169f61a2e8432fa0f1046564f56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
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
#line 5 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
using PierresVendorMain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa2c1dac3e20d169f61a2e8432fa0f1046564f56", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Vendor Name: ");
#nullable restore
#line 7 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
            Write(Model["vendor"].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Vendor Description: ");
#nullable restore
#line 8 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
                   Write(Model["vendor"].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Vendor Orders: </h2>\r\n\r\n<ol>\r\n");
#nullable restore
#line 12 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
 foreach (Order order in @Model["orders"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li><a");
            BeginWriteAttribute("href", " href=\'", 261, "\'", 313, 4);
            WriteAttributeValue("", 268, "/vendors/", 268, 9, true);
#nullable restore
#line 14 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 277, Model["vendor"].Id, 277, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 296, "/orders/", 296, 8, true);
#nullable restore
#line 14 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 304, order.Id, 304, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
                                                         Write(order.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 15 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\r\n\r\n<p><a");
            BeginWriteAttribute("href", " href=\'", 361, "\'", 407, 3);
            WriteAttributeValue("", 368, "/vendors/", 368, 9, true);
#nullable restore
#line 18 "C:\Users\blade\Desktop\PierresVendor.solution\PierresVendorMain\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 377, Model["vendor"].Id, 377, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 396, "/orders/new", 396, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Create a New Order</a></p>\r\n<p><a href=\'/vendors\'>Return to Vendor List</a></p>\r\n<p><a href=\'/\'>Return to Home Page</a></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
