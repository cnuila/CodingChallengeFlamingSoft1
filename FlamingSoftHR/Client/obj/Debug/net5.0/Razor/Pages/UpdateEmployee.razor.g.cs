#pragma checksum "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b4fde8fba848752eb8d9c12c042682187f2c5e6"
// <auto-generated/>
#pragma warning disable 1591
namespace FlamingSoftHR.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class UpdateEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(4);
                    __builder3.AddAttribute(5, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(7);
                        __builder4.AddAttribute(8, "Label", "First Name");
                        __builder4.AddAttribute(9, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "RequiredError", "First Name is required");
                        __builder4.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 8 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                         Employee.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\n\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(14);
                    __builder3.AddAttribute(15, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(17);
                        __builder4.AddAttribute(18, "Label", "Middle Name");
                        __builder4.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 12 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                           Employee.MiddleName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.MiddleName = __value, Employee.MiddleName))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\n\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(22);
                    __builder3.AddAttribute(23, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(25);
                        __builder4.AddAttribute(26, "Label", "Last Name");
                        __builder4.AddAttribute(27, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "RequiredError", "Last Name is required");
                        __builder4.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 16 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                         Employee.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(32);
                    __builder3.AddAttribute(33, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(35, "div");
                        __builder4.AddAttribute(36, "class", "d-flex");
                        __builder4.OpenComponent<MudBlazor.MudRadioGroup<string>>(37);
                        __builder4.AddAttribute(38, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "RequiredError", "Employee type is required");
                        __builder4.AddAttribute(40, "SelectedOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                     employeeTypeDescription

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "SelectedOptionChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employeeTypeDescription = __value, employeeTypeDescription))));
                        __builder4.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 22 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         foreach (var employeeType in employeeTypes)
                        {

#line default
#line hidden
#nullable disable
                            __Blazor.FlamingSoftHR.Client.Pages.UpdateEmployee.TypeInference.CreateMudRadio_0(__builder5, 43, 44, 
#nullable restore
#line 24 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                               employeeType.Description

#line default
#line hidden
#nullable disable
                            , 45, (__builder6) => {
                                __builder6.AddContent(46, 
#nullable restore
#line 24 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                          employeeType.Description

#line default
#line hidden
#nullable disable
                                );
                            }
                            );
#nullable restore
#line 25 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                        }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(48);
                    __builder3.AddAttribute(49, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudSelect<string>>(51);
                        __builder4.AddAttribute(52, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 32 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                    OnSelectedValue

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 32 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                            departmentName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(55, "RequiredError", "A department must be selected");
                        __builder4.AddAttribute(56, "Label", "Department");
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 33 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                     foreach (var department in departments)
                    {

#line default
#line hidden
#nullable disable
                            __Blazor.FlamingSoftHR.Client.Pages.UpdateEmployee.TypeInference.CreateMudSelectItem_1(__builder5, 58, 59, 
#nullable restore
#line 35 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                               department.Name

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 36 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                    }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(61);
                    __builder3.AddAttribute(62, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudSelect<string>>(64);
                        __builder4.AddAttribute(65, "RequiredError", "A job must be selected");
                        __builder4.AddAttribute(66, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "Label", "Job");
                        __builder4.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 41 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                         jobDescription

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jobDescription = __value, jobDescription))));
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 42 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                     foreach (var job in jobs)
                    {

#line default
#line hidden
#nullable disable
                            __Blazor.FlamingSoftHR.Client.Pages.UpdateEmployee.TypeInference.CreateMudSelectItem_2(__builder5, 71, 72, 
#nullable restore
#line 44 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                               job.Description

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 45 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                    }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(74);
                    __builder3.AddAttribute(75, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                         5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.FlamingSoftHR.Client.Pages.UpdateEmployee.TypeInference.CreateMudNumericField_3(__builder4, 77, 78, "Salary", 79, 
#nullable restore
#line 50 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                        , 80, 
#nullable restore
#line 50 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                       Variant.Text

#line default
#line hidden
#nullable disable
                        , 81, 
#nullable restore
#line 50 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                                                Adornment.Start

#line default
#line hidden
#nullable disable
                        , 82, 
#nullable restore
#line 50 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                                                                                 Icons.Material.Filled.AttachMoney

#line default
#line hidden
#nullable disable
                        , 83, 
#nullable restore
#line 50 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                                                                                                                                                                                                     true

#line default
#line hidden
#nullable disable
                        , 84, 
#nullable restore
#line 50 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                                              Employee.Salary

#line default
#line hidden
#nullable disable
                        , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Salary = __value, Employee.Salary)));
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(86, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(87);
                __builder2.AddAttribute(88, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(92);
                __builder2.AddAttribute(93, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
                            Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(94, "Class", "red-text text-darken-3");
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(96, "Ok");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/UpdateEmployee.razor"
       
    [CascadingParameter]
    public MudDialogInstance MudDialog { get; set; }

    [Parameter]
    public Employee Employee { get; set; }

    [Inject]
    public IJobService JobService { get; set; }

    [Inject]
    public IDepartmentService DepartmentService { get; set; }

    [Inject]
    public IEmployeeTypeService EmployeeTypeService { get; set; }

    private List<Department> departments = new List<Department>();
    private List<Job> jobs = new List<Job>();
    private List<EmployeeType> employeeTypes = new List<EmployeeType>();
    private string departmentName { get; set; }
    private string jobDescription { get; set; }
    private string employeeTypeDescription { get; set; }

    protected async override Task OnInitializedAsync()
    {
        departments = (await DepartmentService.GetDepartments()).ToList();
        employeeTypes = (await EmployeeTypeService.GetEmployeeTypes()).ToList();
        jobs = (await JobService.GetJobsByDepartment(Employee.Job.DepartmentId)).ToList();

        jobDescription = Employee.Job.Description;
        departmentName = Employee.Job.Department.Name;
        employeeTypeDescription = (employeeTypes.Find(e => e.Id == Employee.EmployeeTypeId)).Description;
    }

    // everytime the department value change it's going to search the jobs for that specific department
    private async void OnSelectedValue(string value)
    {
        departmentName = value;
        jobDescription = "";

        int departmentId = (departments.Find(d => d.Name == value)).Id;
        jobs = (await JobService.GetJobsByDepartment(departmentId)).ToList();
    }

    private void Submit()
    {
        int jobId = (jobs.Find(j => j.Description == jobDescription)).Id;
        int employeeTypeId = (employeeTypes.Find(e => e.Description == employeeTypeDescription)).Id;
        Employee.JobId = jobId;
        Employee.EmployeeTypeId = employeeTypeId;
        MudDialog.Close(DialogResult.Ok(Employee));
    }
    private void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FlamingSoftHR.Client.Pages.UpdateEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudRadio_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudRadio<T>>(seq);
        __builder.AddAttribute(__seq0, "Option", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudNumericField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, global::MudBlazor.Adornment __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Variant", __arg2);
        __builder.AddAttribute(__seq3, "Adornment", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentIcon", __arg4);
        __builder.AddAttribute(__seq5, "HideSpinButtons", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591