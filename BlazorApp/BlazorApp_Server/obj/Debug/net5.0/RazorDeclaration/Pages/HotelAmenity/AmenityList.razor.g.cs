// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp_Server.Pages.HotelAmenity
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
#nullable restore
#line 3 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelAmenity\AmenityList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelAmenity\AmenityList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelAmenity\AmenityList.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity")]
    public partial class AmenityList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelAmenity\AmenityList.razor"
       
    private IEnumerable<AmenityDTO> amenities { get; set; } = new List<AmenityDTO>();
    private int? deleteAmenityId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;
    protected override async Task OnInitializedAsync()
    {
        amenities = await amenityRepos.GetAllAmenities();
    }

    private string calculateTimeString(float time)
    {
        float hour;
        float minute;
        string suffix = "am";
        string minutePrefix = "";
        hour = (time * 60) / 60;
        minute = (time * 60) % 60;
        if (hour / 12 >= 1)
        {
            hour = hour % 12;
            suffix = "pm";
        }
        if (minute / 10 < 1)
        {
            minutePrefix = "0";
        }
        return hour + ":" + minutePrefix + minute + " " + suffix;
    }

    private async Task HandleDelete(int amenityId)
    {
        deleteAmenityId = amenityId;
        await jsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }

    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && deleteAmenityId != null)
        {

            await amenityRepos.DeleteAmenity(deleteAmenityId.Value);
            await jsRuntime.SwalSuccess("Deleted Successfully");
            amenities = await amenityRepos.GetAllAmenities();
        }
        await jsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");
        IsProcessing = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAmenityRepos amenityRepos { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
