#pragma checksum "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24216a848ffcfb91c905516065c6e6384a0a39f5936377d5c75b02eeb5fe83ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_Index), @"mvc.1.0.view", @"/Views/SocialMedia/Index.cshtml")]
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
#line 1 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"24216a848ffcfb91c905516065c6e6384a0a39f5936377d5c75b02eeb5fe83ec", @"/Views/SocialMedia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e989fd43e6193a8534844adde59389bd48687d17b6c06c6adbcb7d9b8373f074", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SocialMedia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card"">
            <!-- Card header -->
            <div class=""card-header border-0"">
                <h3 class=""mb-0"">Sosyal Medya Bilgilerim</h3>
            </div>
            <!-- Light table -->
            <div class=""table-responsive"">
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">İkon</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Url</th>
                            <th scope=""col""></th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <th scope=""row"">
                                    <div class=""media align-items-center"">
                                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                                            <i");
            BeginWriteAttribute("class", " class=\"", 1333, "\"", 1351, 1);
#nullable restore
#line 34 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 1341, item.Icon, 1341, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                                        </a>\n                                        <div class=\"media-body\">\n                                            <span class=\"name mb-0 text-sm\">");
#nullable restore
#line 37 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                        </div>\n                                    </div>\n                                </th>\n                                <td class=\"budget\">\n                                    ");
#nullable restore
#line 42 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
                               Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1864, "\"", 1921, 2);
            WriteAttributeValue("", 1871, "/SocialMedia/DeleteSocialMedia/", 1871, 31, true);
#nullable restore
#line 44 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 1902, item.SocialMediaID, 1902, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1997, "\"", 2052, 2);
            WriteAttributeValue("", 2004, "/SocialMedia/EditSocialMedia/", 2004, 29, true);
#nullable restore
#line 45 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 2033, item.SocialMediaID, 2033, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\n                            </tr>\n");
#nullable restore
#line 47 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\SocialMedia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n                <a href=\"/SocialMedia/AddSocialMedia\" class=\"btn btn-outline-primary col-12\">Yeni Sosyal Medya Ekle</a>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
