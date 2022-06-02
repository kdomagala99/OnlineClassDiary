using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        public void CreateUser(User user);
        public void EditUser(User user);
        public void DeleteUser(string email);
        public UserDto GetUser(string email);
        public UserDto GetUsers();
    }
}
