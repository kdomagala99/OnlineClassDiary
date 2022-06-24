using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Semester
    {
        public Semester()
        {
            Name = string.Empty;
        }
        public int Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Semester semester &&
                   Id == semester.Id &&
                   DateBegin == semester.DateBegin &&
                   DateEnd == semester.DateEnd &&
                   Name == semester.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DateBegin, DateEnd, Name);
        }
    }
}
