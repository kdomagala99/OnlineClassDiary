using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;
using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        public bool LoginUser(string email, string password);
        public UserLoginDto GetUser(string email);
#nullable enable
        public bool AddUser(string email, string password, string name, string surname , string role, string? childEmail);
#nullable disable
        public List<User> GetAllUsers();
    }
}
