#pragma checksum "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ce1b089ddcdb2f48c511f1bfa5e26fc170d797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bike_All), @"mvc.1.0.view", @"/Views/Bike/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ce1b089ddcdb2f48c511f1bfa5e26fc170d797", @"/Views/Bike/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80de5be12a25a70b157385ccbe468af154412605", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bike_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GalereyBikeViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"nameForFiltr\">\r\n\r\n    ссылка на фильтры\r\n\r\n</div>\r\n\r\n<div class=\"galerey-all-bike\">\r\n\r\n");
#nullable restore
#line 11 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
     foreach (var bike in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"invisibleFrame\">\r\n\r\n            <a class=\"linqCollor\"");
            BeginWriteAttribute("href", "  href=\"", 250, "\"", 288, 2);
            WriteAttributeValue("", 258, "/Bike/PageBike?idBike=", 258, 22, true);
#nullable restore
#line 15 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
WriteAttributeValue("", 280, bike.Id, 280, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <div class=\"galerey-one-bike\">\r\n\r\n                    <div>\r\n                        ");
#nullable restore
#line 20 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
                   Write(bike.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"imageBikeAll\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 513, "\"", 529, 1);
#nullable restore
#line 24 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
WriteAttributeValue("", 519, bike.Page, 519, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"logoBikeGalerey\"/>\r\n                    </div>\r\n\r\n                    <div>\r\n                        ");
#nullable restore
#line 28 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
                   Write(bike.BikeClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(" велосипед. \r\n                    </div>\r\n\r\n                    <div>\r\n                        ");
#nullable restore
#line 32 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
                   Write(bike.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 39 "F:\_IT - обучение\C#\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GalereyBikeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
