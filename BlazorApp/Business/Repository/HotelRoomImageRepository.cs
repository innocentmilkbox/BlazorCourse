using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Business.Repository
{
    public class HotelRoomImageRepository:IHotelRoomImageRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public HotelRoomImageRepository(AppDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<int> CreateRoomImage(HotelRoomImageDTO imageDTO)
        {
            HotelRoomImage image = _mapper.Map<HotelRoomImageDTO, HotelRoomImage>(imageDTO);
            await _db.HotelRoomImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteRoomImageByImageId(int imageId)
        {
            HotelRoomImage image = await _db.HotelRoomImages.FirstOrDefaultAsync(x => x.Id == imageId);
            _db.HotelRoomImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteRoomImageByImageUrl(string imageUrl)
        {
            HotelRoomImage image = await _db.HotelRoomImages.FirstOrDefaultAsync(x => x.RoomImageUrl.ToLower() == imageUrl.ToLower());
            _db.HotelRoomImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteRoomImageByRoomId(int roomId)
        {
            var images = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
            _db.HotelRoomImages.RemoveRange(images);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelRoomImageDTO>> GetOneRoomImages(int roomId)
        {
            var images = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
            return _mapper.Map<IEnumerable<HotelRoomImage>, IEnumerable<HotelRoomImageDTO>>(images);
        }
    }
}
