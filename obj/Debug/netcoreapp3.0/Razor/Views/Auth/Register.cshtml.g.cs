#pragma checksum "C:\Users\c0pis\Desktop\Torus Tile\Torus Tile\Views\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9641980ede898aa89ba820ffc70c9ca2b35b081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Register), @"mvc.1.0.view", @"/Views/Auth/Register.cshtml")]
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
#line 1 "C:\Users\c0pis\Desktop\Torus Tile\Torus Tile\Views\_ViewImports.cshtml"
using Torus_Tile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\c0pis\Desktop\Torus Tile\Torus Tile\Views\_ViewImports.cshtml"
using Torus_Tile.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9641980ede898aa89ba820ffc70c9ca2b35b081", @"/Views/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609e66c6c8fd51ae319720995d05abac03521b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Auth/Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\c0pis\Desktop\Torus Tile\Torus Tile\Views\Auth\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Register</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9641980ede898aa89ba820ffc70c9ca2b35b0814514", async() => {
                WriteLiteral(@"
            <h4>Create a new account.</h4>
            <hr />
            <div class=""text-danger validation-summary-valid"" data-valmsg-summary=""true"">
                <ul>
                    <li style=""display:none""></li>
                </ul>
            </div>
            <div class=""form-group"">
                <label for=""Input_Email"">Email</label>
                <input class=""form-control"" type=""email"" data-val=""true"" data-val-email=""The Email field is not a valid e-mail address."" data-val-required=""The Email field is required."" id=""Input_Email"" name=""Input.Email""");
                BeginWriteAttribute("value", " value=\"", 775, "\"", 783, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.Email"" data-valmsg-replace=""true""></span>
            </div>
            <div class=""form-group"">
                <label for=""Input_Password"">Password</label>
                <input class=""form-control"" type=""password"" data-val=""true"" data-val-length=""The Password must be at least 6 and at max 100 characters long."" data-val-length-max=""100"" data-val-length-min=""6"" data-val-required=""The Password field is required."" id=""Input_Password"" maxlength=""100"" name=""Input.Password"" />
                <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.Password"" data-valmsg-replace=""true""></span>
            </div>
            <div class=""form-group"">
                <label for=""Input_ConfirmPassword"">Confirm password</label>
                <input class=""form-control"" type=""password"" data-val=""true"" data-val-equalto=""The password and confirmation password do not match."" data-val-equalto-other=""*.Pas");
                WriteLiteral(@"sword"" id=""Input_ConfirmPassword"" name=""Input.ConfirmPassword"" />
                <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.ConfirmPassword"" data-valmsg-replace=""true""></span>
            </div>
            <button id=""registerSubmit"" type=""submit"" class=""btn btn-primary"">Register</button>
            <input name=""__RequestVerificationToken"" type=""hidden"" value=""CfDJ8KgGP7T9jV1HhZdikl_gD-fSzoYUImqd8K96CQVDx9lBFdhaHYM9IxxbrTJX0-NiiNg3kaguAoPy6UuR-rXliS0XikI46uSSKucYXAeBPAQCZfjHAB183b0L5xpeT9zG3VJjiTv3MybW0eNpFVySpj0"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-6 col-md-offset-2"">
        <section>
            <h4>Use another service to register.</h4>
            <hr />
            <div>
                <p>
                    There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                    for details on setting up this ASP.NET application to support logging in via external services.
                </p>
            </div>
        </section>
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