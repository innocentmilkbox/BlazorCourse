using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using System.IO;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public HotelRoomRepository(AppDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
                                      
        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDTO);
            hotelRoom.CreatedDate = DateTime.UtcNow;
            hotelRoom.CreatedBy = "";
            var addedHotelRoom = await _db.HotelRooms.AddAsync(hotelRoom);
            await _db.SaveChangesAsync();
            return _mapper.Map<HotelRoom, HotelRoomDTO>(addedHotelRoom.Entity);
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _db.HotelRooms.FindAsync(roomId);
            if(roomDetails != null)
            {
                var allImages = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
                //foreach(var image in allImages)
                //{
                //    if (File.Exists(image.RoomImageUrl)) File.Delete(image.RoomImageUrl);
                //}
                //Delete images in folder in the hotelroomlist.razor
                _db.HotelRoomImages.RemoveRange(allImages);
                _db.HotelRooms.Remove(roomDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms()
        {
            try
            {
                IEnumerable<HotelRoomDTO> hotelRoomDTOs =
                    _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>>(_db.HotelRooms.Include(x => x.HotelRoomImages));
                return hotelRoomDTOs;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> GetHotelRoom(int roomId)
        {
            try
            {                
                HotelRoomDTO hotelRoomDTO =
                    _mapper.Map<HotelRoom, HotelRoomDTO>(await _db.HotelRooms.Include(x => x.HotelRoomImages).FirstOrDefaultAsync(x => x.Id == roomId));
                return hotelRoomDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> IsRoomUnique(string name, int roomId = 0)
        {
            try
            {
                if(roomId == 0)
                {
                    HotelRoomDTO hotelRoomDTO =
                        _mapper.Map<HotelRoom, HotelRoomDTO>(await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));
                    return hotelRoomDTO;
                }
                else
                {
                    HotelRoomDTO hotelRoomDTO =
                        _mapper.Map<HotelRoom, HotelRoomDTO>(await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower() && x.Id != roomId));
                    return hotelRoomDTO;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> UpdateHotelRoom(int roomId, HotelRoomDTO hotelRoomDTO)
        {
            try
            {
                if (roomId == hotelRoomDTO.Id)
                {
                    HotelRoom roomDetails = await _db.HotelRooms.FindAsync(roomId);
                    HotelRoom room = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDTO, roomDetails);
                    room.UpdatedBy = "";
                    room.UpdatedDate = DateTime.UtcNow;
                    var updatedRoom = _db.HotelRooms.Update(room);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDTO>(updatedRoom.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
