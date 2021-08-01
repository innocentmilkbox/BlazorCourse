using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Business.Repository
{
    public class AmenityRepos : IAmenityRepos
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public AmenityRepos(AppDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<AmenityDTO> CreateAmenity(AmenityDTO amenityDto)
        {
            Amenity createdAmenity = _mapper.Map<AmenityDTO, Amenity>(amenityDto);
            var result = await _db.Amenities.AddAsync(createdAmenity);
            await _db.SaveChangesAsync();
            return _mapper.Map<Amenity, AmenityDTO>(result.Entity);
        }

        public async Task<int> DeleteAmenity(int amenityId)
        {
            Amenity deleteAmenity = await _db.Amenities.FirstOrDefaultAsync(x => x.Id == amenityId);
            if (deleteAmenity != null)
            {
                _db.Amenities.Remove(deleteAmenity);
            }
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<AmenityDTO>> GetAllAmenities()
        {
            return _mapper.Map<IEnumerable<Amenity>, IEnumerable<AmenityDTO>>(
                _db.Amenities);
        }

        public async Task<AmenityDTO> GetAmenity(int amenityId)
        {
            AmenityDTO amem = _mapper.Map<Amenity, AmenityDTO>(await _db.Amenities.FirstOrDefaultAsync(x => x.Id == amenityId));            
            return amem;
            
        }

        public async Task<AmenityDTO> IsAmenityUnique(string amenityName, int amenityId = 0)
        {
            if(amenityId == 0)
            {
                AmenityDTO amem = _mapper.Map<Amenity, AmenityDTO>(await _db.Amenities.FirstOrDefaultAsync(x => x.Name.ToLower() == amenityName.ToLower()));
                return amem;
            }
            else
            {
                AmenityDTO amem = _mapper.Map<Amenity, AmenityDTO>(await _db.Amenities.FirstOrDefaultAsync(x => x.Name.ToLower() == amenityName.ToLower()&&x.Id!=amenityId));
                return amem;
            }
        }

        public Task<AmenityDTO> UpdateAmenity(int amenityId, AmenityDTO amenityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
