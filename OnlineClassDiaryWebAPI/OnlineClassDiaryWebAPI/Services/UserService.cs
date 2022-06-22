using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class UserService : IUserService
    {
        private OnlineClassDiaryDbContext _dbContext;
        public UserService(OnlineClassDiaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
#nullable enable
        public bool AddUser(string email, string password, string name, string surname, string role, string? childEmail)
        {
            var _role = _dbContext.Roles.FirstOrDefault(r => r.Name == role);
            if (_role == null)
                return false;
            var user = new User();
            if (childEmail != null)
            {
                var child = _dbContext.Users.FirstOrDefault(u => u.Email == childEmail);
                if (child == null)
                    return false;
                user.Child = child;
            }
            user.Email = email;
            user.PasswordHash = password;
            user.PESEL = "2222222";
            user.Name = name;
            user.Surname = surname;
            user.Role = _role;
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return true;
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
#nullable disable
        public UserLoginDto GetUser(string email)
        {
            var user = _dbContext.Users.Include(u => u.Role).FirstOrDefault(u => u.Email == email);
            if (user == null)
                return null;
            UserLoginDto result = new UserLoginDto();
            result.Surname = user.Surname;
            result.Name = user.Name;
            result.Role = user.Role.Name;
            return result;
        }

        public bool LoginUser(string email, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return false;
            if (user.PasswordHash != password)
                return false;
            return true;
        }
    }
}
