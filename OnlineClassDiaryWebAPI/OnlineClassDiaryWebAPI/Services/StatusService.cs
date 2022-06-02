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

        public StatusService(OnlineClassDiaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void EditStatus(string statusname, StatusDto statusDto)
        {
            var statusDb = _dbContext.Statuses.FirstOrDefault(s => s.Name.Equals(statusname));
            statusDb.Name = statusDto.Name;

            _dbContext.SaveChanges();
        }

        public StatusDto GetStatus(string statusname)
        {
            var statusDto = new StatusDto();
            var statusDb = _dbContext.Statuses.FirstOrDefault(s => s.Name.Equals(statusname));
            if(statusDb == null)
                throw new System.NotImplementedException();

            statusDto.Name = statusDb.Name;

            return statusDto;
        }
    }
}
