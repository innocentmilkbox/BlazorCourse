// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp_Server.Pages.Learning
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using BlazorApp_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\_Imports.razor"
using BlazorApp_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\Pages\Learning\Index.razor"
using BlazorApp_Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Dell\Desktop\BlazorApp\BlazorApp_Server\Pages\Learning\Index.razor"
 
    string SelectedRoomProp = "";
    List<HotelRoom> RoomsList = new List<HotelRoom>();



    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomsList.Add(new HotelRoom()
        {
            Id = 201,
            RoomName = "Villa Suite",
            Price = 499,
            IsActive = true,
            RoomProps = new List<HotelRoomProp>
            {
                new HotelRoomProp{Id = 1, Name = "Sq ft", Value = "150"},
                new HotelRoomProp{Id = 2, Name = "Occupancy", Value = "13"}
            }
        });
        RoomsList.Add(new HotelRoom()
        {
            Id = 202,
            RoomName = "Villa Suite One Bed Room",
            Price = 399,
            IsActive = true,
            RoomProps = new List<HotelRoomProp>
            {
                new HotelRoomProp{Id = 1, Name = "Sq ft", Value = "100"},
                new HotelRoomProp{Id = 2, Name = "Occupancy", Value = "6"}
            }
        });
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
