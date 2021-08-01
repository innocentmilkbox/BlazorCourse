// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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