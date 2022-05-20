using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IStatusService
    {
        public StatusDto GetStatus(int id);
        public StatusDto EditStatus(int id, StatusDto statusDto);
    }
}
