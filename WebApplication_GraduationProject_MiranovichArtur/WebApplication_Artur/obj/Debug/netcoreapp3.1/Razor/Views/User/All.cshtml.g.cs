#pragma checksum "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5fd6d6f759aa4395fca37b2f17941664c346188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_All), @"mvc.1.0.view", @"/Views/User/All.cshtml")]
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
#line 1 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\_ViewImports.cshtml"
using WebApplication_Artur;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\_ViewImports.cshtml"
using WebApplication_Artur.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5fd6d6f759aa4395fca37b2f17941664c346188", @"/Views/User/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80de5be12a25a70b157385ccbe468af154412605", @"/Views/_ViewImports.cshtml")]
    public class Views_User_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserForRemoveVieqModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 6 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 116, "\"", 134, 1);
#nullable restore
#line 10 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 122, user.Awatar, 122, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"logoBikeGalerey\" />\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 176, "\"", 194, 1);
#nullable restore
#line 11 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 182, user.Awatar, 182, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Awatar\" />\r\n\r\n        ");
#nullable restore
#line 13 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
   Write(user.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 237, "\"", 269, 3);
            WriteAttributeValue("", 244, "/User/Remove?id=", 244, 16, true);
#nullable restore
#line 13 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 260, user.Id, 260, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 268, "&", 268, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                                                   Write(WebApplication_Artur.Localize.Lang.DeleteUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 15 "D:\GraduationProject\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserForRemoveVieqModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
