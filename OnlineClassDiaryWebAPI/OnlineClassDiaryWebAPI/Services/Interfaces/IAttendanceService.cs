using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IAttendanceService
    {
        public AttendanceDto GetAttendance(int id);
        public void CreateAttendance(AttendanceDto attendanceDto);
        public void EditAttendance(int id, AttendanceDto attendanceDto);
    }
}
