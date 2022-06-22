using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public SemesterService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateSemester(SemesterDto semesterDto)
        {
            var semester = _mapper.Map<Semester>(semesterDto);
           
            _dbContext.Semesters.Add(semester);
            _dbContext.SaveChanges();
        }

        public void DeleteSemester(int semesterId)
        {
            var semester = _dbContext.Semesters.FirstOrDefault(s => s.Id.Equals(semesterId));
            if(semester != null)
            {
                _dbContext.Semesters.Remove(semester);
                _dbContext.SaveChanges();
            }
        }

        public void EditSemester(int semesterId, SemesterDto semesterDto)
        {
            var semesterDb = _dbContext.Semesters.FirstOrDefault(s => s.Id.Equals(semesterId));
            semesterDb.Date_Begin = semesterDto.Date_Begin;
            semesterDb.Date_End = semesterDto.Date_End;

            _dbContext.SaveChanges();
        }

        public SemesterDto GetSemester(int semesterId)
        {  
            var semesterDb = _dbContext.Semesters.FirstOrDefault(s => s.Id.Equals(semesterId));
            if(semesterDb == null)
                return null;

            var semesterDto = _mapper.Map<SemesterDto>(semesterDb);
            return semesterDto;
        }

        public List<SemesterDto> GetSemesters()
        {
            var semesters = _mapper.Map<List<SemesterDto>>(_dbContext.Semesters.ToList());
            return semesters;
        }
    }
}
