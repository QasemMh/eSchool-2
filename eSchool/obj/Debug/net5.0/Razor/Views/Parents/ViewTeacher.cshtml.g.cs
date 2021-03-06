#pragma checksum "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ad771c6f2c91672675625fa8b5de6b3771b91f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parents_ViewTeacher), @"mvc.1.0.view", @"/Views/Parents/ViewTeacher.cshtml")]
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
#line 1 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\_ViewImports.cshtml"
using eSchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\_ViewImports.cshtml"
using eSchool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\_ViewImports.cshtml"
using eSchool.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\_ViewImports.cshtml"
using eSchool.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ad771c6f2c91672675625fa8b5de6b3771b91f", @"/Views/Parents/ViewTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6e58c5598a6ccfc88fbb12991fb2ce3f894c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Parents_ViewTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
  
    ViewData["Title"] = "View Teacher";
    Layout = "~/Views/Shared/_ParentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h3 class=""h3 mb-0 text-gray-800"">Teacher Details</h3>
</div>
<hr />

<div class=""row"">
    <div class=""col-md-12"">

        <div class=""card shadow"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Teacher Details</h6>
            </div>
            <div class=""card-body"">
                <dl class=""row"">

                    <dt class=""col-sm-4"">
                        First Name
                    </dt>
                    <dd class=""col-sm-8"">
                        ");
#nullable restore
#line 29 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Mid Name\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
                   Write(Model.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Last Name\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
                   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Username\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
                   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Gender\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
                    Write(Model.Gender=='M'?"Male":"Female");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </dd>
                </dl>
                <hr />
                <h5 class=""mb-2"">Concat Details</h5>
                <dl class=""row"">
                    <dt class=""col-sm-4"">
                        Email
                    </dt>
                    <dd class=""col-sm-8"">
                        <a class=""btn btn-outline-primary btn-sm""");
            BeginWriteAttribute("href", "\r\n                           href=\"", 2053, "\"", 2109, 2);
            WriteAttributeValue("", 2088, "mailto:", 2088, 7, true);
#nullable restore
#line 64 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
WriteAttributeValue("", 2095, Model.Email, 2095, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-external-link-alt""></i> Send Email</a>
                    </dd>
                    <dt class=""col-sm-4"">
                        Phone Number
                    </dt>
                    <dd class=""col-sm-8"">
                        <a class=""btn btn-outline-info btn-sm""");
            BeginWriteAttribute("href", "\r\n                           href=\"", 2408, "\"", 2461, 2);
            WriteAttributeValue("", 2443, "tel:", 2443, 4, true);
#nullable restore
#line 71 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
WriteAttributeValue("", 2447, Model.Phone, 2447, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-external-link-alt\"></i> Phone Call</a>\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ad771c6f2c91672675625fa8b5de6b3771b91f9353", async() => {
                WriteLiteral("<i class=\"fas fa-envelope\"></i> Send Message");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-toId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\ViewTeacher.cshtml"
                       WriteLiteral(Model.AccountId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-toId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
