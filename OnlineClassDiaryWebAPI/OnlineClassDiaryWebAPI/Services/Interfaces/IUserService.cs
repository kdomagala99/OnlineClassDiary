using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        public bool LoginUser(string email, string password);
        public UserLoginDto GetUser(string email);
    }
}
