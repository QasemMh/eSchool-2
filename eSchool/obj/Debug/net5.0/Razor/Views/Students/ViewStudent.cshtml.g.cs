#pragma checksum "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329eb7f1cbd5e4bf59aaa7475fbc0e918e01302b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_ViewStudent), @"mvc.1.0.view", @"/Views/Students/ViewStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"329eb7f1cbd5e4bf59aaa7475fbc0e918e01302b", @"/Views/Students/ViewStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6e58c5598a6ccfc88fbb12991fb2ce3f894c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_ViewStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Parents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
  
    ViewData["Title"] = "ViewStudent";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h3 class=""h3 mb-0 text-gray-800"">View Student Details</h3>
</div>



<!-- DataTales Example -->
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3 d-flex flex-wrap justify-content-between align-items-center"">
                <h6 class=""m-0 font-weight-bold text-primary"">
                    Student Details | ");
#nullable restore
#line 23 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                 Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h6>
            </div>
            <div class=""card-body"">
                <div class=""card shadow mb-4"">
                    <!-- Card Header - Accordion account -->
                    <a href=""#collapseCardExample"" class=""d-block card-header py-3"" data-toggle=""collapse"" role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Account Details</h6>
                    </a>
                    <!-- Card Content - Collapse -->
                    <div class=""collapse show"" id=""collapseCardExample""");
            BeginWriteAttribute("style", " style=\"", 1263, "\"", 1271, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    Username
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 40 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                            </dl>
                        </div>
                    </div>
                </div>
                <!--profile-->
                <div class=""card shadow mb-4"">
                    <!-- Card Header - Accordion -->
                    <a href=""#collapseCardExample2"" class=""d-block card-header py-3"" data-toggle=""collapse"" role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Student Details</h6>
                    </a>
                    <!-- Card Content - Collapse -->
                    <div class=""collapse show"" id=""collapseCardExample2""");
            BeginWriteAttribute("style", " style=\"", 2336, "\"", 2344, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    National Id
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 60 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.NationalId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    First Name
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 66 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Mid Name
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 72 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Last Name
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 78 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Gender
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 84 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                Write(Model.Gender=='M'?"Male":"Female");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Date of Birth
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 90 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.DateBirth.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Class
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 96 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.Class.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n");
#nullable restore
#line 104 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                 if (Model.ParentId != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!--Parent Information-->
                    <div class=""card shadow mb-4"">
                        <!-- Card Header - Accordion -->
                        <a href=""#collapseCardExample4"" class=""d-block card-header py-3"" data-toggle=""collapse"" role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                            <h6 class=""m-0 font-weight-bold text-primary"">Parent Details</h6>
                        </a>
                        <!-- Card Content - Collapse -->
                        <div class=""collapse show"" id=""collapseCardExample4""");
            BeginWriteAttribute("style", " style=\"", 5303, "\"", 5311, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""card-body"">
                                <dl class=""row"">
                                    <dt class=""col-sm-2"">
                                        National Id
                                    </dt>
                                    <dd class=""col-sm-10"">
                                        ");
#nullable restore
#line 120 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                   Write(Model.Parent.NationalId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-2"">
                                        Name
                                    </dt>
                                    <dd class=""col-sm-10"">
                                        ");
#nullable restore
#line 126 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                   Write(Model.Parent.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 126 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                                           Write(Model.Parent.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 126 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                                                                 Write(Model.Parent.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-2"">
                                        Date Of Birth
                                    </dt>
                                    <dd class=""col-sm-10"">
                                        ");
#nullable restore
#line 132 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                   Write(Model.Parent.DateBirth.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </dd>
                                    <dt class=""col-sm-2"">
                                        Gender
                                    </dt>
                                    <dd class=""col-sm-10"">
                                        ");
#nullable restore
#line 138 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                    Write(Model.Parent.Gender=='M'?"Male":"Female");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 144 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!--Parent Information-->
                    <div class=""card shadow mb-4"">
                        <!-- Card Header - Accordion -->
                        <a href=""#collapseCardExample4"" class=""d-block card-header py-3"" data-toggle=""collapse"" role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                            <h6 class=""m-0 font-weight-bold text-primary"">Parent Details</h6>
                        </a>
                        <!-- Card Content - Collapse -->
                        <div class=""collapse show"" id=""collapseCardExample4""");
            BeginWriteAttribute("style", " style=\"", 7585, "\"", 7593, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-body\">\r\n                                <div class=\"alert alert-warning\" role=\"alert\">\r\n                                    No Parent Information Found!\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "329eb7f1cbd5e4bf59aaa7475fbc0e918e01302b19336", async() => {
                WriteLiteral("Add a Parent For Student?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 164 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!--Contact-->
                <div class=""card shadow mb-4"">
                    <!-- Card Header - Accordion -->
                    <a href=""#collapseCardExample3"" class=""d-block card-header py-3"" data-toggle=""collapse"" role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Student Contact Details</h6>
                    </a>
                    <!-- Card Content - Collapse -->
                    <div class=""collapse show"" id=""collapseCardExample3""");
            BeginWriteAttribute("style", " style=\"", 8682, "\"", 8690, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    Address
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 179 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.Address.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Additional Information
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 185 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.Address.Address2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 185 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                                         Write(Model.Address.District);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 185 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                                                                                   Write(Model.Address.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Email
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 191 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Phone
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 197 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"card-footer text-muted\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "329eb7f1cbd5e4bf59aaa7475fbc0e918e01302b25051", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 207 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Students\ViewStudent.cshtml"
                         WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "329eb7f1cbd5e4bf59aaa7475fbc0e918e01302b27529", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
