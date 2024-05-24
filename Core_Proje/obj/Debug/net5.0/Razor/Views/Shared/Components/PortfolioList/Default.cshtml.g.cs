#pragma checksum "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b2099b82be4e537ae21af50966d04135f8a78d861af263090c175e1116b724ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
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
#line 1 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b2099b82be4e537ae21af50966d04135f8a78d861af263090c175e1116b724ef", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e989fd43e6193a8534844adde59389bd48687d17b6c06c6adbcb7d9b8373f074", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Projelerim</h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>
");
#nullable restore
#line 11 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid-item\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 519, 1);
#nullable restore
#line 14 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 503, item.ProjectUrl, 503, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <figure class=\"portfolio-item\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 610, "\"", 631, 1);
#nullable restore
#line 16 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 616, item.ImageUrl2, 616, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
#nullable restore
#line 16 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                           Write(item.ImageUrl1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\n                            <figcaption>\n                                <h4 class=\"h5 mb-0\">");
#nullable restore
#line 18 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <div>");
#nullable restore
#line 19 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                Write(item.ProjectUrlTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            </figcaption>\n                        </figure>\n                    </a>\n                </div>\n");
#nullable restore
#line 24 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
