#pragma checksum "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a4f5c1dd2c8d629a3d745a7021ad2cbf33e92e8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Server.Shared
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
#nullable restore
#line 11 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using BlazorApp_Server.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<BlazorApp_Server.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.AddMarkupContent(8, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n        ");
            __builder.OpenComponent<BlazorApp_Server.Shared.LoginDisplay>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
