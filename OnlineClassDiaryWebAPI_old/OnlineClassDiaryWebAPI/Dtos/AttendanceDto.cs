using System;

namespace OnlineClassDiaryWebAPI.Dtos
{
    public class AttendanceDto
    {
        public DateTime Date{ get; set; }
        public StatusDto Status { get; set; }
        public UserDto Teacher { get; set; }
        public UserDto Student { get; set; }

    }
}
