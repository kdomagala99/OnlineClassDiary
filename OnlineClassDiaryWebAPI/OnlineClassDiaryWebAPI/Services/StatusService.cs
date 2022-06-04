using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class StatusService : IStatusService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public StatusService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void EditStatus(string statusname, StatusDto statusDto)
        {
            var statusDb = _dbContext.Statuses.FirstOrDefault(s => s.Name.Equals(statusname));
            statusDb.Name = statusDto.Name;

            _dbContext.SaveChanges();
        }

        public StatusDto GetStatus(string statusname)
        {
            var statusDb = _dbContext.Statuses.FirstOrDefault(s => s.Name.Equals(statusname));
            if (statusDb == null)
                return null;

            var statusDto = _mapper.Map<StatusDto>(statusDb);

            return statusDto;
        }
    }
}
