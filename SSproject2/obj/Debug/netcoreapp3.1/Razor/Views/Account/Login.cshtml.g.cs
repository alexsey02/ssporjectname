#pragma checksum "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f13425e4b26a326416442847ee29cb523dbdbfb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 2 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\_ViewImports.cshtml"
using SSproject2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13425e4b26a326416442847ee29cb523dbdbfb0", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6c5fed5d279769af6de0a5f2475ffc96f19008", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h1>Вход в личный кабинет</h1>\r\n    <div class=\"div-box\">\r\n        <form");
            BeginWriteAttribute("asp-area", " asp-area=\"", 106, "\"", 117, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Account\" asp-action=\"Login\" method=\"post\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 176, "\"", 216, 1);
#nullable restore
#line 5 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 198, ViewBag.returnUrl, 198, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div asp-validation-summary=\"All\"></div>\r\n            <div>\r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 315, "\"", 342, 1);
#nullable restore
#line 8 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 325, ViewBag.UserName, 325, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 376, "\"", 403, 1);
#nullable restore
#line 9 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 386, ViewBag.UserName, 386, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 430, "\"", 468, 1);
#nullable restore
#line 10 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 451, ViewBag.UserName, 451, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n            </div>\r\n            <div>\r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 540, "\"", 567, 1);
#nullable restore
#line 13 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 550, ViewBag.Password, 550, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 601, "\"", 628, 1);
#nullable restore
#line 14 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 611, ViewBag.Password, 611, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 655, "\"", 693, 1);
#nullable restore
#line 15 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 676, ViewBag.Password, 676, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n            </div>\r\n            <div>\r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 765, "\"", 794, 1);
#nullable restore
#line 18 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 775, ViewBag.RememberMe, 775, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 828, "\"", 857, 1);
#nullable restore
#line 19 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 838, ViewBag.RememberMe, 838, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 884, "\"", 924, 1);
#nullable restore
#line 20 "C:\Users\Brux\source\repos\SSproject2\SSproject2\Views\Account\Login.cshtml"
WriteAttributeValue("", 905, ViewBag.RememberMe, 905, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n            </div>\r\n            <div>\r\n                <input type=\"submit\" value=\"Войти\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
