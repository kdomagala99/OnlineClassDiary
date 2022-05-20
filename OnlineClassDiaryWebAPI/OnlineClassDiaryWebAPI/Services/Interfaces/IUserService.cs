using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        public UserDto CreateUser(UserDto userDto);
        public UserDto EditUser(string username, UserDto userDto);
        public UserDto DeleteUser(string username);
        public UserDto GetUser(string username);
        public UserDto GetUsers();
    }
}
