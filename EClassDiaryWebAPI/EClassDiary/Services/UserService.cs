using EClassDiary.Database;
using EClassDiary.Entities;
using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace EClassDiary.Services
{
    public class UserService
    {
        private readonly EClassDiaryDbContext _dbContext;
        public UserService(EClassDiaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserLoginDto? GetUser(string email)
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

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

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
