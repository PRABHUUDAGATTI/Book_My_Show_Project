#pragma checksum "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5cb331fb9c16a836b46c0b0bd2d8530b71f103fcf475534c3881566fc6d5b1e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDetails_DeleteUser), @"mvc.1.0.view", @"/Views/UserDetails/DeleteUser.cshtml")]
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
#line 1 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\_ViewImports.cshtml"
using MovieCoreMVC_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\_ViewImports.cshtml"
using MovieCoreMVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5cb331fb9c16a836b46c0b0bd2d8530b71f103fcf475534c3881566fc6d5b1e4", @"/Views/UserDetails/DeleteUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"12b3f186724a0666cff5fb6a8c0d0b03709ec8185f86f6ede0d57093c9d0133c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UserDetails_DeleteUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_Show_Entity.UserDetails>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("enter a movie name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
  
    ViewData["Title"] = "DeleteUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DeleteUser</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb331fb9c16a836b46c0b0bd2d8530b71f103fcf475534c3881566fc6d5b1e45899", async() => {
                WriteLiteral("\r\n    <h2>Delete Movie</h2><hr />\r\n    <div class=\"form-group\">\r\n        <label>Movie Id</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cb331fb9c16a836b46c0b0bd2d8530b71f103fcf475534c3881566fc6d5b1e46293", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-success\" />\r\n    <input type=\"reset\" value=\"Reset\" class=\"btn btn-outline-secondary\" />\r\n    <hr />\r\n");
#nullable restore
#line 17 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
     if (ViewBag.status == "Ok")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-success\">");
#nullable restore
#line 19 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
                                    Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
    }
    else if (ViewBag.status == "Error")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-danger\">");
#nullable restore
#line 23 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
                                   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 24 "C:\Users\PRABHU UDAGATTI\OneDrive\Desktop\Prabhu_Private\IT\Projects\.net_Project\Book_My_Show\Book_My_Show_Project\Book_My_Movie_show\MovieCoreMVC_UI\Views\UserDetails\DeleteUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_Show_Entity.UserDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
