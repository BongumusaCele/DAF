#pragma checksum "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c64d7f84891168bfad9c219b0d07b0383b29b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(POE_Task_1.Pages.Pages_Monetary), @"mvc.1.0.razor-page", @"/Pages/Monetary.cshtml")]
namespace POE_Task_1.Pages
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
#line 1 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\_ViewImports.cshtml"
using POE_Task_1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c64d7f84891168bfad9c219b0d07b0383b29b4", @"/Pages/Monetary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bafe6a0bd2b6a2a36aa77064cb10f9a6ca046ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Monetary : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br />
<br />
<br />
<br />
<br />
<h2>List of Monetary Donations</h2>
<table class=""table table-bordered"">
    <thead>
        <tr class=""table-dark"">
            <th>No.</th>
            <th>Name of Donor</th>
            <th>Date of Donation</th>
            <th>Amount</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
         foreach(var item in Model.listDonations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-info\">\r\n                <td>");
#nullable restore
#line 24 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>R ");
#nullable restore
#line 27 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
                 Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<br />
<h2>List of Goods Donations</h2>
<table class=""table"">
    <thead>
        <tr class=""table-dark"">
            <th>No.</th>
            <th>Donor</th>
            <th>Date</th>
            <th>Number of Items</th>
            <th>Category</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
         foreach(var item in Model.listGoodsDonations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-info\">\r\n                <td>");
#nullable restore
#line 50 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.donor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.numberofitems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<br />
<h2>List of Disasters</h2>
<table class=""table"">
    <thead>
        <tr class=""table-dark"">
            <th>No.</th>
            <th>Start Date</th>
            <th>End Date</th>
            <th>Location</th>
            <th>Description</th>
            <th>Required Aid Type</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 75 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
         foreach(var item in Model.listDisasters)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-info\">\r\n                <td>");
#nullable restore
#line 78 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 79 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.startdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 80 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.enddate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 83 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
               Write(item.aidtype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Monetary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POE_Task_1.Pages.MonetaryModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<POE_Task_1.Pages.MonetaryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<POE_Task_1.Pages.MonetaryModel>)PageContext?.ViewData;
        public POE_Task_1.Pages.MonetaryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
