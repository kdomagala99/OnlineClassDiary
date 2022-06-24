using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Grade
    {
        public Grade()
        {
            Name = String.Empty;
            Student = new();
            Teacher = new();
            Subject = new();
            Semester = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }
        public virtual User Student { get; set; }
        public virtual User Teacher { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Semester Semester { get; set; }
        public DateTime Date { get; set; }
    }
}
