using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public int Status_Id { get; set; }
        public int Teacher_Id { get; set; }
        public int Student_Id { get; set; }
        public virtual Status Status { get; set; }
        public virtual User Teacher { get; set; }
        public virtual User Student { get; set; }
    }
}
