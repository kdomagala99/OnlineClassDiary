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

            //userDto.Name = userDb.Name;
            //userDto.Email = userDb.Email;
            //userDto.Surname = userDb.Surname;
            //userDto.PESEL = userDb.PESEL;
            //userDto.Role = new RoleDto() { Name = userDb.Role.Name };
            //if (userDb.Class != null)
            //{
            //    userDto.Class = new ClassDto()
            //    {
            //        Name = userDb.Class.Name,
            //        Description = userDb.Class.Description,
            //        Students_List = new List<UserDto>()
            //        {

            //        }
            //    };
            //}

            //if (userDb.Child != null)
            //{
            //    userDto.Child = new UserDto()
            //    {
            //        Name = userDb.Child.Name,
            //        Email = userDb.Child.Email,
            //        Surname = userDb.Child.Surname,
            //        PESEL = userDb.Child.PESEL,
            //        Role = new RoleDto() { Name = userDb.Child.Role.Name }

            //    };
            //}
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
