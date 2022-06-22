using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Database
{
    public class OnlineClassDiaryDbSeeder
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        public OnlineClassDiaryDbSeeder(OnlineClassDiaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            var pendingMigrations = _dbContext.Database.GetPendingMigrations();
            if (pendingMigrations != null && pendingMigrations.Any())
            {
                _dbContext.Database.Migrate();
            }

            if (!_dbContext.Roles.Any())
            {
                var roles = GetRoles();
                _dbContext.Roles.AddRange(roles);
                _dbContext.SaveChanges();
            }

            if (!_dbContext.Users.Any())
            {
                var users = GetUsers();
                _dbContext.Users.AddRange(users);
                _dbContext.SaveChanges();
            }
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "Administrator"
                },
                new Role()
                {
                    Name = "Teacher"
                },
                new Role()
                {
                    Name = "Parent"
                },
                new Role()
                {
                    Name = "Student"
                }
            };
            return roles;
        }

        private IEnumerable<User> GetUsers()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Name = "AdminName",
                    Surname = "AdminSurname",
                    PESEL = "80111902845",
                    Email = "admin@example.com",
                    PasswordHash = "admin1",
                    Role = _dbContext.Roles.Where(r => r.Name.Equals("Administrator")).FirstOrDefault()
                }
            };

            return users;
        }
    }
}
