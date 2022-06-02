using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IStatusService
    {
        public StatusDto GetStatus(string statusname);
        public void EditStatus(string statusname, StatusDto statusDto);
    }
}
