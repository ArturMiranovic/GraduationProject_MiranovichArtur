#pragma checksum "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d17d2196614450fb2010781e8ca532bcdfb4215c"
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
#line 1 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\_ViewImports.cshtml"
using WebApplication_Artur;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\_ViewImports.cshtml"
using WebApplication_Artur.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
using WebApplication_Artur.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17d2196614450fb2010781e8ca532bcdfb4215c", @"/Views/User/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80de5be12a25a70b157385ccbe468af154412605", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 9 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"infoDelUser\">\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 209, "\"", 227, 1);
#nullable restore
#line 13 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 215, user.Awatar, 215, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"logoUsersAll\" />\r\n\r\n            <div class=\"oneUserDelet\">\r\n\r\n                <div class=\"oneUserDeletText\">\r\n                    ");
#nullable restore
#line 18 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
               Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 18 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                           Write(user.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"widthDownload\">\r\n\r\n");
#nullable restore
#line 25 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                 if (user.MyBikes.Count() > 0)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 576, "\"", 612, 2);
            WriteAttributeValue("", 583, "/User/DowlondBike?id=", 583, 21, true);
#nullable restore
#line 29 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 604, user.Id, 604, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"linqCollor\">\r\n\r\n                        <img src=\"/image/defolt/imputDownload.png\" alt=\"Alternate Text\" class=\"download\" />\r\n\r\n                    </a>\r\n");
#nullable restore
#line 34 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        Нет товаров\r\n                    </div>     \r\n");
#nullable restore
#line 40 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"muwInputDelet\">\r\n\r\n");
#nullable restore
#line 46 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                 if (userService.IsDontAnminMyUser(user.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1120, "\"", 1153, 2);
            WriteAttributeValue("", 1127, "/User/RemoveMy?id=", 1127, 18, true);
#nullable restore
#line 48 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 1145, user.Id, 1145, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imputDelet\">\r\n                        <img src=\"/image/defolt/Delete2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1236, "\"", 1288, 1);
#nullable restore
#line 49 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
WriteAttributeValue("", 1242, WebApplication_Artur.Localize.Lang.DeleteUser, 1242, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"logoUsersDel\" id=\"1\" />\r\n                    </a>\r\n");
#nullable restore
#line 51 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 56 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserService userService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
