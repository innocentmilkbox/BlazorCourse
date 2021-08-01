using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp_Server.Service.IService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BlazorApp_Server.Service
{
    public class FileUpload : IFileUpload
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public FileUpload(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }
        public bool DeleteFile(string fileName)
        {            
            try
            {
                var path = $"{_webHostEnvironment.WebRootPath}\\RoomImages\\{fileName}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                //ValueTask
                var forderDirectory = $"{_webHostEnvironment.WebRootPath}\\RoomImages"; //equals wwwroot/roomimages
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "RoomImages", fileName);
                var memoryStream = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStream);

                if (!Directory.Exists(forderDirectory))
                {
                    Directory.CreateDirectory(forderDirectory);
                }
                await using(var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memoryStream.WriteTo(fs);
                }
                var url = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host.Value}/";
                //equal https or http + :// + localhost or any host name + /
                var fullPath = $"{url}RoomImages/{fileName}";
                return fullPath;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
