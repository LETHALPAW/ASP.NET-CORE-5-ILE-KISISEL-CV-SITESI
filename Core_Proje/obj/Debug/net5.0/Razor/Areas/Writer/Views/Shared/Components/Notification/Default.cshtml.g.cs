#pragma checksum "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c6d62c0323213a4e815ec8b2223724701c192cadd6476b6793a5b40a3263fc4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_Notification_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
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
#line 1 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje.Areas.Writer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c6d62c0323213a4e815ec8b2223724701c192cadd6476b6793a5b40a3263fc4a", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f999b3f369daf1eaf72ba6bf7ed1162849093ba57b95475a13b251fbd9cb2d15", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Shared_Components_Notification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<ul class=""navbar-nav navbar-nav-right"">
    <li class=""nav-item dropdown"">
        <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
            <i class=""icon-bell mx-0""></i>
            <span class=""count""></span>
        </a>
        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Bildirimler</p>
");
#nullable restore
#line 11 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
             foreach (var item in Model)
            {
                string color = "";
                if (item.Status == "Yeni Yazı")
                {
                    color = "info";
                }
                if (item.Status == "MVC Yıldızları")
                {
                    color = "primary";
                }
                if (item.Status == "Proje Bilgisi")
                {
                    color = "success";
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 1051, "\"", 1107, 2);
            WriteAttributeValue("", 1058, "/Writer/Announcement/AnnouncementDetails/", 1058, 41, true);
#nullable restore
#line 27 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 1099, item.ID, 1099, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"preview-thumbnail\">\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1190, "\"", 1220, 3);
            WriteAttributeValue("", 1198, "preview-icon", 1198, 12, true);
            WriteAttributeValue(" ", 1210, "bg-", 1211, 4, true);
#nullable restore
#line 29 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 1214, color, 1214, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"ti-info-alt mx-0\"></i>\n                        </div>\n                    </div>\n                    <div class=\"preview-item-content\">\n                        <h6 class=\"preview-subject font-weight-normal\">");
#nullable restore
#line 34 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                        <p class=\"font-weight-light small-text mb-0\">\n                            ");
#nullable restore
#line 36 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                       Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                        <p class=\"font-weight-light small-text mb-0 text-muted\">\n                            ");
#nullable restore
#line 39 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                        Write(((DateTime)item.Date).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                    </div>\n                </a>\n");
#nullable restore
#line 43 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a href=""/Writer/Announcement/Index"" class=""btn btn-outline-info col-12"">Tüm Duyurular</a>
        </div>
    </li>
    <li class=""nav-item nav-profile dropdown"">
        <a class=""nav-link dropdown-toggle"" href=""#"" data-toggle=""dropdown"" id=""profileDropdown"">
            <img");
            BeginWriteAttribute("src", " src=\"", 2165, "\"", 2189, 1);
#nullable restore
#line 49 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 2171, ViewBag.UserImage, 2171, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""profile"" />
        </a>
        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""profileDropdown"">
            <a href=""/Writer/Profile/Setting"" class=""dropdown-item"">
                <i class=""ti-settings text-primary""></i>
                Ayarlar
            </a>
            <a href=""/Writer/Login/Logout"" class=""dropdown-item"">
                <i class=""ti-power-off text-primary""></i>
                Çıkış Yap!
            </a>
        </div>
    </li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591