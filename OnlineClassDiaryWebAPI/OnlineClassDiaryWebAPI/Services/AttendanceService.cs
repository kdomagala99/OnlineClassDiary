using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class AttendanceService : IAttendanceService
    {
        private OnlineClassDiaryDbContext _dbContext;
        private IMapper _mapper;
        public AttendanceService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public bool AddAttendance(string teacherEmail, string status, string studentName, string studentSurname, DateTime date)
        {
            var _status = _dbContext.Statuses.FirstOrDefault(s => s.Name == status);
            if (_status == null)
                return false;
            var teacher = _dbContext.Users.FirstOrDefault(t => t.Email == teacherEmail);
            if (teacher == null)
                return false;
            var student = _dbContext.Users.FirstOrDefault(s => s.Name == studentName && s.Surname == studentSurname);
            if (student == null)
                return false;

            Attendance attendance = new();
            attendance.Student = student;
            attendance.Status = _status;
            attendance.Date = date;
            attendance.Teacher = teacher;

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return true;
        }

        public List<AttendanceDto> GetAttendances()
        {
            List<AttendanceDto> list = _mapper.Map<List<AttendanceDto>>(_dbContext.Attendances
                .Include(a => a.Teacher)
                .Include(a => a.Student)
                .ToList());
            return list;
        }

        public bool RemoveAttendance(string studentName, string studentEmail, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
