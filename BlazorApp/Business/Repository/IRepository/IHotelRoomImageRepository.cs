using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomImageRepository
    {
        public Task<int> CreateRoomImage(HotelRoomImageDTO imageDTO);
        public Task<int> DeleteRoomImageByImageId(int imageId);
        public Task<int> DeleteRoomImageByImageUrl(string imageUrl);
        public Task<int> DeleteRoomImageByRoomId(int roomId);
        public Task<IEnumerable<HotelRoomImageDTO>> GetOneRoomImages(int roomId);
    }
}
