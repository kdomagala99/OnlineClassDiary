using OnlineClassDiaryWebAPI.Entities.Dtos;
using System;
using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IAttendanceService
    {
        public List<AttendanceDto> GetAttendances();
        public bool AddAttendance(string teacherEmail, string status, string studentName, string studentSurname, DateTime date);
        public bool RemoveAttendance(string studentName, string studentEmail, DateTime date);
    }
}
