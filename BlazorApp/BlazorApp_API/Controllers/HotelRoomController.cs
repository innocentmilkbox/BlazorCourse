using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace BlazorApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomController : ControllerBase
    {
        private readonly IHotelRoomRepository _roomRepos;

        public HotelRoomController(IHotelRoomRepository roomRepos)
        {
            _roomRepos = roomRepos;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRooms()
        {
            var allRooms = await _roomRepos.GetAllHotelRooms();
            return Ok(allRooms);
        }

        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetRoomById(int? roomId)
        {
            if (roomId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var roomDetails = await _roomRepos.GetHotelRoom(roomId.Value);
            if (roomDetails == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            return Ok(roomDetails);
        }


    }
}
