using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class GradeService : IGradeService
    {
        private OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GradeService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public bool AddGrade(string imie, string nazwisko, decimal value, string subject, string email)
        {
            User teacher = _dbContext.Users.FirstOrDefault(u => u.Email == email);
            if (teacher == null)
                return false;
            User student = _dbContext.Users.FirstOrDefault(u => u.Name == imie && u.Surname == nazwisko);
            if (student == null)
                return false;
            Grade grade = new Grade();
            grade.Student = student;
            grade.Teacher = teacher;
            grade.Value = value;
            grade.Name = "empty";
            grade.Subject = _dbContext.Subjects.FirstOrDefault(s => s.Name == subject);
            DateTime now = DateTime.Now;
            grade.Date = now;
            Semester semester = _dbContext.Semesters.FirstOrDefault(s => s.DateBegin <= now && s.DateEnd >= now);
            grade.Semester = semester;
            _dbContext.Grades.Add(grade);
            _dbContext.SaveChanges();
            return true;
        }

        public List<List<GradeDto>> GetStudentGrades(string name, string surname)
        {
            List<List<GradeDto>> list = new List<List<GradeDto>>();
            Semester s1 = _dbContext.Semesters.FirstOrDefault(s => s.Name == "Winter");
            Semester s2 = _dbContext.Semesters.FirstOrDefault(s => s.Name == "Summer");
            User student = _dbContext.Users.FirstOrDefault(s => s.Name == name && s.Surname == surname);
            if (student == null)
                return null;
            List<GradeDto> l1 = _mapper.Map<List<GradeDto>>(_dbContext.Grades.Where(g => g.Semester.Equals(s1) && g.Student == student)
                .Select(g => new Grade
                {
                    Value = g.Value,
                    Name = g.Name,
                    Semester = g.Semester,
                    Student = g.Student,
                    Teacher = g.Teacher,
                    Date = g.Date,
                    Subject = g.Subject
                }).ToList());
            List<GradeDto> l2 = _mapper.Map<List<GradeDto>>(_dbContext.Grades.Where(g => g.Semester.Equals(s2) && g.Student == student)
                .Select(g => new Grade
                {
                    Value = g.Value,
                    Name = g.Name,
                    Semester = g.Semester,
                    Student = g.Student,
                    Teacher = g.Teacher,
                    Date = g.Date,
                    Subject = g.Subject
                }).ToList());

            if (l1 == null || l2 == null)
                return null;

            list.Add(l1);
            list.Add(l2);
            return list;
        }

        public void DeleteAllGrades()
        {
            foreach (var grade in _dbContext.Grades)
            {
                _dbContext.Remove(grade);
            }
            _dbContext.SaveChanges();
        }
    }
}
