#pragma checksum "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a498da7cfa672792ac5e5cf5e2833e53a01ed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a498da7cfa672792ac5e5cf5e2833e53a01ed7", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c0469fc72773716bb39ab45bfe593ec1031915", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"footer-wrapper\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n       \r\n                <div id=\"copyright\">\r\n                    &copy; ");
#nullable restore
#line 7 "C:\Users\Brux\Desktop\SSproject2\SSproject2\Views\Shared\FooterPartial.cshtml"
                      Write(Config.SSproject2Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <h1> <a style=""color:cornflowerblue"" href=""https://drive.google.com/file/d/1v0DlJtfeTNYOjxbaPdP9chVa2ke-0lrH/view?usp=sharing""> ???????????? ???? ??????, ?????????????????????????????? ?????? ??????????????</a></h1>
                </div>

            </div>
        </div>
    </div>
</div>");
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
