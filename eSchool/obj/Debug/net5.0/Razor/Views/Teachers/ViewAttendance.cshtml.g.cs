#pragma checksum "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_ViewAttendance), @"mvc.1.0.view", @"/Views/Teachers/ViewAttendance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea", @"/Views/Teachers/ViewAttendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6e58c5598a6ccfc88fbb12991fb2ce3f894c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Teachers_ViewAttendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewAttendanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teachers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "subjectId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("subjectId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAttendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/select2/js/select2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
  
    ViewData["Title"] = "ViewAttendance";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2><i class=""fas fa-calendar-check""></i> View Attendance</h2>
<hr />

<div class=""row"">
    <div class=""col-xl-3 col-md-6 col-sm-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Class
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 19 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                                                       Write(Model.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-graduation-cap fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>  <div class=""col-xl-3 col-md-6 col-sm-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Subject Name
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 35 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                                                       Write(Model.SubjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-book fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>  <div class=""col-xl-3 col-md-6 col-sm-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Subject Time
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 51 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                                                       Write(Model.SubjectTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clock fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
");
#nullable restore
#line 63 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
     if (!Model.NoLessons)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-12 col-xl-9"">
            <div class=""card shadow mb-4"">
                <div class=""card-header py-3 d-flex flex-wrap justify-content-between align-items-center"">
                    <h6 class=""m-0 font-weight-bold text-primary"">
                        Last Attendance Date: ");
#nullable restore
#line 69 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                         Write(Model.LessonDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h6>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th scope=""col""> Name</th>
                                    <th scope=""col"">Today Status</th>
                                    <th scope=""col""> Total Attendance</th>
                                    <th scope=""col""> Total Absence</th>
                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <th scope=""col""> Name</th>
                                    <th scope=""col"">Today Status</th>
                                    <th scope=""col""> Total Attendance</th>
                                    <th scope=""col");
            WriteLiteral("\"> Total Absence</th>\r\n                                </tr>\r\n                            </tfoot>\r\n                            <tbody>\r\n\r\n");
#nullable restore
#line 93 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                 foreach (var item in Model.StudentsAttends)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 96 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                       Write(item.Student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 96 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                                               Write(item.Student.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 96 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                                                                     Write(item.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"d-flex justify-content-center align-items-center\">\r\n");
#nullable restore
#line 98 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                             if (item.Status.Equals(AttendanceStatus.Present.ToString()))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"attend-status rounded bg-success\">\r\n                                                    ");
#nullable restore
#line 101 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n");
#nullable restore
#line 103 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                            }
                                            else if (item.Status.Equals(AttendanceStatus.Absent.ToString()))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"attend-status rounded bg-danger\">\r\n                                                    ");
#nullable restore
#line 107 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n");
#nullable restore
#line 109 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"attend-status rounded bg-secondary\">\r\n                                                    ");
#nullable restore
#line 113 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n");
#nullable restore
#line 115 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 117 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                       Write(item.TotalAttendances);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 118 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                       Write(item.TotalAbsences);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 120 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-footer text-muted\">\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 135 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-8\">\r\n            <div class=\"alert alert-warning\" role=\"alert\">\r\n                No Lesson Or Attendance Found, Show ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea19163", async() => {
                WriteLiteral("Course List");
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
            WriteLiteral(" To Take Attendance\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 145 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""col-md-6  col-xl-3"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3 d-flex flex-wrap justify-content-between align-items-center"">
                <h6 class=""m-0 font-weight-bold text-primary"">
                    Filter List By
                </h6>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea21240", async() => {
                WriteLiteral(@"
                <div class=""card-body overflow-hidden"">
                    <div class=""row align-content-center"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label for=""subjectId"">Course</label>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea21831", async() => {
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea22136", async() => {
                        WriteLiteral("---select Subject---");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 161 "C:\Users\user\source\repos\MyGraduationProject\eSchool\eSchool\Views\Teachers\ViewAttendance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.subjects;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""card-footer text-muted"">
                    <button class=""btn btn-outline-success"">
                        <i class=""fas fa-sort-alpha-up""></i> Filter
                    </button>
                    <button class=""btn btn-outline-secondary"" id=""resetBtn"">
                        <i class=""fas fa-undo""></i> Reset
                    </button>
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ea2fb4a1d113c7c9b17fd03a08a6783f1696ea27279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        $(\"#subjectId\").select2();\r\n\r\n        $(\"#resetBtn\").on(\"click\", function () {\r\n            $(\"select\").each(function () {\r\n                $(this).prop(\'selectedIndex\', 0);\r\n            })\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewAttendanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591