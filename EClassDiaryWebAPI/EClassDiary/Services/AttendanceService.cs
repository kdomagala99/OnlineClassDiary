using AutoMapper;
using EClassDiary.Database;
using EClassDiary.Entities;
using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace EClassDiary.Services
{
    public class AttendanceService
    {
        private readonly EClassDiaryDbContext _dbContext;
        private IMapper _mapper;
        public AttendanceService(EClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<AttendanceDto> GetAllAttendances()
        {
            List<AttendanceDto> list = _mapper.Map<List<AttendanceDto>>(_dbContext.Attendances
                .Include(a => a.Teacher)
                .Include(a => a.Student)
                .ToList());
            return list;
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

        public bool DeleteAttendance(string studentName, string studentSurname, DateTime date)
        {
            var student = _dbContext.Users.FirstOrDefault(u => u.Name == studentName && u.Surname == studentSurname);
            if (student == null)
                return false;
            var attendance = _dbContext.Attendances.FirstOrDefault(a => a.Student.Equals(student));
            if (attendance == null)
                return false;
            _dbContext.Attendances.Remove(attendance);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
