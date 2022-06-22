using System;

namespace OnlineClassDiaryWebAPI.Entities.Dtos
{
    public class AttendanceDto
    {
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
    }
}
