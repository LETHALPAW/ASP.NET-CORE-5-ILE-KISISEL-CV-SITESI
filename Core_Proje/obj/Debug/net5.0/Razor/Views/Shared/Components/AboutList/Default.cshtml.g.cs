#pragma checksum "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bd86af6533497e0c9ecfd95e87722d3d5b82ba5fb6f22cccf12160b6f44a4935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bd86af6533497e0c9ecfd95e87722d3d5b82ba5fb6f22cccf12160b6f44a4935", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e989fd43e6193a8534844adde59389bd48687d17b6c06c6adbcb7d9b8373f074", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\n    <div class=\"container-narrow\">\n");
#nullable restore
#line 6 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col-md-6\">\n                    <h2 class=\"h4 my-2\">");
#nullable restore
#line 10 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <p>");
#nullable restore
#line 11 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""row mt-3"">
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Mail:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 17 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">LinkedIn:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder""><a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 947, 1);
#nullable restore
#line 23 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 936, item.Phone, 936, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" class=""text-warning text-decoration-none"">YİĞİT ALP BALLI</a></div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Adres:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 29 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        </div>\n                    </div>\n                </div>\n                <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\"><img class=\"avatar img-fluid mt-2\"");
            BeginWriteAttribute("src", " src=\"", 1532, "\"", 1552, 1);
#nullable restore
#line 33 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1538, item.ImageUrl, 1538, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"Walter Patterson\" /></div>\n            </div>\n");
#nullable restore
#line 35 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591