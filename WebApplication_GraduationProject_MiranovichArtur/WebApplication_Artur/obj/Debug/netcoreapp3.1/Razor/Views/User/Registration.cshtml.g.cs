#pragma checksum "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d39625cef39cae08110de1b57857fa086ee97b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Registration), @"mvc.1.0.view", @"/Views/User/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d39625cef39cae08110de1b57857fa086ee97b16", @"/Views/User/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80de5be12a25a70b157385ccbe468af154412605", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserRegistrationViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/registration.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/Registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39625cef39cae08110de1b57857fa086ee97b164682", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39625cef39cae08110de1b57857fa086ee97b165843", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 13 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(WebApplication_Artur.Localize.Lang.YourName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"textBox\">\r\n            ");
#nullable restore
#line 17 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(Html.TextBoxFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 26 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(WebApplication_Artur.Localize.Lang.SpecifyMail);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"textBox\">\r\n            ");
#nullable restore
#line 30 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(Html.TextBoxFor(x => x.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(Html.ValidationMessageFor(x => x.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div>\r\n\r\n        <div class=\"textBox\">\r\n            ");
#nullable restore
#line 39 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(WebApplication_Artur.Localize.Lang.PickAPassword);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"textBox\">\r\n            ");
#nullable restore
#line 43 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(Html.TextBoxFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 44 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
       Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"inutRegistration\">\r\n        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1048, "\"", 1100, 1);
#nullable restore
#line 50 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\User\Registration.cshtml"
WriteAttributeValue("", 1056, WebApplication_Artur.Localize.Lang.Register, 1056, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserRegistrationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
