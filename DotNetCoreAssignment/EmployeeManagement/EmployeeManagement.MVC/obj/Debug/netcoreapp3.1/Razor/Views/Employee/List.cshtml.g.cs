#pragma checksum "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f20b933dd1d60c53391016a2c036228d84e272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_List), @"mvc.1.0.view", @"/Views/Employee/List.cshtml")]
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
#line 1 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\_ViewImports.cshtml"
using EmployeeManagement.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\_ViewImports.cshtml"
using EmployeeManagement.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f20b933dd1d60c53391016a2c036228d84e272", @"/Views/Employee/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3232fbd0cfffe2f751b1f821f0b0419b56ee9a0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employeemanagement.Model.EmployeeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employee List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f20b933dd1d60c53391016a2c036228d84e2724194", async() => {
                WriteLiteral("<i class=\"fa fa-plus\" aria-hidden=\"true\"></i> Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordred table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IsManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Actions\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2480, "\"", 2540, 1);
#nullable restore
#line 77 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
WriteAttributeValue("", 2487, Url.Action("Edit", "Employee", new { id = item.ID }), 2487, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fa fa-pencil\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2622, "\"", 2685, 1);
#nullable restore
#line 78 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
WriteAttributeValue("", 2629, Url.Action("Details", "Employee", new { id = item.ID }), 2629, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\"><i class=\"fa fa-info\"></i> </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2763, "\"", 2825, 1);
#nullable restore
#line 79 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
WriteAttributeValue("", 2770, Url.Action("Delete", "Employee", new { id = item.ID }), 2770, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "D:\OldGit\Assignment\DotNetCoreAssignment\EmployeeManagement\EmployeeManagement.MVC\Views\Employee\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employeemanagement.Model.EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
