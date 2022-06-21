using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Semester
    {
        public int Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Name { get; set; }
    }
}
