using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
    public interface IAmenityRepos
    {
        public Task<AmenityDTO> CreateAmenity(AmenityDTO amenityDto);
        public Task<AmenityDTO> UpdateAmenity(int amenityId, AmenityDTO amenityDTO);
        public Task<AmenityDTO> GetAmenity(int amenityId);
        public Task<IEnumerable<AmenityDTO>> GetAllAmenities();
        public Task<AmenityDTO> IsAmenityUnique(string amenityName, int amenityId = 0);
        public Task<int> DeleteAmenity(int amenityId);

    }
}
