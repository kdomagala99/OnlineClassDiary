using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        public UserDto GetUser(string username);
        public UserDto EditUser(string username, UserDto userDto);
    }
}
