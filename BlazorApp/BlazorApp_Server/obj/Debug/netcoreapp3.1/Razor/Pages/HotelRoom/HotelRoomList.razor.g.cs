#pragma checksum "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9cf60169371b44670dcffc929496f026b56efd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Server.Pages.HotelRoom
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
#line 3 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room")]
    public partial class HotelRoomList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"col-8\">\r\n        <h4 class=\"card-title text-info\">HotelRoomList</h4>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-3 offset-1");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "href", "hotel-room/create");
            __builder.AddAttribute(9, "class", "btn btn-info form-control");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Add New Room");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row mt-4");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-12");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, @"<thead>
                <tr>
                    <th>Name</th>
                    <th>Occupancy</th>
                    <th>Rate</th>
                    <th>Sqrt</th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 29 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                 if (HotelRooms.Any())
                {
                    foreach(var room in HotelRooms)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                        ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 34 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 35 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.Occupancy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 36 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.RegularRate.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 37 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.SqFt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "td");
            __builder.AddMarkupContent(43, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "href", 
#nullable restore
#line 39 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                 $"hotel-room/edit/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(48, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 42 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                    ");
            __builder.AddMarkupContent(53, "<tr>\r\n                        <td colspan=\"5\">No records found</td>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\hle96\ZZZZ\Blazor\BlazorCourse\BlazorCourse\BlazorApp\BlazorApp_Server\Pages\HotelRoom\HotelRoomList.razor"
       
    private IEnumerable<HotelRoomDTO> HotelRooms { get; set; } = new List<HotelRoomDTO>();
    protected override async Task OnInitializedAsync()
    {
        HotelRooms = await hotelRoomRepository.GetAllHotelRooms();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository hotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
