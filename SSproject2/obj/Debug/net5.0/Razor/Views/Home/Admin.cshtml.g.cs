#pragma checksum "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Home\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c9b36e49427cb4fd0e6e9846f3e443925a7bbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
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
#line 2 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\_ViewImports.cshtml"
using SSproject2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\_ViewImports.cshtml"
using SSproject2.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\_ViewImports.cshtml"
using SSproject2.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\_ViewImports.cshtml"
using SSproject2.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c9b36e49427cb4fd0e6e9846f3e443925a7bbe", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c0469fc72773716bb39ab45bfe593ec1031915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n");
#nullable restore
#line 2 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Home\Admin.cshtml"
   
    ViewBag.Title = "???????????????????????????????? ????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>?????????? ????????</h1>\r\n<div>\r\n    ");
#nullable restore
#line 7 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Home\Admin.cshtml"
Write(Html.ActionLink("?????????????????????????? ??????????????", "Index", "Home", new { area = "Admin"}, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Home\Admin.cshtml"
Write(Html.ActionLink("?????????? ??????", "Index", "Home", new { area = "OtdelSMI" }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Home\Admin.cshtml"
Write(Html.ActionLink("???????? ????????????????", "Index", "Home", new { area = "Curator" }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
