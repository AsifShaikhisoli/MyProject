#pragma checksum "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efd41344e297540742167e3f9c8c6e96b3d5bf60"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoProject_CrudBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using DemoProject_CrudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\_Imports.razor"
using DemoProject_CrudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
using DemoProject_CrudBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"btn btn-primary btn-block\">Add Employee</h2>\r\n<hr>\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "placeholder", "Enter your name");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
                                                                                                      objemp.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objemp.Name = __value, objemp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n                    <label for=\"Gender\" class=\"control-label\"></label>\r\n                    ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
                                    objemp.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objemp.Gender = __value, objemp.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", true);
            __builder.AddContent(31, "--Select Gender--");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "Male");
            __builder.AddContent(35, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "Female");
            __builder.AddContent(39, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.AddMarkupContent(46, "<label for=\"City\" class=\"control-label\">City</label>\r\n                    ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "form", "City");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.AddAttribute(50, "placeholder", "Enter your city");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
                                                                                                 objemp.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objemp.City = __value, objemp.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.AddMarkupContent(58, "<label for=\"Country\" class=\"control-label\">Country</label>\r\n                    ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "form", "Country");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "placeholder", "Enter your country");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
                                                                                                       objemp.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objemp.Country = __value, objemp.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-md-4");
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", " form-group");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "class", "btn btn-primary");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
                                                                            CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "button");
            __builder.AddAttribute(86, "class", "btn btn-info");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
                                                                         Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\Asp.Net Core Blazor Project\DemoProject_CrudBlazor\DemoProject_CrudBlazor\Pages\AddEmployee.razor"
       
    Employeeinfo objemp = new Employeeinfo();

    private void CreateEmployee()
    {
        objEmpService.Create(objemp);
        NavigationManager.NavigateTo("Employee");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employee");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService objEmpService { get; set; }
    }
}
#pragma warning restore 1591
