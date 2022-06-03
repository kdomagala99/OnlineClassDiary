using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(string email)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email.Equals(email));
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public void EditUser(User user)
        {
            var userDb = _dbContext.Users.FirstOrDefault(u => u.PESEL.Equals(user.PESEL));
            userDb = user;
            _dbContext.SaveChanges();
        }

        public UserDto GetUser(string email)
        {
            var userDto = new UserDto();
            var userDb = _dbContext.Users.FirstOrDefault(u => u.Email.Equals(email));
            if (userDb == null)
                throw new System.NotImplementedException();
            userDto = _mapper.Map<UserDto>(userDb);
            return userDto;
        }

        public List<UserDto> GetUsers()
        {
            var users = _mapper.Map<List<UserDto>>(_dbContext.Users.ToList());
            return users;
        }
    }
}
