using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public virtual User Student { get; set; }
        public virtual User Teacher { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
