#pragma checksum "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Stats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f8d664813c7c6c88576541bde1bd480bf80c890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(POE_Task_1.Pages.Pages_Stats), @"mvc.1.0.razor-page", @"/Pages/Stats.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f8d664813c7c6c88576541bde1bd480bf80c890", @"/Pages/Stats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bafe6a0bd2b6a2a36aa77064cb10f9a6ca046ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Stats : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<h1>Total monetary donations received</h1>\r\n<p>Total money: <span style=\"color: darkblue;\">R ");
#nullable restore
#line 11 "C:\My Programs\C#\POE Task 1\POE Task 1\Pages\Stats.cshtml"
                                             Write(Model.availableMoney);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p><br />\r\n<h1>Total number of goods received</h1><br />\r\n<h1>Currently active disasters</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POE_Task_1.Pages.StatsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<POE_Task_1.Pages.StatsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<POE_Task_1.Pages.StatsModel>)PageContext?.ViewData;
        public POE_Task_1.Pages.StatsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
