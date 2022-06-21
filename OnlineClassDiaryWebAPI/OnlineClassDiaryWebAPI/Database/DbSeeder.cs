using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Database
{
    public class DbSeeder
    {

        private readonly OnlineClassDiaryDbContext _dbContext;
        public DbSeeder(OnlineClassDiaryDbContext dbContext)
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
                var data = GetRoles();
                _dbContext.Roles.AddRange(data);
                _dbContext.SaveChanges();
            }

            if (!_dbContext.Subjects.Any())
            {
                var data = GetSubjects();
                _dbContext.Subjects.AddRange(data);
                _dbContext.SaveChanges();
            }

            if (!_dbContext.Users.Any())
            {
                var data = GetUsers();
                _dbContext.Users.AddRange(data);
                _dbContext.SaveChanges();
            }

            if (!_dbContext.Semesters.Any())
            {
                var data = GetSemesters();
                _dbContext.Semesters.AddRange(data);
                _dbContext.SaveChanges();
            }
        }
        private IEnumerable<Semester> GetSemesters()
        {
            var list = new List<Semester>()
            {
               new Semester()
               {
                   DateBegin = Convert.ToDateTime("01/09/2021"),
                   DateEnd = Convert.ToDateTime("31/12/2021"),
                   Name = "Winter"
               },
               new Semester()
               {
                   DateBegin = Convert.ToDateTime("01/01/2022"),
                   DateEnd = Convert.ToDateTime("30/09/2022"),
                   Name = "Summer"
               },
            };
            return list;
        }

        private IEnumerable<Role> GetRoles()
        {
            var list = new List<Role>()
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
            return list;
        }
        private IEnumerable<User> GetUsers()
        {
            var list = new List<User>()
            {
                new User()
                {
                    Name = "Admin",
                    Surname = "Admin surname",
                    Email = "admin@example.com",
                    PasswordHash = "admin1",
                    Role = _dbContext.Roles.FirstOrDefault(r => r.Name == "Administrator"),
                    PESEL = "1111111111"
                },
                new User()
                {
                    Name = "Parent",
                    Surname = "Parent surname",
                    Email = "parent@example.com",
                    PasswordHash = "parent1",
                    Role = _dbContext.Roles.FirstOrDefault(r => r.Name == "Parent"),
                    PESEL = "1111111111"
                },
                new User()
                {
                    Name = "Teacher",
                    Surname = "Teacher surname",
                    Email = "teacher@example.com",
                    PasswordHash = "teacher1",
                    Role = _dbContext.Roles.FirstOrDefault(r => r.Name == "Teacher"),
                    PESEL = "1111111111"
                },
                new User()
                {
                    Name = "Student name",
                    Surname = "Student surname",
                    Email = "student@example.com",
                    PasswordHash = "student1",
                    Role = _dbContext.Roles.FirstOrDefault(r => r.Name == "Student"),
                    PESEL = "1111111111"
                },
            };
            return list;
        }
        private IEnumerable<Subject> GetSubjects()
        {
            var list = new List<Subject>()
            {
                new Subject()
                {
                    Name = "Mathematic",
                    Description = ""
                },
                new Subject()
                {
                    Name = "Polish",
                    Description = ""
                },
                new Subject()
                {
                    Name = "English",
                    Description = ""
                },
                new Subject()
                {
                    Name = "IT",
                    Description = ""
                },
            };
            return list;
        }
    }
}

