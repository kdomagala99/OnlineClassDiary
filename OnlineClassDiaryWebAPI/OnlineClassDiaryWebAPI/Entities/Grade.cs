using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Student_Id { get; set; }
        public int Teacher_Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Subject_Id { get; set; }
        public int Semester_Id { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
