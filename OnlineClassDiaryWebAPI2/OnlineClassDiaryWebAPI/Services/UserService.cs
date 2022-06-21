using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Entities.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;
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
