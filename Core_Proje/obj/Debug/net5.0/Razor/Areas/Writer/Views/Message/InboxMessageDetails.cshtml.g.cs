#pragma checksum "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "494f252d39378d81933ce53fc7bb8576e6e5e187ad115e5859995998d21b247b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_InboxMessageDetails), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/InboxMessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"494f252d39378d81933ce53fc7bb8576e6e5e187ad115e5859995998d21b247b", @"/Areas/Writer/Views/Message/InboxMessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f999b3f369daf1eaf72ba6bf7ed1162849093ba57b95475a13b251fbd9cb2d15", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_InboxMessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WriterMessage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml"
  
    ViewData["Title"] = "InboxMessageDetails";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

    string mail = ViewBag.UserMail;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-md-12 grid-margin stretch-card\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n            <h4 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml"
                              Write(Model.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <p class=\"card-description\">\n                ");
#nullable restore
#line 15 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml"
            Write(((DateTime)Model.Date).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <code> tarihinde gönderildi. </code>\n            </p>\n            <blockquote class=\"blockquote\">\n                <p class=\"mb-0\"> Konu : ");
#nullable restore
#line 18 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml"
                                   Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </blockquote>\n        </div>\n        <div class=\"card-body\">\n            <blockquote class=\"blockquote blockquote-primary\">\n                <p>");
#nullable restore
#line 23 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml"
              Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <footer class=\"blockquote-footer\">");
#nullable restore
#line 24 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Areas\Writer\Views\Message\InboxMessageDetails.cshtml"
                                             Write(Model.Sender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </footer>\n            </blockquote>\n        </div>\n    </div>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WriterMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
