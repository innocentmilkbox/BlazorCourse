#pragma checksum "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29a35d531ed85dcf058e8eca16af78b0a143e3b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Server.Pages.BlazorJS
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using BlazorApp_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using BlazorApp_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using BlazorApp_Server.Helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blazorjs")]
    public partial class BlazorJS : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlazorJS</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n   ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-secondary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
                                               (()=>TestClick(ConfirmMessage))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Test Button");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 11 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
     if (ConfirmResult)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.AddMarkupContent(14, "<p>Confirmed!</p>\r\n");
#nullable restore
#line 14 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.AddMarkupContent(16, "<p>Pending...</p>\r\n");
#nullable restore
#line 18 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-success");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
                                              TestSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Test Toastr Success");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
                                             TestFail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Test Toastr Fail");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-success");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
                                              SwalSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Test SweetAleart Success");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
                                             SwalFail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Test SweetAleart Fail");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\BlazorJS\BlazorJS.razor"
       
    private string ConfirmMessage = "Wanna click, huh?";
    private bool ConfirmResult { get; set; }

    private async Task TestClick(string message)
    {
        ConfirmResult = await jsRuntime.InvokeAsync<bool>("confirm", message);
    }
    private async Task TestSuccess()
    {
        await jsRuntime.ToastrSuccess("Success Message");
    }
    private async Task TestFail()
    {
        await jsRuntime.ToastrFailure("Failure Message");
    }
    private async Task SwalSuccess()
    {
        await jsRuntime.SwalSuccess("Swal Success Message");
    }
    private async Task SwalFail()
    {
        await jsRuntime.SwalFailure("Swal Failure Message");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
