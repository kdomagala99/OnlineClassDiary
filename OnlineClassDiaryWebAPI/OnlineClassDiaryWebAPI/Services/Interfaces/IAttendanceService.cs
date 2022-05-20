using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IAttendanceService
    {
        public AttendanceDto GetAttendance(int id);
        public AttendanceDto CreateAttendance(AttendanceDto attendanceDto);
        public AttendanceDto EditAttendance(int id, AttendanceDto attendanceDto);
    }
}
