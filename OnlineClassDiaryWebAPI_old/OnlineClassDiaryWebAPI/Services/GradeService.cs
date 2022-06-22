using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class GradeService : IGradeService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GradeService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateGrade(GradeDto gradeDto)
        {
            var grade = _mapper.Map<Grade>(gradeDto);
            _dbContext.Grades.Add(grade);
            _dbContext.SaveChanges();
        }

        public void DeleteGrade(int id)
        {
            var grade = _dbContext.Grades.FirstOrDefault(c => c.Id == id);
            if (grade != null)
            {
                _dbContext.Grades.Remove(grade);
                _dbContext.SaveChanges();
            }
        }

        public void EditGrade(int id, GradeDto gradeDto)
        {
            var grade = _dbContext.Grades.FirstOrDefault(x => x.Id.Equals(id));
            grade.Value = gradeDto.Value;

            _dbContext.SaveChanges();
        }

        public GradeDto GetGrade(int id)
        {
            var gradeDb = _dbContext.Grades.FirstOrDefault(a => a.Id.Equals(id));
            if (gradeDb == null)
                return null;

            var gradeDto = _mapper.Map<GradeDto>(gradeDb);
            return gradeDto;
        }
    }
}
