using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_Server.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);            
        }
        public static async ValueTask ToastrFailure(this IJSRuntime jsRuntime, string message)
        {            
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static async ValueTask SwalSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSwal", "success", message);
        }
        public static async ValueTask SwalFailure(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSwal", "error", message);
        }
    }
}
