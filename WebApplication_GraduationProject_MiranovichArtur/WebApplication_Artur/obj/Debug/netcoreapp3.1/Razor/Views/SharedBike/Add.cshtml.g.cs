#pragma checksum "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5cef94132fe68983d8095896b19a87ea53e931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SharedBike_Add), @"mvc.1.0.view", @"/Views/SharedBike/Add.cshtml")]
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
#line 1 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\_ViewImports.cshtml"
using WebApplication_Artur;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\_ViewImports.cshtml"
using WebApplication_Artur.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5cef94132fe68983d8095896b19a87ea53e931", @"/Views/SharedBike/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80de5be12a25a70b157385ccbe468af154412605", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SharedBike_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddSharedBikeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SharedBike/Add?"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5cef94132fe68983d8095896b19a87ea53e9314051", async() => {
                WriteLiteral(@"

    <style type=""text/css"">
        .pooof {
            display: none;
        }

        .addOneSharedBike {
            padding: 10px;
        }

        .addBlock {
            margin: 30px;
            background: #d1e6f1;
            display: block;
            width: fit-content;
            justify-content: center;
            align-content: flex-start;
            flex-wrap: nowrap;
            border-radius: 8px;
            box-shadow: 5px 4px 6px 0px #25448233;
        }

        .inputaddBlock {
            background-color: #eff3f8;
            font-family: cursive;
            color: #86b7e1;
            width: 100%;
            border-radius: 4px;
        }

        .inputaddBlock:hover {
            background-color: #86b7e1;
            color: #eff3f8;
        }


    </style>

    <div class=""addBlock"">

        <input class=""pooof"" name=""BikeId""");
                BeginWriteAttribute("value", " value=", 999, "", 1019, 1);
#nullable restore
#line 44 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
WriteAttributeValue("", 1006, Model.BikeId, 1006, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input class=\"pooof\" name=\"Id\"");
                BeginWriteAttribute("value", " value=", 1062, "", 1079, 2);
#nullable restore
#line 45 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
WriteAttributeValue("", 1069, Model.Id, 1069, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1078, ")", 1078, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n        <div class=\"addOneSharedBike\">\r\n            ");
#nullable restore
#line 49 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
       Write(Html.EditorFor(x => x.Size));

#line default
#line hidden
#nullable disable
                WriteLiteral("  - рвзмер рамы.\r\n        </div>\r\n\r\n        <div class=\"addOneSharedBike\">\r\n            ");
#nullable restore
#line 53 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
       Write(Html.EditorFor(x => x.RearChainrings));

#line default
#line hidden
#nullable disable
                WriteLiteral("  - количество задних звёзд.\r\n        </div>\r\n\r\n        <div class=\"addOneSharedBike\">\r\n            ");
#nullable restore
#line 57 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
       Write(Html.EditorFor(x => x.FrontChainrings));

#line default
#line hidden
#nullable disable
                WriteLiteral("  - количество передних звёзд.\r\n        </div>\r\n\r\n        <div class=\"addOneSharedBike\">\r\n            ");
#nullable restore
#line 61 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
       Write(Html.EditorFor(x => x.WheelDiametr));

#line default
#line hidden
#nullable disable
                WriteLiteral("  - диаметр колёс.\r\n        </div>\r\n\r\n        <div class=\"addOneSharedBike\">\r\n            ");
#nullable restore
#line 65 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\SharedBike\Add.cshtml"
       Write(Html.EditorFor(x => x.BrakeDiametr));

#line default
#line hidden
#nullable disable
                WriteLiteral("  - диаметр тормозов.\r\n        </div>\r\n\r\n        <div class=\"addOneSharedBike\">\r\n            <input type=\"submit\" value=\"применить\" class=\"inputaddBlock\" />\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddSharedBikeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
