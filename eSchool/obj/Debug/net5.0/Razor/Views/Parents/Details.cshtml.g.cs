#pragma checksum "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f093e1b3a21852c360a82942de309c794ac0883c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parents_Details), @"mvc.1.0.view", @"/Views/Parents/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f093e1b3a21852c360a82942de309c794ac0883c", @"/Views/Parents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6e58c5598a6ccfc88fbb12991fb2ce3f894c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Parents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Parent Details</h2>
<hr />
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""card shadow"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Parent Details</h6>
            </div>
            <div class=""card-body"">
                <dl class=""row"">
                    <dt class=""col-sm-4"">
                        National Id
                    </dt>
                    <dd class=""col-sm-8"">
                        ");
#nullable restore
#line 23 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                   Write(Model.NationalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Full Name\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                    Write(Model.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                                   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Gender\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                    Write(Model.Gender=='M'?"Male":"Female");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Date of brith\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                   Write(Model.DateBirth.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"card-footer text-muted\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f093e1b3a21852c360a82942de309c794ac0883c8841", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f093e1b3a21852c360a82942de309c794ac0883c11124", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
     if (Model.Students.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-12 mt-4\">\r\n            <h3 class=\"mt-2 mb-2\">Children Information (");
#nullable restore
#line 55 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                                   Write(Model.Students.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Children)</h3>\r\n            <hr />\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 58 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                 foreach (var item in Model.Students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 mb-3"">

                        <div class=""card shadow"">
                            <div class=""card-header py-3"">
                                <h6 class=""m-0 font-weight-bold text-primary"">Children Details</h6>
                            </div>
                            <div class=""card-body"">
                                <dl class=""row"">
                                    <dt class=""col-sm-4"">
                                        National Id
                                    </dt>
                                    <dd class=""col-sm-8"">
                                        ");
#nullable restore
#line 72 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                   Write(item.NationalId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-4"">
                                        Full Name
                                    </dt>
                                    <dd class=""col-sm-8"">
                                        ");
#nullable restore
#line 78 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 78 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                                   Write(item.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 78 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                                                 Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-4"">
                                        Gender
                                    </dt>
                                    <dd class=""col-sm-8"">
                                        ");
#nullable restore
#line 84 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                    Write(item.Gender=='M'?"Male":"Female");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-4"">
                                        Date of brith
                                    </dt>
                                    <dd class=""col-sm-8"">
                                        ");
#nullable restore
#line 90 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                   Write(item.DateBirth.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-4"">
                                        Class
                                    </dt>
                                    <dd class=""col-sm-8"">
                                        ");
#nullable restore
#line 96 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                   Write(item.Class.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n                            </div>\r\n                            <div class=\"card-footer text-muted\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f093e1b3a21852c360a82942de309c794ac0883c17451", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 107 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 111 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"alert alert-warning m-2\" role=\"alert\">\r\n                <h4");
            BeginWriteAttribute("class", " class=\"", 4712, "\"", 4720, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-exclamation-triangle\"></i> No Children Found!</h4>\r\n                <p>\r\n                    There is no Student Link With This Parent\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 122 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Parents\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parent> Html { get; private set; }
    }
}
#pragma warning restore 1591
