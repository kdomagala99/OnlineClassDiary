using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;
        public AttendanceService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateAttendance(AttendanceDto attendanceDto)
        {
            var attendance = _mapper.Map<Attendance>(attendanceDto);

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
        }

        public void EditAttendance(int id, AttendanceDto attendanceDto)
        {
            var attendance = _dbContext.Attendances.FirstOrDefault(x => x.Id.Equals(id));
            attendance.Status = _mapper.Map<Status>(attendanceDto.Status);

            _dbContext.SaveChanges();
        }

        public AttendanceDto GetAttendance(int id)
        {
            var attendanceDb = _dbContext.Attendances.FirstOrDefault(a => a.Id.Equals(id));
            if (attendanceDb == null)
                return null;

            var attendanceDto = _mapper.Map<AttendanceDto>(attendanceDb);
            return attendanceDto;
        }
    }
}
