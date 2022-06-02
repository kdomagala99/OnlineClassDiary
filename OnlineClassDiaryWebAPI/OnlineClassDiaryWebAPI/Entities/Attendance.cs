﻿using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public virtual Status Status { get; set; }
        public virtual User Teacher { get; set; }
        public virtual User Student { get; set; }
    }
}
