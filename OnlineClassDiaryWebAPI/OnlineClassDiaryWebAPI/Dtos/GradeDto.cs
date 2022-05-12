using System;

namespace OnlineClassDiaryWebAPI.Dtos
{
    public class GradeDto
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public UserDto Student { get; set; }
        public UserDto Teacher { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public SubjectDto Subject { get; set; }
        public SemesterDto Semester { get; set; }
    }
}
