#pragma checksum "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07d341a36a8a7fe42519fc3dc8a44e624ce19089c24a68b07f72e9ad51dfda15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"07d341a36a8a7fe42519fc3dc8a44e624ce19089c24a68b07f72e9ad51dfda15", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e989fd43e6193a8534844adde59389bd48687d17b6c06c6adbcb7d9b8373f074", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
#nullable restore
#line 7 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialHeader.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d341a36a8a7fe42519fc3dc8a44e624ce19089c24a68b07f72e9ad51dfda153779", async() => {
                WriteLiteral("\n    <!-- Sidenav -->\n    ");
#nullable restore
#line 10 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialSidebar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <!-- Main content -->\n    <div class=\"main-content\" id=\"panel\">\n        <!-- Topnav -->\n        ");
#nullable restore
#line 14 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/PartialTopbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <!-- Header -->\n        ");
#nullable restore
#line 16 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/PartialNavigation.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <!-- Page content -->\n        <div class=\"container-fluid mt--6\">\n            <div class=\"row\">\n                <div class=\"col\">\n                    ");
#nullable restore
#line 21 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                ");
#nullable restore
#line 23 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
           Write(await RenderSectionAsync("Scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <!-- Footer -->\n            ");
#nullable restore
#line 26 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialFooter.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <!-- Argon Scripts -->\n    ");
#nullable restore
#line 30 "C:\Users\aballi\Desktop\MY\Portfolio-master\Core_Proje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
