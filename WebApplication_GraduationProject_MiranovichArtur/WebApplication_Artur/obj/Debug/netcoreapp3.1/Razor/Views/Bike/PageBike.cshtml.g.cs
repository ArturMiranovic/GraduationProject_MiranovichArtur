#pragma checksum "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae3b037b6f56400ebb8b4d9904e1b258e40ac244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bike_PageBike), @"mvc.1.0.view", @"/Views/Bike/PageBike.cshtml")]
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
#nullable restore
#line 1 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
using WebApplication_Artur.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae3b037b6f56400ebb8b4d9904e1b258e40ac244", @"/Views/Bike/PageBike.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80de5be12a25a70b157385ccbe468af154412605", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bike_PageBike : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/defolt/Delete2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bikeDel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Bike/UpdatePrice?"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n    <div class=\"pageBikeName-Delete\">\r\n\r\n        <div class=\"pageBikeName\">\r\n            Модель велосипеда - ");
#nullable restore
#line 10 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n");
#nullable restore
#line 13 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
         if (userService.IsAdminOrOwner(Model.Id))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"bikeDeket\">\r\n                <a class=\"linqCollor\"");
            BeginWriteAttribute("href", " href=\"", 383, "\"", 415, 2);
            WriteAttributeValue("", 390, "/Bike/Remove?id=", 390, 16, true);
#nullable restore
#line 16 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
WriteAttributeValue("", 406, Model.Id, 406, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae3b037b6f56400ebb8b4d9904e1b258e40ac2446787", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
AddHtmlAttributeValue("", 482, WebApplication_Artur.Localize.Lang.DeleteUser, 482, 46, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 20 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"pageBikeContent\">\r\n\r\n        <div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 692, "\"", 709, 1);
#nullable restore
#line 26 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
WriteAttributeValue("", 698, Model.Page, 698, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Page\" class=\"bigPageBike\" />\r\n\r\n            <div class=\"change\">\r\n                редактировать фото\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"pageBikeInfo\">\r\n\r\n            <div>\r\n\r\n");
#nullable restore
#line 38 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                 if (@Model.BikeSize > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"change\">\r\n                        Размер рамы: ");
#nullable restore
#line 41 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                                Write(Model.BikeSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'\r\n                    </div>\r\n");
#nullable restore
#line 43 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                 if (@Model.WheelDiametr > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"change\">\r\n                        Размер колёс: ");
#nullable restore
#line 48 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                                 Write(Model.WheelDiametr);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм\r\n                    </div>\r\n");
#nullable restore
#line 50 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                 if (@Model.BrakeDiametr > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"change\">\r\n                        Тормозные диски: ");
#nullable restore
#line 55 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                                    Write(Model.BrakeDiametr);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм\r\n                    </div>\r\n");
#nullable restore
#line 57 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                 if (@Model.FrontChainrings > 0 || @Model.FrontChainrings > 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"change\">\r\n\r\n                        Количество передачь:\r\n\r\n");
#nullable restore
#line 66 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                         if (@Model.FrontChainrings > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                       Write(Model.RearChainrings);

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                                                 
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        /\r\n");
#nullable restore
#line 71 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                         if (@Model.FrontChainrings > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                       Write(Model.FrontChainrings);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                                                  
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 77 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n");
#nullable restore
#line 81 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
             if (userService.IsOwner(Model.Id))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <div class=\"bikeLing\">\r\n                        <a class=\"linqCollor\"");
            BeginWriteAttribute("href", " href=\"", 2363, "\"", 2398, 2);
            WriteAttributeValue("", 2370, "/SharedBike/Add?id=", 2370, 19, true);
#nullable restore
#line 85 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
WriteAttributeValue("", 2389, Model.Id, 2389, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">редактироваь ттх</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div>\r\n\r\n                <div class=\"changeThePrice\"> ");
#nullable restore
#line 93 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BYN </div>\r\n\r\n");
#nullable restore
#line 95 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                 if (userService.IsOwner(Model.Id))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"linqCollor\"");
            BeginWriteAttribute("href", " href=\"", 2701, "\"", 2738, 2);
            WriteAttributeValue("", 2708, "/Bike/UpdatePrice?id=", 2708, 21, true);
#nullable restore
#line 98 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
WriteAttributeValue("", 2729, Model.Id, 2729, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">изменить цену</a>\r\n");
#nullable restore
#line 99 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div>\r\n");
#nullable restore
#line 109 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
         foreach (var CommentUs in @Model.Comments)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                Имя юзера  ");
#nullable restore
#line 113 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                      Write(CommentUs.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                <div>\r\n                    Его комент ");
#nullable restore
#line 118 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                          Write(CommentUs.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div>\r\n                    Его комент ");
#nullable restore
#line 122 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
                          Write(CommentUs.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                -------------------------------\r\n            </div>\r\n");
#nullable restore
#line 129 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae3b037b6f56400ebb8b4d9904e1b258e40ac24419314", async() => {
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
                    ");
                WriteLiteral("color: #eff3f8;\r\n                }\r\n\r\n            </style>\r\n\r\n            <div class=\"addBlock\">\r\n\r\n                <input class=\"pooof\" name=\"idBike\"");
                BeginWriteAttribute("value", " value=", 4568, "", 4584, 1);
#nullable restore
#line 172 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
WriteAttributeValue("", 4575, Model.Id, 4575, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n                <div class=\"addOneSharedBike\">\r\n                    ");
#nullable restore
#line 176 "D:\It\C\bike\WebApplication_GraduationProject_MiranovichArtur\WebApplication_Artur\Views\Bike\PageBike.cshtml"
               Write(Html.EditorFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("  - новая цена.\r\n                </div>\r\n\r\n                <div class=\"addOneSharedBike\">\r\n                    <input type=\"submit\" value=\"обновить\" class=\"inputaddBlock\" />\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        комментарии\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
